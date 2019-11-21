using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes;
            int hours;
            int entry;

            ("Please enter the number of minutes worked. >>>");
            entry = Convert.ToInt32(Console.ReadLine());

            //math
            hours = entry / 60;
            minutes = entry % 60;

            Console.WriteLine("{0} entered = {1} and {2} left over", entry, hours, minutes);






        }
    }
}
