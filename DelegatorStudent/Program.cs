using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("a", 4.5));
        }
    }
}
