using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.Array
{
    class LearnList
    {
        public void ListLession()
        {
            var list = new List<int>() { 1, 4, 7, 3, 10 };
            list.Add(10);
            list.AddRange(new int[3] { 6, 5, 9 });


            Console.WriteLine("List indeox of" + list.IndexOf(10));
            Console.WriteLine("Last index of" + list.LastIndexOf(10));

            list.Clear();

            Console.WriteLine(list.Count());
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

        }
    }
}
