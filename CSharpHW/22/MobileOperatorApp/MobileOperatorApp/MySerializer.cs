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
using System.Xml.Linq;
using System.IO.Compression;
using System.Xml;

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

        public List<MobileAccount> XmlDeserialization()
        {
            //XDocument doc = XDocument.Load("XmlFile.xml");
            //XElement element = doc.Element("ArrayOfMobileAccount");

            //var list = from acc in element.Elements("MobileAccount")
            //           select new MobileAccount
            //           {
            //               Name = (string)acc.Element("Name").Value,
            //               PhoneNum = (string)acc.Element("PhoneNum").Value,
            //               RateOfActivity = double.Parse(acc.Element("RateOfActivity").Value),
            //               RateOfInputCalls = int.Parse(acc.Element("RateOfInputCalls").Value),
            //               Money = int.Parse(acc.Element("Money").Value)
            //           };

            //return list.ToList();

            List<MobileAccount> list;
            XmlSerializer formatter = new XmlSerializer(typeof(List<MobileAccount>));
            using (FileStream fs = new FileStream("XmlFile.xml", FileMode.OpenOrCreate))
            {
                list = (List<MobileAccount>)formatter.Deserialize(fs);
            }
            return list;
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
