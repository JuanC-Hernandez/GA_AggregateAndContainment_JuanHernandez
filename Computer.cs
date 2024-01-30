using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Computer
    {
        // Fields
        string _cpu;            
        string _mother;         
        GraphicsCard _graphicsCard; 

        // Constructors
        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard; 
        }
    }
}
