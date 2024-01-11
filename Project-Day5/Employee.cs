using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day5
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public DateOnly Dob { get; set; }
    }
}
