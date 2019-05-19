using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Unit
    {
        public string CommonName { get; set; }

        public string ShortName { get; set; }

        public List<string> AlternativeNames { get; set; }

        public double Multiplier { get; set; }
        public Unit MainUnit { get; set; }

        public override string ToString()
        {
            return ShortName;
        }

       
    }
}
