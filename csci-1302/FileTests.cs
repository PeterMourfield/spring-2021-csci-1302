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
            string fileName = "test-file.txt";

            StreamReader streamReader = new StreamReader(fileName);
            string inputLine = streamReader.ReadLine();
            while(inputLine != null)
            {
                string[] values = inputLine.Split(',');
                try
                {
                    int index = int.Parse(values[0]);
                    string name = values[1];
                    // do some work
                }
                catch(Exception ex)
                {

                }

                inputLine = streamReader.ReadLine();
            }
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
                sb.AppendLine("First line - StringBuilder");
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