using System;
using System.Collections.Generic;
using System.Text;

namespace hwk15
{
    class bear
    {
        public int _strength { get; set; }
        public string _color { get; set; }
        public string _name { get; set; }

        public bear(string name, int strength, string color)
        {
            _name = name;
            _strength = strength;
            _color = color;
        }
    }
}

