using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"Id:{Id},Fullname:{Fullname},Point:{Point}");
        }
    }
}
