using System;
using System.IO;
using System.Text;

namespace csci_1302
{
    public class FileTests
    {
        public static void Run()
        {
            // WriteFiles();
            ReadFiles();
        }

        static void ReadFiles()
        {
        }

        static void WriteFiles()
        {
            //string currentDirectory = Directory.GetCurrentDirectory();
            //string newDirectory = Path.Combine(currentDirectory, "../");
            //string[] files = Directory.GetFiles(newDirectory);

            //foreach(string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            string fileName = "test.txt";
            if (!File.Exists(fileName))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("First line - StringBUilder");
                sb.AppendLine("Last line - StringBuilfder");

                // write to files
                StreamWriter writer = new StreamWriter(fileName);
                try
                {
                    writer.Write(sb);
                    //writer.WriteLine("First Line");
                    //writer.WriteLine("The date/time is {0}", DateTime.Now);
                    //writer.WriteLine("Last Line");
                }
                catch (Exception ex)
                {
                    // handle the error
                }
                finally
                {
                    writer.Close();
                }
            }
            else
            {
                File.Delete(fileName);
            }
        }
    }
}