using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    enum Parts { Head, Body, Legs }
    public delegate void GameForceHandler(object sender, GameEventArgs e);
    interface IPlayer
    {
        int Damage { get; set; }
        int HP { get; set; }
        string Name { get; set; }
        int GetHit(Parts part);
        int SetBlock(Parts part);
        event GameForceHandler Wound;
        event GameForceHandler Block;
        event GameForceHandler Death;
    }
}
