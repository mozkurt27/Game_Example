using Game_Example.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Example.Models
{
    abstract class Character
    {
        private int _health;
        private int _power;
        private int _point;
        internal event HitHandler OnDeath;

        public void Demage(int D_Health)
        {
            Health -= D_Health;
        }

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                if (_health <= 0) OnDeath();
            }
        }


        public int Power { get { return _power; } set { _power = value; } }

        public int Point { get { return _point; } set { _point = value; } }
    }
}
