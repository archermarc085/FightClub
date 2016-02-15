using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class GameController
    {
        Random rand = new Random();
        Player user = new Player();
        NPC comp = new NPC();
        public int Hit { get; set; }
        public int Set { get; set; }

        public GameController(Player user, NPC comp)
        {
            this.user = user;
            this.comp = comp;
            user.SetBlock((Parts)user.Set);
            user.GetHit((Parts)rand.Next(0, 3));
            comp.SetBlock((Parts)rand.Next(0, 3));
            comp.GetHit((Parts)user.Hit);
        }
    }
}
