using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class AbstractPlayer : IPlayer
    {
        const int bonusHp = 25;
        Random rand = new Random();     
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
        
        public int SetBlock(Parts part) 
        {
            block = (int)part;
            return block;
        }
        public int BonusHp()
        {
            hp = hp + bonusHp;
            return hp;
        }
        public  void ImproveDmg()
        {
            damage = rand.Next(5,13);
        }
        public int Recovery(bool h)
        {
            if (h) 
            {
                hp = 100;
                return hp;
            }

            hp = 125;
            return hp;
        }
        abstract public int GetHit(Parts part);
        abstract public event GameForceHandler Wound;
        abstract public event GameForceHandler Block;
        abstract public event GameForceHandler Death;
    }
}
