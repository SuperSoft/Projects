using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;

namespace ConfigExample
{
    public class Parse
    {
        private string nameSpace = "http://schemas.PanPort.com/pag/cab-profile/2.0/";

        public string NameSpace
        {
            get { return nameSpace; }
            set { nameSpace = value; }
        }

        private string xmlPath = "Sample.xml";

        public string XmlPath
        {
            get { return xmlPath; }
            set { xmlPath = value;}
        }

        private string xsdPath = "Sample.xsd";

        public string XsdPath
        {
            get { return xsdPath; }
            set { xsdPath = value; }
        }

        public List<sampleGroupComplexChildrenChild> ParseXml()
        {
            string xml = File.ReadAllText(XmlPath);

            if (String.IsNullOrEmpty(xml))
                return new List<sampleGroupComplexChildrenChild>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return ParseXml(xml);
        }

        public List<sampleGroupComplexChildrenChild> ParseXml(string xml)
        {
            sampleGroup sample = DeserializeXml<sampleGroup>(xml, XsdPath, NameSpace);
            sampleGroupComplex complex = (sampleGroupComplex)sample.Items[1];

            List<sampleGroupComplexChildrenChild> childrenList = new List<sampleGroupComplexChildrenChild>();

            if (complex.children != null)
            {
                childrenList = complex.children.ToList();
            }

            return childrenList;
        }

        private TRootElement DeserializeXml<TRootElement>(string xml, string xsdResourceName, string schemaUri)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TRootElement));

            using (XmlReader reader = GetValidatingReader(xml, xsdResourceName, schemaUri))
                return (TRootElement)serializer.Deserialize(reader);
        }

        private XmlReader GetValidatingReader(string xml, string xsdResourceName, string schemaUri)
        {
            //Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format("{1}.{0}", xsdResourceName, NameSpace));
            XmlTextReader schemaReader = new XmlTextReader(xsdResourceName);
            //stream.Dispose();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(schemaUri, schemaReader);
            StringReader xmlStringReader = new StringReader(xml);
            XmlReader catalogReader = XmlReader.Create(xmlStringReader, settings);

            return catalogReader;
        }
    }
}
