using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IView
    {
        string PlayerName { get; set; }
        int PlayerHp { get; set; }
        string BotName { set; }
        int BotHp { get; set; }
        string BotDamage { get; set; }
        string PlayerDamage { get; set; }
        Level difficulty { get; set; }
        event GameForceHandler Battle;
    }
}
