using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIODemo
{
   public class BinaryOperations
   {
        public static void BinarySerialization()
        {
            string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Person.txt";
            person person = new person();
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            binary.Serialize(file, person);
        }
        public static void BinaryDeSerialization()
        {
            string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Person.txt";
            person person = new person();
            BinaryFormatter binary = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);
            person result =(person) binary.Deserialize(file);
            Console.WriteLine("FirstName\t" + result.FirstName + "\tLastName\t" + result.LastName);
        }
    }

    [Serializable]
     class person
     {
        public string FirstName{ get; set; }="Yamini";
        public string LastName { get; set; } = "Mahesh";

     }
}
        

        
            

