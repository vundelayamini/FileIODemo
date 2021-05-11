using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FileIODemo
{
    class XmlOperation
    {
        /// <summary>
        /// Xml serialization
        /// </summary>
        public static void XmlSerialize()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\XmlData.txt";
                Testperson p = new Testperson();
                //var res = typeof(Testperson);
                XmlSerializer xml = new XmlSerializer(typeof(Testperson));
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                xml.Serialize(stream, p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Xml deserialization
        /// </summary>
        public static void XmlDeSerialize()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\XmlData.txt";
                Testperson p = new Testperson();
                //var res = typeof(Testperson);
                XmlSerializer xml = new XmlSerializer(typeof(Testperson));
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                Testperson result = (Testperson)xml.Deserialize(stream);
                Console.WriteLine("FirstName\t" + result.FirstName + "\tLastName\t" + result.LastName);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public class Testperson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
    }
}



