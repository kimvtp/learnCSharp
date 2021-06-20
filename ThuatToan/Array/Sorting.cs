using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.Array
{
    public class Sorting
    {
        public int[] SortCombine(int[] numbers)
        {
            Console.WriteLine("Start SortCombine!!");

            var startTime = DateTime.UtcNow;

            var maxIndex = numbers.Length - 1;

            for (int i = 0, x = maxIndex; i <= x; i++, x--)
            {
                int minValue = numbers[i];
                int minPosition = i;
                int maxValue = numbers[maxIndex - i];
                int maxPosition = x;
                for (int j = i + 1; j <= maxIndex; j++)
                {
                    if (minValue > numbers[j])
                    {
                        minValue = numbers[j];
                        minPosition = j;

                    }

                    if (maxValue < numbers[maxIndex - j])
                    {
                        maxValue = numbers[maxIndex - j];
                        maxPosition = maxIndex - j;
                    }
                }
                numbers[minPosition] = numbers[i];
                numbers[i] = minValue;
                if (maxPosition != i)
                {
                    numbers[maxPosition] = numbers[maxIndex - i];
                    numbers[maxIndex] = maxValue;
                }
                else
                {
                    numbers[minPosition] = numbers[maxIndex - i];
                    numbers[maxIndex] = maxValue;
                }



            }



            var endTime = DateTime.UtcNow;

            var time = (endTime - startTime).TotalMilliseconds;

            var result = String.Join(", ", numbers);
            Console.WriteLine(result);

            Console.WriteLine("\t\t ------> total milisecond SortCombine  \t" + time);

            return numbers;
        }
        /*  public int[] SortSelection(int[] numbers)
          {
              Console.WriteLine("Start SortSelection!!");

              var startTime = DateTime.UtcNow;
              var n = numbers.Length;
              for (int i = 0; i < n; i++)
              {
                  int minNumber = numbers[i];
                  int minPosition = i;
                  for (int j = i + 1; j < n; j++)

                  {
                      if (minNumber > numbers[j])
                      {
                          minNumber = numbers[j];
                          minPosition = j;
                      }
                  }

                  numbers[minPosition] = numbers[i];
                  numbers[i] = minNumber;

              }

              var endTime = DateTime.UtcNow;

              var time = (endTime - startTime).TotalMilliseconds;

              //    result = String.Join(", ", numbers);
              //  Console.WriteLine(result);
              var result = String.Join(", ", numbers);
              Console.WriteLine(result);
              Console.WriteLine("\t\t ------> total milisecond SortSelection  \t" + time);

              return numbers;
          } */

        public int[] SortBubble(int[] numbers)
        {
            Console.WriteLine("Start SortBubble!!");

            var startTime = DateTime.UtcNow;

            try
            {
                int maxIndex = numbers.Length - 1;

                int i;
                int j;

                for (i = 0; i <= maxIndex; i++)
                {

                    for (j = maxIndex; j > i; j--)
                    {
                        if (numbers[j] > numbers[j - 1])
                        {
                            int small = numbers[j];
                            int big = numbers[j - 1];

                            numbers[j] = big;
                            numbers[j - 1] = small;
                        }
                    }
                }



            }
            catch (Exception)
            {

                Console.WriteLine("something wrong!");
                throw;
            }


            var endTime = DateTime.UtcNow;

            var time = (endTime - startTime).TotalMilliseconds;

            var result = String.Join(", ", numbers);
            Console.WriteLine(result);

            Console.WriteLine("\t\t ------> total milisecond SortBubble  \t" + time);

            return numbers;
        }


        public void QuickSort(int[] numbers, int low, int high)
        {



            if (low < high)
            {
                var pointer = Partition(numbers, low, high);
                
                QuickSort(numbers, low, pointer - 1);
                                
                QuickSort(numbers, pointer + 1, high);
                              

            }

            



        }
        public int Partition(int[] numbers, int low, int high)
        {
            int pointer = low - 1;
            int pivot = numbers[high];
            for (int i = low; i < high ; i++)
            {
                
                try
                {


                    if (numbers[i] < pivot)
                    {
                       
                        pointer++;                       
                        int temp = numbers[i];
                        numbers[i] = numbers[pointer];
                        numbers[pointer] = temp;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());

                }
            
            }

            int swap = numbers[high];
            numbers[high] = numbers[pointer + 1];
            numbers[pointer + 1] = swap;

            return pointer + 1;
        }

    }
}

