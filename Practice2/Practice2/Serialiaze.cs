using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Practice2
{
    public static class Serialize
    {
        public static void ToXml<T>(ref T inObject, string inFileName)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(T));
                StreamWriter file = new StreamWriter(inFileName);
                writer.Serialize(file, inObject);

                file.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void FromXml<T>(ref T inObject, string inFileName)
        {
            if (File.Exists(inFileName))
            {
                XmlSerializer reader = new XmlSerializer(typeof(T));
                StreamReader file = new StreamReader(inFileName);
                inObject = (T)reader.Deserialize(file);

                file.Close();
            }
        }

        public static void ToJson<T>(ref T inObject, string inFileName)
        {
            try
            {
                JavaScriptSerializer writer = new JavaScriptSerializer();
                string json = writer.Serialize(inObject);

                StreamWriter file = new StreamWriter(inFileName);
                file.Write(json);
                file.Close();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void FromJson<T>(ref T inObject, string inFileName)
        {
            if (File.Exists(inFileName))
            {
                JavaScriptSerializer reader = new JavaScriptSerializer();
                StreamReader file = new StreamReader(inFileName);

                inObject = (T)reader.Deserialize<T>(file.ReadLine());
                
                file.Close();
            }
        }
    }
}
