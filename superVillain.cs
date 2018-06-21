using System;
using System.Collections.Generic;
using System.Text;

namespace heroStory
{
    public class superVillain : superHuman
    {
        public string _mood;
        public int _strength;

        public superVillain(string name, int healthPoints, int hitpoints, string mood, int strength) : base(name, hitpoints, healthPoints)
        {
            _name = name;
            _hitPoints = hitpoints;
            _healthPoints = healthPoints;
            _mood = mood;
            _strength = strength;

        }

       

        

    }
}
