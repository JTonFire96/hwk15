using System;
using System.Collections.Generic;
using System.Text;

namespace hwk15
{
    class panda :bear
    {
        public string _country { get; set; }

        public panda(string name, int strength, string color, string country) : base(name,  strength, color)
        {
            _name = name;
            _strength = strength;
            _color = color;
            _country = country;
        }
    }
}
