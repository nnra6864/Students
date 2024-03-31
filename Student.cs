using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string name;
        public string lastName;
        public int index;
        public DateTime date;
        public string direction;

        public override string ToString()
        {
            return $"{"Name: " + name + "    "} {"Last Name: " + lastName + "    "} {"Index: " + index + "    "} {"Direction: " + direction + "    "} {"Date: " + date + "    "}";
        }
    }
}
