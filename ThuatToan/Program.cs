using System;
using ThuatToan.LearnClass;
using ThuatToan.Array;
using ThuatToan.LearnDateTime;
using ThuatToan.LearnString;
using System.Text;

namespace ThuatToan
{
    public static class Program
    {
        


        static void Main(string[] args)
        {
            //// input array from random 
            //int[] numbers = new int[10];

            //Random rnd = new Random();         

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next(1, 10);
            //}

            //var result = String.Join(", ", numbers);
            //Console.WriteLine(result);

            //// Quick Sort!
            //Console.WriteLine("Start Quick Sort!");

            //var sorting = new Sorting();
            //sorting.QuickSort(numbers, 0, numbers.Length - 1);

            //result = String.Join(", ", numbers);
            //Console.WriteLine(result);

            //Console.WriteLine("\t\t ------> total milisecond QuickSort  \t" );

            //// Search Linear
            //var search = new Search();
            //var searchItem = 6;
            //int searchResult = search.SearchLinear(numbers, searchItem);
            //Console.WriteLine($"Index of {searchItem} is       {searchResult}");

            //// Search Linear Improve;
            //search.SearchLinearImporve(numbers, searchItem);

            //// SearchBinary
            //Console.WriteLine("\nStart SearchBinary!!");
            //var startTime = DateTime.UtcNow;

            //var r = search.SearchBinary(numbers, searchItem);
            //Console.WriteLine("---------------SearchBinary result ---------is:   " + r);

            //var endTime = DateTime.UtcNow;
            //var time = (endTime - startTime).TotalMilliseconds;
            //Console.WriteLine("\t\t ------> total milisecond SearchBinary  \t" + time);


            //// LearnDateTime
            //var exercise = new ClassDateTime();

            //Console.WriteLine("\n DateTime: ");
            //exercise.FuncExerciseDateTime();

            //Console.WriteLine("\n TimeSpan: ");
            //exercise.FuncExerciseTimeSpan();

            //// Learn String
            //var str = new StringCustom();
            //str.StringExamples();

            // Summarize text
            string text = "This is a very wonderful life for everyone. Thanks for all that we have";
            string newText = StringCustom.SummarizeText(text, 15);
            Console.WriteLine(newText);


            var builder = new StringBuilder("Hello word!");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(15, 10)
                .Insert(0, "This is");

            Console.WriteLine(builder);
        }


    }
}
