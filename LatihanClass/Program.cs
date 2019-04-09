using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Time ObjTime = new Time(2000, 05, 13, 10, 10, 10);
            Hasil(ObjTime);
            Console.ReadKey();

        }

        static void Hasil(Time ObjTime)
        {
            Console.WriteLine("Year : {0}", ObjTime.Year.ToString());
            Console.WriteLine("Month : {0}", ObjTime.Month.ToString());
            Console.WriteLine("Date : {0}", ObjTime.Date);
            Console.WriteLine("Hour : {0}", ObjTime.Hour);
            Console.WriteLine("Minute : {0}", ObjTime.Minute);
            Console.WriteLine("Second : {0}", ObjTime.Second);
        }
    }
}
