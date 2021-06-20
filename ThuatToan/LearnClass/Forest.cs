using System;

namespace ThuatToan.LearnClass
{
    public class Forest
    {

        // Field
        public string Name { get; set; }
        public int Age { get; set; }

        public static int Count { get; set; }


        // Construction
        public Forest (string name, int age)
        {
            Name = name;
            Age = Age;
            Count++;
        }

      
        static Forest()
        {
           
            Console.WriteLine("Test");
        }

        //Method

        public void PrintCount()
        {
            Console.WriteLine("Count: " + Count);
        }


        // Properties



    }
}
