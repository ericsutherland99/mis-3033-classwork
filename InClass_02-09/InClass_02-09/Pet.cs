using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_02_09
{

    public class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Picture { get; set; }

        public Pet()
        {
            Name = string.Empty;
            Breed = string.Empty;
            Picture = string.Empty;
        }

        public override string ToString()
        {
            return $"{Name} ({Breed})";
        }
    }
}
