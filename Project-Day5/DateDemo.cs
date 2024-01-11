using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day5
{
    internal class DateDemo
    {
        static void Main()
        {   
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);

            Console.WriteLine(dt2.ToString("MMMM dd"));
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(DateTime.Now.ToString("MMM dd"));
            if (currentDate.ToString("MMM dd") == "Jan 11")
                Console.WriteLine("There is special discount");
            else Console.WriteLine("No disc");



        }
    }
}
