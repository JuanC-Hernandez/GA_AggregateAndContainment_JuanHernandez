using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Character
    {
        // Fields
        string _name;
        int _weight;

        // Constructors
        public Character(int weight, string name)
        {
            _weight = weight; 
            _name = name;     
        }

        // Properties
        public int Weight { get => _weight; set => _weight = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
