﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
   interface ILvl 
    {
        void Difficulty();
    }
   class Presenter : ILvl
   {
       IView view;
       IPlayer player;
       IPlayer npc;
       GameController controller;

       public Presenter(IView view, IPlayer player, IPlayer npc)
       {
           this.player = player;
           this.npc = npc;
           this.view = view;
           controller = new GameController(player, npc);

           player.Name = view.PlayerName;
           view.PlayerHp = player.HP;
           npc.Name = "Bot";
           view.BotName = npc.Name;
           view.BotHp = npc.HP;

           player.Block += player_Block;
           player.Death += player_Death;
           player.Wound += player_Wound;

           npc.Block += npc_Block;
           npc.Death += npc_Death;
           npc.Wound += npc_Wound;

           view.Battle += view_Battle;
       }

       public void Difficulty()
       {
           switch (view.difficulty)
           {
               case Level.Easy:
                   npc.Damage = 5;
                   player.Damage = 5;
                   view.BotDamage = npc.Damage.ToString();
                   view.PlayerDamage = player.Damage.ToString();
                   break;
               case Level.Medium:
                   npc.Damage = 5;
                   player.Damage = 10;
                   view.BotDamage = npc.Damage.ToString();
                   view.PlayerDamage = player.Damage.ToString();
                   break;
           }
       }

       void view_Battle(object sender, GameEventArgs e)
       {
           controller.Battle();
       }

       void npc_Wound(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               NPC bot = (NPC)sender;
               npc.log = String.Format("{0} {1}: left Bot HP:{2}", player.Name, e.msg, bot.HP);
           }
       }

       void npc_Death(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               NPC bot = (NPC)sender;
               npc.log = String.Format("{0}: left Bot HP:{1}", e.msg, bot.HP);
               PlayerForm playerForm = new PlayerForm();
               playerForm.Show();
           }
       }

       void npc_Block(object sender, GameEventArgs e)
       {
           if (sender is NPC)
           {
               NPC bot = (NPC)sender;
               npc.log = string.Format("{0}: left Bot HP:{1}", e.msg, bot.HP);
           }
       }

       void player_Wound(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               Player user = (Player)sender;
               player.log = String.Format("{0} {1}:  left {2} HP:{3}", e.msg, player.Name, player.Name, player.HP);
           }
       }

       void player_Death(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               Player user = (Player)sender;
               player.log = String.Format("{0} {1}: left {2} HP:{3}", player.Name, e.msg, player.Name, player.HP);
               BotForm endForm = new BotForm();
               endForm.Show();
           }
       }

       void player_Block(object sender, GameEventArgs e)
       {
           if (sender is Player)
           {
               Player user = (Player)sender;
               player.log = String.Format("{0} {1}: left {2} HP:{3}", player.Name, e.msg, player.Name, player.HP);
           }
       }
   }
}
