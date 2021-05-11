using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIODemo
{
    class JsonIOOperations
    { 
        /// <summary>
        /// Json serialization
        /// </summary>
        public static void JsonSerialize()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\JsonData.Json";
                Contact contact = new Contact() { Id = 101, FirstName = "Jhanu", LastName = "Gayi" };
                String res = JsonConvert.SerializeObject(contact);

               
                    File.WriteAllText(path, res);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Json Desearialization
        /// </summary>
        public static void JsonDeSerialize()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\JsonData.Json";
                string result =  File.ReadAllText(path);
                Contact obj = JsonConvert.DeserializeObject<Contact>(result);
                
                Console.WriteLine("Id:"+obj.Id+"\t"+"FirstName:"+obj.FirstName+"\t"+"LastName:"+obj.LastName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Contact
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 

    }
}
        

