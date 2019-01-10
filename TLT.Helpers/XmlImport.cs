#region

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

#endregion

namespace TLT.Helpers {

    public static class XmlImport {
        public static FileStream CleanXml(string input_file, string output_file, string xsl_transformer, string folder_path)
        {
            // Enable XSLT debugging.
            var xslt = new XslCompiledTransform(true);

            // Compile the style sheet.
            xslt.Load($@"{folder_path}{xsl_transformer}.xsl");

            // Execute the XSLT transform.
            var output_stream = new FileStream($@"{folder_path}{output_file}.xml", FileMode.Create);

            try {
                xslt.Transform($@"{folder_path}{input_file}.xml", null, output_stream);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
            finally {
                output_stream?.Close();
            }

            return output_stream;
        }

        public static object XmlToObjects(string xml, Type object_type)
        {
            StringReader  str_reader = null;
            XmlTextReader xml_reader = null;
            object        obj;

            try {
                str_reader = new StringReader(xml);
                var serializer = new XmlSerializer(object_type);
                xml_reader = new XmlTextReader(str_reader);
                obj        = serializer.Deserialize(xml_reader);
            }
            catch (Exception e) {
                Console.WriteLine(e);
                throw;
            }
            finally {
                xml_reader?.Close();
                str_reader?.Close();
            }

            return obj;
        }
    }

}