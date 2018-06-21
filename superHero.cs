using System;
using System.Collections.Generic;
using System.Text;

namespace heroStory
{
    public class superHero : superHuman
    {
        public string _fight;
        public string _location;
        

        public superHero(string name, int healthPoints, int hitPoints, string fight, string location) : base(name, hitPoints, healthPoints)
        {
            _name = name;
            _hitPoints = hitPoints;
            _healthPoints = healthPoints;
            _fight = fight;
            _location = location;
           
        }

     

       
       
    }
}
