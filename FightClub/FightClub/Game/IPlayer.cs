using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    enum Parts { Head = 1, Body, Legs }
    public delegate void GameForceHandler(object sender, GameEventArgs e);
    interface IPlayer
    {
        int HP { get; set; }
        string log { get; set; }
        int Damage { get; set; }
        string Name { get; set; }
        int Hit { get; set; }
        int Set { get; }
        int GetHit(Parts part);
        int SetBlock(Parts part);
        event GameForceHandler Wound;
        event GameForceHandler Block;
        event GameForceHandler Death;
    }
}
