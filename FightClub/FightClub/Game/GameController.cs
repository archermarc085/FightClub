using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bot.Hit = rand.Next(1, 4);
            user.GetHit((Parts)bot.Hit);
            bot.SetBlock((Parts)rand.Next(1, 4));
            bot.GetHit((Parts)user.Hit);
        }
    }
}
