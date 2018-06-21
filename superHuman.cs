using System;
using System.Collections.Generic;
using System.Text;

namespace heroStory
{
    public class superHuman
    {
        public string _name;
        public int _healthPoints = 100;
        public int _hitPoints = 50;
      

        public superHuman(string name, int healthPoints, int hitPoints) 
        {
            _name = name;
            _healthPoints = healthPoints;
            _hitPoints = hitPoints;
        }

       

    }
}
