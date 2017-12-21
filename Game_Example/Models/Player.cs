using Game_Example.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Example.Models
{
    
    class Player : Character
    {
        
        private string _username;
        
        public string UserName { get { return _username; } }

        public void CreatePlayer(string name,bool choice)
        {
            _username = name;

            if (choice)
            {
                Warrior w = new Warrior();
                Power = w.Power;
                Health = w.Health; 
            }
            else
            {
                Mage m = new Mage();
                Power = m.Power;
                Health = m.Health;
            }


        }
    }
}
