using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.Array
{
    class Search
    {
        // Search Linear: Start
        public int SearchLinear (int[] numbers, int searchItem)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchItem)
                {
                   
                    return i;
                }
            }

            return -1;
                       
        }

        // Search Linear Improve: Start
        public void SearchLinearImporve (int[] numbers, int searchItem)
        {

            Console.WriteLine("Start SearchLinearImporve!!");
            var startTime = DateTime.UtcNow;

            var left = 0;
            var right = numbers.Length - 1;
            var position = -1;

            while (left <= right)
            {
                if (numbers[left] == searchItem)
                {
                    position = left;
                    break;
                }

                if (numbers[right] == searchItem)
                {
                    position = right;
                    break;
                }

                left++;
                right--;
            }

            if (position == -1)
            {
                Console.WriteLine("\nCannot find value " + searchItem + " in this array");

            } else
            {
                Console.WriteLine("\nThe index of " + searchItem + " is          " + position);
            }

            var endTime = DateTime.UtcNow;
            var time = (endTime - startTime).TotalMilliseconds;            
            Console.WriteLine("\t\t ------> total milisecond SearchLinearImporve  \t" + time);
        }

        // Search Binary Start for sorted Array
        public int SearchBinary (int[] numbers, int searchItem)

        {
            var left = 0;
            var right = numbers.Length - 1;
            
            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (searchItem == numbers[middle])
                {
                    return middle;

                } else if (searchItem < numbers[middle])
                {
                    right = middle - 1;

                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
                        
        }
        
    }
}
