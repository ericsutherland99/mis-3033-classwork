using System;
using System.Collections.Generic;
using System.Text;

namespace newexample
{
    class noodledate
    {
        public string Month { get; set; }
        public string Pho { get; set; }
        public string Ramen { get; set; }
        public string Soba { get; set; }

        public noodledate()
        {
            Month = string.Empty;
            Pho = string.Empty;
            Ramen = string.Empty;
            Soba = string.Empty;
        }

        public noodledate(string line)
        {
            var pieces = line.Split(",");
            Month = pieces[0];
            Pho = pieces[1];
            Ramen = pieces[2];
            Soba = pieces[3];
        }

        public override string ToString()
        {
            return $"in {Month} Pho was {Pho}, Ramen was {Ramen}, Soba was {Soba}";
        }
    }

    
}
