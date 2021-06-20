using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan.LearnDateTime
{
    public class ClassDateTime
    {
        public void FuncExerciseDateTime()
        {
            DateTime dt = new DateTime();
            Console.WriteLine("new DateTime();    " + dt);

            DateTime dt2 = new DateTime(2021, 6, 20);
            Console.WriteLine("new DateTime(2021, 6, 20);       " + dt2);

            DateTime dt3 = new DateTime(2021, 6, 20, 11, 26, 30);
            Console.WriteLine("new DateTime(2021, 6, 20, 11, 26, 30);   " + dt3);

            DateTime dt4 = new DateTime(2021, 6, 20, 11, 26, 30, DateTimeKind.Local);
            Console.WriteLine(dt4);

            var start = DateTime.Now;
            Console.WriteLine("var start = DateTime.Now;     " + start);
            Console.WriteLine("now.Hour--------" + start.Hour);
            Console.WriteLine("now.AddDays--------" + start.AddDays(-2));
            
            Console.WriteLine("\nnow.ToLongDateString()  " + start.ToLongDateString());
            Console.WriteLine("now.ToShortDateString()  " + start.ToShortDateString());
            Console.WriteLine("now.ToLongTimeString()  " + start.ToLongTimeString());
            Console.WriteLine("now.ToShortTimeString()  " + start.ToShortTimeString());
            Console.WriteLine("now.ToString()  " + start.ToString("yyyy-mm-dd hh:mm" ));
            Console.WriteLine("now.ToString(\"yyyy - mm - dd hh: mm\")  " + start.ToString("yyyy-mm-dd hh:mm"));
            Console.WriteLine("DateTime.Now.Year  " + DateTime.Now.Year);

            var end = DateTime.Now.AddHours(1);
            Console.WriteLine("\n var end = DateTime.Now.AddHours(1);     " + end);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
        }

        public void FuncExerciseTimeSpan()
        {
            var timeSpan1 = new TimeSpan(10, 30, 15);  // result:  10:30:15
            Console.WriteLine("var timeSpan1 = new TimeSpan(10, 30, 15):   " + timeSpan1);
            Console.WriteLine("timeSpan1.Minutes: " + timeSpan1.Minutes); // 30
            Console.WriteLine("timeSpan1.TotalMinutes: " + timeSpan1.TotalMinutes); // 630.25
            Console.WriteLine("timeSpan1.Add(TimeSpan.FromMinutes(5): " + timeSpan1.Add(TimeSpan.FromMinutes(5))); //  10:35:15
            Console.WriteLine("timeSpan1.Subtract(TimeSpan.FromMinutes(15): " + timeSpan1.Subtract(TimeSpan.FromMinutes(15))); //  10:15:15
            Console.WriteLine("timeSpan1.ToString: " + timeSpan1.ToString()); //  10:30:15
            Console.WriteLine("timeSpan1.Parse: " + TimeSpan.Parse("05:30:01")); //  
            
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("TimeSpan.FromHours(1): " + timeSpan2); // 01:00:00
            
        }
        
    }
}
