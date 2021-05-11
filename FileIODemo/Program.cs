using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
            //FileExists();
            //ReadAllLines();
            //ReadAtOnce();
            //CopyFile();
            //DeleteFile();
            //ReadingDataFromStream(path);
            // WriteDataIntoStream(path);
            //WriteAllLines();
            //BinaryOperations.BinarySerialization();
            //BinaryOperations.BinaryDeSerialization();
            //JsonIOOperations.JsonSerialize();
            //JsonIOOperations.JsonDeSerialize();
            //XmlOperation.XmlSerialize();
            XmlOperation.XmlDeSerialize();
            Console.ReadLine();
        }
        /// <summary>
        /// Checking wether the file exists or not
        /// </summary>
        public static bool FileExists()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
                if (File.Exists(path))
                {
                    Console.WriteLine("File exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("File not exists");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Read all data line by line
        /// </summary>
        public static void ReadAllLines()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
               if(FileExists())
               {
                  string[] result = File.ReadAllLines(path);
                    foreach(string line in result)
                    {
                        Console.WriteLine(path);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Read all data line by line
        /// </summary>
        public static void WriteAllLines()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
                if (FileExists())
                {
                    string content = "Adding extra information";
                    File.WriteAllText(path, content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Read all data line by line at once
        /// </summary>
        public static void ReadAtOnce()
        {
            try
            {
                string path = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
                if (FileExists())
                {
                    string result = File.ReadAllText(path);
                    Console.WriteLine(result);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        /// <summary>
        /// Copy of the existing file
        /// </summary>
        public static void CopyFile()
        {
            try
            {
                string source = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
                string destination= @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Target.txt";

                if (FileExists())
                {
                     File.Copy(source, destination);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Delete an existing file
        /// </summary>
        public static void DeleteFile()
        {
            try
            {
               //string source = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Sample.txt";
                string destination = @"C:\Users\mahesh\source\repos\FileIODemo\FileIODemo\Target.txt";

                if (FileExists())
                {
                    File.Delete( destination);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Stream reader for reading file
        /// </summary>
        /// <param name="path"></param>
        public static void ReadingDataFromStream(string path)
        {
            try
            { 
                if (FileExists())
                {
                    string line = "";
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                //Sr.close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void WriteDataIntoStream(string path)
        {
            try
            {
                if (FileExists())
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("testing append operation ");
                   }
                }
                //Sr.close();
                ReadingDataFromStream(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    
}

