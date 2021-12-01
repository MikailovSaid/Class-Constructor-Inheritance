using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Bmw:Cars
    {
        string model = "M5";
        string color = "Gray";
        int year = 2018;
        public string FullDataBmw()
        {
            return $"{color} {model} {year}";
        }
    }
}
