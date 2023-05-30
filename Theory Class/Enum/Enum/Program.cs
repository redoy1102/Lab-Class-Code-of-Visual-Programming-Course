using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;



namespace Enum
{
    
    internal class Program:enumWithSwitch
    {
        enum weekDays
        {
            Sunday = 1,
            Monday,
            Tuesday = 'F'
        }
        static void Main(string[] args)
        {
            //Printing the enums
            weekDays w = weekDays.Sunday;
            Console.WriteLine(w);

            //Printing the index numbers
            int a = (int)weekDays.Sunday;
            int b = (int)weekDays.Monday;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //printing character values
            char c = (char)weekDays.Tuesday;
            Console.WriteLine(c);

            //enum with switch
            monthName mn = monthName.January;
            switch (mn)
            {
                case monthName.January:
                    Console.WriteLine("January");
                    break;
                case monthName.February:
                    Console.WriteLine("February");
                    break;
            }
                

        }
    }
}
