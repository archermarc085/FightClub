﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Player:AbstractPlayer,ISave
    {
        int hp = 100;
        int damage = 5;
        int block = 0;
        public override int Damage
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
        public override int HP
        {
            get { return hp; }
            set
            {
                hp = value; 
            }
        }
        public override int GetHit(Parts part)
        {
            if ((int)part != block)
            {
                if (hp - damage > 0)
                {
                    hp -= damage;
                    if (Wound != null)
                        Wound(this, new GameEventArgs("Bot wounded"));
                }
                else
                {
                    hp = 0;
                    if (Death != null)
                        Death(this, new GameEventArgs("Died"));
                }
            }
            if (block == (int)part)
            {
                if (Block != null)
                    Block(this, new GameEventArgs("Blocked"));
            }
            return hp;
        }

        public override int SetBlock(Parts part)
        {
            block = (int)part;
            return block;
        }


        public override event GameForceHandler Wound;

        public override event GameForceHandler Block;

        public override event GameForceHandler Death;
    }
}
