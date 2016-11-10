using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using ProtoBuf;

namespace MobileOperatorApp
{
    public class MySerializer
    {
        public long XmlSerialization(List<MobileAccount> mobOp)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            XmlSerializer formatter = new XmlSerializer(typeof(List<MobileAccount>));
            using (FileStream stream = new FileStream("XmlFile.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, mobOp);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public void XmlDeserialization(List<MobileAccount> mobOp)
        {
            ///XmlSerializer formatter = new XmlSerializer(typeof(List<MobileAccount>));
            ///using (FileStream stream = new FileStream("XmlFile.xml", FileMode.Open))
            ///{
            ///    stream.Length
            ///    mobOp = (List<MobileAccount>)formatter.Deserialize(stream);
            ///}
            ///int i = 0;
        }

        public long BinarySerialization(List<MobileAccount> mobOp)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BinaryFile.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, mobOp);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public long JsonSerialization(List<MobileAccount> mobOp)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream("JsonFile.json", FileMode.OpenOrCreate))
            {
                formatter.WriteObject(fs, mobOp);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public long ProtoBufSerializer(List<MobileAccount> m)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            using (FileStream fs = new FileStream("Protobuf.txt", FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, m);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
