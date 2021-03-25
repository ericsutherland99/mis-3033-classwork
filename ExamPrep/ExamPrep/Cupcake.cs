using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrep
{
    public class Cupcake
    {
        public string month { get; set; }
        public string cupcake { get; set; }

        public int intcupcake { get; set; }
        public Cupcake()
        {
            month = string.Empty;
            cupcake = string.Empty;
            intcupcake = 0;
        }

        public Cupcake(string line)
        {
            var pieces = line.Split(",");
            month = pieces[0];
            cupcake = pieces[1];
        }
        public override string ToString()
        {
            return $"{month}";
        }
    }
}
