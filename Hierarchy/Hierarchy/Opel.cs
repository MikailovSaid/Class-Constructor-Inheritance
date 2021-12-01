using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    internal class Opel 
    {
        string model = "Astra";
        string color = "White";
        int year = 2005;

        public string FullDataOpel()
        {
            return $"{color} {model} {year}";
        }
    }
}
