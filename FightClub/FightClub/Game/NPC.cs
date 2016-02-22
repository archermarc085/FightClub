using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    class NPC:AbstractPlayer
    {
        public override int GetHit(Parts part)
        {
            if ((int)part != block)
            {
                if (hp - damage > 0)
                {
                    hp -= damage;
                    if (Wound != null)
                        Wound(this, new GameEventArgs("wounded Bot"));
                }
                else 
                {
                    hp = 0;
                    if (Death != null)
                        Death(this, new GameEventArgs("Bot Died"));
                }
            }
            if (block == (int)part)
            {
                if (Block != null)
                    Block(this, new GameEventArgs("Bot Blocked"));
            }
            return hp;
        }

        public override event GameForceHandler Wound;
        public override event GameForceHandler Block;
        public override event GameForceHandler Death;
    }
}
