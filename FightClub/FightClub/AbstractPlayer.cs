using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
   abstract class AbstractPlayer:IPlayer
    {
        public string Name { get; set; }
        abstract public int Damage { get; set; }
        abstract public int HP { get; set; }
        abstract public int GetHit(Parts part);
        abstract public int SetBlock(Parts part);
        abstract public event GameForceHandler Wound;
        abstract public event GameForceHandler Block;
        abstract public event GameForceHandler Death;
    }
}
