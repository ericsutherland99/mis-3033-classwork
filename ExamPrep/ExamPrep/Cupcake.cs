using System;
using System.Collections.Generic;
using System.Text;

namespace ExamPrep
{
    public class Cupcake
    {
        public string month { get; set; }
        public int cupcake { get; set; }

        public int intcupcake { get; set; }
        public Cupcake()
        {
            month = string.Empty;
            cupcake = 0;
            intcupcake = 0;
        }

        public Cupcake(string line)
        {
            var pieces = line.Split(",");
            month = pieces[0];
            cupcake = Convert.ToInt32(pieces[1]);
        }
        public override string ToString()
        {
            return $"{month}";
        }
    }
}
