using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Car
    {
        // Fields
        string _make;
        string _model;
        Engine _engine;
        Suspension _suspension;

        // Constructors
        public Car(string make, string model, Engine engine, Suspension suspension = null)
        {
            _make = make;
            _model = model;
            _engine = engine;
            _suspension = suspension;
        }

        // Methods
        public void SwapEngine(Engine engine)
        {
            if (engine != null)
            {
                _engine = engine; 
            }
        }

        
        public void SwapEngine(int hp)
        {
            _engine = new Engine(hp); 
        }

        // Override the ToString 
        public override string ToString()
        {
            
            return $"{_make} {_model} : {_engine.Hp} :\n" +
                $"Suspension: Front Balance {_suspension.FrontBalance}\n" +
                $"Rear Balance: {_suspension.RearBalance}\n" +
                $"Springyness: {_suspension.SpringyNess}";
        }
    }
}
