using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class GraphicsCard
    {
        public enum Brand { Nvidia, AMD, Intel } 

        Brand _graphicsCardBrand; // Private field

        public GraphicsCard(Brand graphicsCardBrand) // Constructor
        {
            _graphicsCardBrand = graphicsCardBrand; 
        }
    }
}
