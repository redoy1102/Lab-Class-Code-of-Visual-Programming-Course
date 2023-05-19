//1.Write a program using all 6 access modifiers to show the access level of those modifiers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task___01.Problems
{
    internal class one
    {
        public int total(int i, int j)
        {
            myInfo();
            return i + j;
        }
        private void myInfo()
        {
            string name = "Fuad";
            int id = 20103046;
            Console.WriteLine(name + id);
        }

        protected void examplePro()
        {
            Console.WriteLine("I am exampleProtected function.");
        }
        
    }
}
