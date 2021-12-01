using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    internal class Ford 
    {
        string model = "Mustang";
        string color = "Red";
        int year = 1969;

        public string FullDataFord()
        {
            return $"{color} {model} {year}";
        }
    }
}
