using Lab_Task___01.Problem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task___01
{
    internal class main
    {
        public static void Main(string[] args)
        {
            one oneObj = new one();
            Console.WriteLine(oneObj.total(10, 20));
            // oneObj.myInfo();    // can't access



            two objTwo = new two();
            objTwo.callProtected();

        }
    }
}
