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
        IPlayer user = new Player();
        IPlayer bot = new NPC();

        public GameController(IPlayer user, IPlayer bot)
        {
            this.user = user;
            this.bot = bot;

        }
        public void Battle()
        {
            user.SetBlock((Parts)user.Set);
            user.GetHit((Parts)rand.Next(0, 3));
            bot.SetBlock((Parts)rand.Next(0, 3));
            bot.GetHit((Parts)user.Hit);
        }
    }
}
