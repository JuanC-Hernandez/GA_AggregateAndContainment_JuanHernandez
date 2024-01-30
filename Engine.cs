using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Engine
    {
        int _hp; // Private field

       
        public Engine(int hp) // Constructor
        {
            _hp = hp; 
        }

        
        public int Hp // property
        {
            get => _hp; 

            set
            {
                if (value >= 50)
                {
                    _hp = value; 
                }
                else
                {
                    //throw new Exception("Please enter a valid Horse Power"); // Throws an exception for invalid horsepower values
                    Console.WriteLine("Please enter a valid Horse Power"); // I want to see this something
                }
            }
        }
    }
}
