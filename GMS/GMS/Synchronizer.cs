using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS
{
    class Synchronizer
    {
        public Synchronizer(string cataloguepath)
        { 
        }
        public void checkFiles(string cataloguepath)
        {
            foreach (string filepath in System.IO.Directory.GetFiles(cataloguepath, "*.ose"))
            {
                MailTable mt = new Serializer().DeSerializeObject(filepath);
                if(IsPSTModified(mt.ModifiedData,""))
                {
                    return;
                }
            }
        }
        public bool IsPSTModified(string modifieddata, string pstfullpath)
        {
            System.IO.FileInfo fsi = new System.IO.FileInfo(pstfullpath);
            if (fsi.LastWriteTime.ToString() == modifieddata)
            {
                return true;
            }
            return false;

        }
    }
}
