using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Suspension
    {
        // Fields
        float _frontBalance; 
        float _springyNess;  
        float _rearBalance;  

        
        public Suspension(float frontBalance, float springyNess, float rearBalance) // Constructor take 3 fields
        {
            _frontBalance = frontBalance; 
            _springyNess = springyNess;   
            _rearBalance = rearBalance;   
        }

        
        public float FrontBalance // Properties
        {
            get => _frontBalance; 

            
            set
            {
                if (value >= -1 && value <= 1)
                {
                    _frontBalance = value;
                }
            }
        }

        // Properties
        public float SpringyNess { get => _springyNess; set => _springyNess = value; }
        public float RearBalance { get => _rearBalance; set => _rearBalance = value; }
    }
}
