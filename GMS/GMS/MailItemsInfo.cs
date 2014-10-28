using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GMS
{

    [Serializable()]
    public class MailItemsInfo : ISerializable
    {
       
        private List<MailItemInfo> mailItemsInfos;

        public List<MailItemInfo> MailItemsInfos
        {
            get { return this.mailItemsInfos; }
            set { this.mailItemsInfos = value; }
        }

        public MailItemsInfo()
        {
        }

        public MailItemsInfo(SerializationInfo info, StreamingContext ctxt)
        {
            this.MailItemsInfos = (List<MailItemInfo>)info.GetValue("MailItemsInfos", typeof(List<MailItemInfo>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("MailItemsInfos", this.MailItemsInfos);
        }
    }
}