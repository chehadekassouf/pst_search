using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GMS
{

        [Serializable()]
        public class MailItemInfo : ISerializable
        {
            private string senderName;
            private string to;
            private string subject;
            private string body;
            private string attachmentsCount;
            private string fullFolderPath;
            private string converstationIndex;
            private string converstationTopic;

            public string SenderName { get { return senderName; } }
            public string To { get { return to; } }
            public string Subject { get { return subject; } }
            public string Body { get { return body; } }
            public string AttachmentsCount { get { return attachmentsCount; } }
            public string FullFolderPath { get { return fullFolderPath; } }
            public string ConverstationIndex { get { return converstationIndex; } }
            public string ConverstationTopic { get { return converstationTopic; } }

            public MailItemInfo(string[] str)
            {
                senderName = str[0];
                to= str[1];
                subject= str[2];
                body= str[3];
                attachmentsCount= str[4];
                fullFolderPath = str[5];
                converstationIndex = str[6];
                converstationTopic = str[7];
            }

            public MailItemInfo(SerializationInfo info, StreamingContext ctxt)
            {

                this.senderName = (string)info.GetValue("SenderName", typeof(string));
                this.to = (string)info.GetValue("To", typeof(string)); 
                this.subject = (string)info.GetValue("Subject", typeof(string)); 
                this.body = (string)info.GetValue("Body", typeof(string)); 
                this.attachmentsCount = (string)info.GetValue("AttachmentsCount", typeof(string)); 
                this.fullFolderPath = (string)info.GetValue("FullFolderPath", typeof(string));
                this.converstationIndex = (string)info.GetValue("ConverstationIndex", typeof(string));
                this.converstationTopic = (string)info.GetValue("ConverstationTopic", typeof(string)); 
            }

            public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
            {
                info.AddValue("SenderName", this.SenderName);
                info.AddValue("To", this.To);
                info.AddValue("Subject", this.Subject);
                info.AddValue("Body", this.Body);
                info.AddValue("AttachmentsCount", this.AttachmentsCount);
                info.AddValue("FullFolderPath", this.FullFolderPath);
                info.AddValue("ConverstationIndex", this.ConverstationIndex);
                info.AddValue("ConverstationTopic", this.ConverstationTopic);

            }
        }

    
}
