using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GMS
{
    [Serializable()]
    public class MailTable : ISerializable
    {
        private DataTable baseTable;
        private string filename;
        private string modifieddata;
         public DataTable BaseTable
        {
            get { return this.baseTable; }
            set { this.baseTable = value; }
        }
         public string FileName
         {
             get { return this.filename; }
             set { this.filename = value; }
         }
         public string ModifiedData
         {
             get { return this.modifieddata; }
             set { this.modifieddata = value; }
         }
         public MailTable(string filename)
        {
            this.filename = filename.ToUpper().Replace(".PST","")+".OSE";
            baseTable = new DataTable();
            baseTable.Columns.Add("From");
            baseTable.Columns.Add("To");
            baseTable.Columns.Add("CC");
            baseTable.Columns.Add("ToCC");
            baseTable.Columns.Add("MailDate");
            baseTable.Columns.Add("MailTime");
            baseTable.Columns.Add("Subject");
            baseTable.Columns.Add("Body");
            baseTable.Columns.Add("AttachmentsName");
            baseTable.Columns.Add("AttachmentsCount");
            baseTable.Columns.Add("FullFolderPath");
            baseTable.Columns.Add("ConversationIndex");
            baseTable.Columns.Add("MailID");
            baseTable.Columns.Add("StoreID");


        }
         public void AddRow(string[] indata)
         {
             this.baseTable.Rows.Add(indata);
         }
         public MailTable(SerializationInfo info, StreamingContext ctxt)
        {
            this.BaseTable = (DataTable)info.GetValue("MailTable", typeof(DataTable));
            if (info.MemberCount >= 3)
            {
                this.FileName = info.GetValue("FileName", typeof(string)) as string;
                this.ModifiedData = info.GetValue("ModifiedData", typeof(string)) as string;
            }
        }

         public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("MailTable", this.BaseTable);
            info.AddValue("FileName", this.FileName);
            info.AddValue("ModifiedData", this.ModifiedData);
        }
         public static DataTable getTable(DataTable BaseTable,string filter,string sort,bool validlicense)
         {

             DataTable rdt = BaseTable.Clone();
             long i = 0;
             foreach (DataRow dr in BaseTable.Select(filter,sort))
             {
                 rdt.ImportRow(dr);
                 if (i++ > 3 && !validlicense)
                 {
                     break;
                 }
             }
             rdt.Columns["ToCC"].SetOrdinal(10);
             return rdt;

         }
    }
}
