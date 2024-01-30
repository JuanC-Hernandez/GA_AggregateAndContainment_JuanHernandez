using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class GoKart
    {
        // Fields
        Engine _engine;          
        Character _playerCharacter; 

        public GoKart(Character playerCharacter) // Constructor
        {
            _playerCharacter = playerCharacter; 
            _engine = new Engine(250 - (playerCharacter.Weight / 4));
        }

        internal Engine Engine1 // Property
        {
            get => _engine;
        }

        public void TweakEngine(int newHp) // Methods
        {
            _engine.Hp = newHp; 
        }

        public override string ToString() // Override the ToString 
        {
            return $"Character {_playerCharacter.Name} - Weight: {_playerCharacter.Weight} : Engine Hp {_engine.Hp} ";
        }
    }
}
