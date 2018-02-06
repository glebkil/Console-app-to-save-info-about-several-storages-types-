using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorphism_hw_with_dependency_injection
{
    public class XMLPriceListSerializer : IPriceListSerialize
    {
        public List<Storage> Load()
        {
            List<Storage> loadedList = new List<Storage>();
            /*
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load("Price list data");
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(List<Storage>);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        loadedList = (List<Storage>)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
            }  */          
            return loadedList;
        }

        public void Save(List<Storage> list)
        {
           /* if (list == null) { return; }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(list.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, list);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save("Price list data");
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }*/
        }
    }
}
