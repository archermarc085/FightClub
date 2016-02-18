using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface ISave
    {
        string Name { get; set; }
        int HP { get; set; }
        int Damage { get; set; }
        int Win { get; set; }
    }
}
