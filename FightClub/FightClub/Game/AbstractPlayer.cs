using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class AbstractPlayer : IPlayer,ISave
    {
        protected int hp = 100;
        protected int damage = 5;
        protected int block = 0;
        public string Name { get; set; }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
         public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
            }
        }
        public int Hit { get; set; }
        public int Set { get { return (int)block; } }
        public string log { get; set; }
        public int Win { get; set; }
        abstract public int GetHit(Parts part);
        public void Recovery()
        {
            hp = 100;
        }
        public int SetBlock(Parts part) 
        {
            block = (int)part;
            return block;
        }
        abstract public event GameForceHandler Wound;
        abstract public event GameForceHandler Block;
        abstract public event GameForceHandler Death;
    }
}
