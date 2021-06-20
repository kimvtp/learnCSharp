using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.LearnString
{
    class StringCustom
    {
        public void StringExamples ()
        {
            var fullName  = "Mosh Halen ";
            Console.WriteLine("fullName.Trim()  " + fullName.Trim());
            Console.WriteLine("fullName.ToUpper()  " + fullName.ToUpper());
            string[] name = fullName.Split(' ');
            Console.WriteLine("\nfirstName  " + name[0]);
            Console.WriteLine("LastName  " + name[1]);

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("\n firstName  " + firstName);
            Console.WriteLine("LastName  " + lastName);


            Console.WriteLine("\n fullName.Replace()  " + fullName.Replace("Mosh", "Kime"));
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var string2 = "25";
            int number = Convert.ToInt32(string2);
            Console.WriteLine("Convert.ToInt32(string2); " + number);

            float i = 29.6f;
            Console.WriteLine("i.ToString()   " + i.ToString());
            Console.WriteLine("i.ToString()   " + i.ToString("C0"));
            

        }

        public static string SummarizeText(string text, int Maxleng = 20)
        {
            if (text.Length <= Maxleng)
            {
                return text;
            }

            var words = text.Split(' ');
            var newText = new List<string>();
            var len = 0;            

            foreach ( var item in words)
            {
                
                len += item.Length;
                if (len > Maxleng)
                {
                    break;
                }

                len++;

                newText.Add(item);
            }

            return String.Join(" ", newText) + "...";
         }
    }
}
