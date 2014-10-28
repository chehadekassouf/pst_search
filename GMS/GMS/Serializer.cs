using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GMS
{
    public class Serializer
    {

        public Serializer()
        {
        }

        public void SerializeObject(string filepath, MailTable mailTable)
        {

            Stream stream = File.Open(filepath+"\\"+mailTable.FileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, mailTable);
            stream.Close();
        }

        public MailTable DeSerializeObject(string filename)
        {
            MailTable objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open,FileAccess.Read);
            
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (MailTable)bFormatter.Deserialize(stream);           
            stream.Close();
            return objectToSerialize;
        }
    }
}