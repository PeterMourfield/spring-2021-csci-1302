using System;
using System.Text;

namespace csci_1302
{
    public class StringTests
    {
        public static void Run()
        {
            //DoCharacters();
            //DoStrings();
            //DoStringBuilder();
            ParseStrings();
        }

        public static void ParseStrings()
        {
            string inputString = "1,Stan Smith,,400-00-1234";
            string[] inputData = inputString.Split(',');

            try
            {
                int customerId = int.Parse(inputData[0]);
                string customerName = inputData[1];
                DateTime birthDate = DateTime.Parse(inputData[2]);
                string ssn = inputData[3];
            }
            catch(System.FormatException ex)
            {
                // log exception to file
                // flag the records that are bad
            }
        }

        public static void DoStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Line 1 Data");
            stringBuilder.AppendLine("Line 2 Data");
            stringBuilder.AppendLine("Line 3 Data");

            float f1 = 123.456F;
            stringBuilder.AppendFormat("Price: {0:C2}", f1);
            stringBuilder.AppendLine();

            stringBuilder.Append("item1");
            stringBuilder.Append("item2");
            stringBuilder.Append("item3");

            string output = stringBuilder.ToString();
        }

        public static void DoStrings()
        {
            string s1 = "The quick ";
            string s2 = "brown fox";
            string s3 = s1.Trim();
            string s44 = s3.Trim();

            float d1 = 123.456F;
            //Console.WriteLine(string.Format("{0}", d1));
            //Console.WriteLine("{0}", d1);
            //Console.Write($"{d1:C2}");

            string str1 = "Applicant Name: Harry Potter";
            int pos = str1.IndexOf("Name:");
            string name = str1.Substring(pos + "Name:".Length);
            name = name.Trim();
            char ch1 = name[3];

            string someInput = "1 2 3.3 4 17846";
            string[] inputs = someInput.Split();

            string s4 = "alice", s5 = "Alice";
            bool b1 = (s4 == s5);
            bool b2 = s4.Equals(s5, StringComparison.OrdinalIgnoreCase);

            string s6 = "The quick brown fox jumps over the lazy dog";
            string s7 = "FOX";
            bool b3 = s6.ToLower().Contains(s7.ToLower());
        }

        public static void DoCharacters()
        {
            //char ch = '9';
            //int x = ch = '0';
            char ch = 'A';
            char ch2 = 'Y';

            bool b1 = Char.IsDigit(ch);
            bool b2 = Char.IsLetter(ch);
            bool b3 = Char.IsUpper(ch);
            bool b4 = Char.IsPunctuation(ch);
            bool b5 = Char.IsSymbol(ch);
            bool b6 = Char.IsSurrogate(ch);

            bool b7 = (ch == ch2);
            bool b8 = ch.Equals(ch2);

            int i1 = ch.CompareTo(ch2);
        }
    }
}
