using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace GMS
{
    public class OutlookSearcher
    {
       
        MailTable mailTable = new MailTable("test");
        public OutlookSearcher()
        { 
        }
        public bool BuildCatalogue(string outfolder)
        {
            bool unchanged = true;
           Microsoft.Office.Interop.Outlook.Application otlApplication = new Microsoft.Office.Interop.Outlook.Application();
           try
           {
               Outlook.NameSpace otlNameSpace = otlApplication.GetNamespace("MAPI");
               
               foreach (Outlook.Store otlStore in otlNameSpace.Stores)
               {
                   
                   
                   if (otlStore.DisplayName == "Public Folders")
                   {
                       continue;
                   }
                   string pststamp = StampPST((Outlook.Folder)otlStore.GetRootFolder());
                   System.IO.FileInfo fi = new System.IO.FileInfo(otlStore.FilePath);
                   this.mailTable = new MailTable(fi.Name);
                   System.IO.FileInfo mtfi = new System.IO.FileInfo(outfolder + "\\" + this.mailTable.FileName);
                   if (mtfi.Exists)
                   {
                       try
                       {
                           
                           MailTable mt = new Serializer().DeSerializeObject(mtfi.FullName);
                           if (pststamp  == mt.ModifiedData)
                           {
                               continue;
                           }
                       }
                       catch
                       {
                       }
                   }
                   unchanged = false;
                       try
                       {
                           analyseFolder((Outlook.Folder)otlStore.GetRootFolder());
                       }
                       catch
                       {
                       }


                   this.mailTable.ModifiedData = pststamp;
                   new Serializer().SerializeObject(outfolder,  this.mailTable);
               }
               
           }
           catch
           {
           }
           finally
           {
               otlApplication = null;
           }
           return unchanged;

        }

        public MailTable ReadCatalogue(string CataloguePath)
        {
            

            foreach (string filepath in System.IO.Directory.GetFiles(CataloguePath, "*.ose"))
            {

                
                MailTable mt = (new Serializer().DeSerializeObject(filepath));
                //System.IO.FileInfo fi=new System.IO.FileInfo(filepath);
                //mt.FileName = fi.Name;
                foreach (System.Data.DataRow dr in mt.BaseTable.Select())
                {
                    //string s = DateTime.Parse( dr["mailtime"].ToString()).ToString("HH:mm:ss");
                    //dr["mailtime"] = s;
                    mailTable.BaseTable.ImportRow(dr);
                }
                
                
                //new Serializer().SerializeObject("C:\\Mails\\OSE_Test\\", mt);

            }
            return mailTable;
        }
        public MailTable ReadCatalogue(string CataloguePath,string filter)
        {
            
            foreach (string filepath in System.IO.Directory.GetFiles(CataloguePath, "*.ose"))
            {

                foreach (System.Data.DataRow dr in (new Serializer().DeSerializeObject(filepath)).BaseTable.Select(filter))
                {
                    
                    mailTable.BaseTable.ImportRow(dr);
                }

                
            }
            return mailTable;
        }
        public static void openEmail(string emailid,string storeid)
        {
            Microsoft.Office.Interop.Outlook.Application otlApplication = new Microsoft.Office.Interop.Outlook.Application();
            try
            {
                
                Outlook.NameSpace otlNameSpace = otlApplication.GetNamespace("MAPI");
                Outlook.MailItem mi = (Outlook.MailItem)otlNameSpace.GetItemFromID(emailid, storeid);
                mi.Display(false);
            }
            catch (Exception exp)
            {
                
                throw new Exception("PST not there"+exp.Message);
            }
            finally { otlApplication = null; }
 
        }
        public static string replacePSTPath(string storeID, string newPath)
        {
            return storeID.Replace(getHexPSTPath(storeID), convertStringToHex(newPath));
        }
        private static string getHexPSTPath(string sStoreID)
        {
            
            string filepathid = sStoreID.Substring(100);
            if (filepathid.Substring(0, 8) == "00000000")
            {
                filepathid= filepathid.Substring(6);

                return filepathid;
            }
            else
            {
                filepathid = filepathid.Substring(6);
               
                return filepathid;
            }
            
        }
         private static string convertStringToHex(string stringValue)
        {
            string returnhex = "";
            foreach (char cv in stringValue)
            {
                int iv = (char)cv;
                returnhex = returnhex + iv.ToString("X");
            }
            return returnhex+"00";
        }
        public static string getPSTPath(string sStoreID)
        {

            string sRes="";
            string filepathid = getHexPSTPath(sStoreID);
    

            try
            {

               sRes= Hex2ToString(filepathid.Substring(0,filepathid.Length-2));
               System.IO.FileInfo fi = new System.IO.FileInfo(sRes);
            }
            catch 
            {
                sRes = Hex4ToString(filepathid.Substring(0,filepathid.Length-6));
            }

            return sRes;
        }
        private static string Hex4ToString(string hexstring)
        {
            string retrunstring = "";
            for (int i = 0; i < hexstring.Length; i += 4)
            {
                int htoi = Convert.ToInt32(hexstring.Substring(i+2, 2), 16);
                retrunstring = retrunstring + (char)(htoi);
            }
            return retrunstring;
        }
        private static string Hex2ToString(string hexstring)
        {
            string retrunstring = "";
            for (int i = 0; i < hexstring.Length; i += 2)
            {
                int htoi = Convert.ToInt32(hexstring.Substring(i, 2), 16);
                retrunstring = retrunstring + (char)(htoi);
            }
            return retrunstring;
        }
        private void analyseFolder(Outlook.Folder otlFolder)
        {
            
            foreach (object otlItem in otlFolder.Items)
            {

                try
                {
                    Outlook.MailItem otlMailItem = otlItem as Outlook.MailItem;
                    if (otlMailItem != null)
                    {
                        string[] sn = new string[14];
                        sn[0] = otlMailItem.SenderName+"("+otlMailItem.SenderEmailAddress+")";
                        sn[1] = otlMailItem.To;
                        sn[2] = otlMailItem.CC;
                        sn[3] = sn[1]+sn[2];
                        sn[4] = otlMailItem.CreationTime.ToString("yyyy-MM-dd");
                        sn[5] = otlMailItem.CreationTime.ToString("HH:mm:ss");
                        sn[6] = otlMailItem.Subject;
                        sn[7] = otlMailItem.Body;
                        sn[8] = this.getAttachemmentsName(otlMailItem.Attachments);
                        sn[9] = otlMailItem.Attachments.Count.ToString();
                        sn[10] = otlFolder.FullFolderPath;
                        sn[11] = otlMailItem.ConversationIndex;
                        sn[12] = otlMailItem.EntryID;
                        sn[13] = otlFolder.StoreID;
                       

                        mailTable.AddRow(sn);


                    }
                }
                catch
                {


                }


            }
            foreach (Outlook.Folder otlSubFolder in otlFolder.Folders)
            {
                try
                {
                    analyseFolder(otlSubFolder);
                }
                catch 
                { 
                }
 
            }
        }
        private string StampPST(Outlook.Folder otlFolder)
        {

            string pststamp=otlFolder.Items.Count.ToString();
            foreach (Outlook.Folder otlSubFolder in otlFolder.Folders)
            {
                try
                {
                   pststamp= pststamp+","+ StampPST(otlSubFolder);
                }
                catch
                {
                }

            }
            return pststamp;
        }
        public string getAttachemmentsName(Outlook.Attachments otlAttachements)
        {
            string att = "";
            try
            {
                foreach (Outlook.Attachment otlatt in otlAttachements)
                {
                    att = att + otlatt.FileName + " , ";
                }
            }
            catch
            { 
            }
            return att;
        }
        public MailTable IndexSinglePst()
        {
            Microsoft.Office.Interop.Outlook.Application otlApplication = new Microsoft.Office.Interop.Outlook.Application();
            try
            {
                Outlook.NameSpace otlNameSpace = otlApplication.GetNamespace("MAPI");

                Outlook.Store otlStore = otlNameSpace.PickFolder().Store;
                System.IO.FileInfo fi = new System.IO.FileInfo(otlStore.FilePath);
                this.mailTable = new MailTable((new System.IO.FileInfo(otlStore.FilePath)).Name);
                this.mailTable.ModifiedData = fi.FullName + fi.Length.ToString();
                //this.mailTable.BaseTable = GMS.MailTable.getTable(this.mailTable.BaseTable, basetable.Select("StoreID<>'"+otlStore.StoreID.ToString()+"'"));
                    try
                       {
                           analyseFolder((Outlook.Folder)otlStore.GetRootFolder());
                       }
                       catch
                       {
                       }


                    }

                
            
            catch
            {
            }
            finally
            {
                otlApplication = null;
            }
            
            return this.mailTable;
        }
        
       
    }
}
