using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class GameForm : Form
    {
        string logUser = "";
        string logBot = "";
        GameController game;
        Player player = new Player();
        NPC npc = new NPC();
        public GameForm()
        {
            InitializeComponent();
            UpdateHP();

            player.Block += player_Block;
            player.Death += player_Death;
            player.Wound += player_Wound;

            npc.Block += npc_Block;
            npc.Death += npc_Death;
            npc.Wound += npc_Wound;
        }

        void npc_Wound(object sender, GameEventArgs e)
        {
            if (sender is NPC) 
            {
                NPC bot = (NPC)sender;
                logBot = String.Format("{0}: left Bot HP:{1}",e.msg, bot.HP);
            }
        }

        void npc_Death(object sender, GameEventArgs e)
        {
            if (sender is NPC)
            {
                NPC bot = (NPC)sender;
                logBot = String.Format("{0}: left Bot HP:{1}", e.msg, bot.HP);
                PlayerForm playerForm = new PlayerForm();
                playerForm.Show();
            }
        }

        void npc_Block(object sender, GameEventArgs e)
        {
            if (sender is NPC)
            {
                NPC bot = (NPC)sender;
                logBot = string.Format("{0}: left Bot HP:{1}", e.msg, bot.HP);
            }
        }

        void player_Wound(object sender, GameEventArgs e)
        {
            if (sender is Player)
            {
                Player user = (Player)sender;
                logUser = String.Format("{0}: left Player HP:{1}", e.msg, player.HP);
            }
        }

        void player_Death(object sender, GameEventArgs e)
        {
            if (sender is Player)
            {
                Player user = (Player)sender;
                logUser = String.Format("{0}: left Player HP:{1}", e.msg, player.HP);
                BotForm endForm = new BotForm();
                endForm.Show();
            }
        }

        void player_Block(object sender, GameEventArgs e)
        {
            if (sender is Player)
            {
                Player user = (Player)sender;
                logUser = String.Format("{0}: left Player HP:{1}", e.msg, player.HP);
            }
        }

        private void fightButton_Click(object sender, EventArgs e)
        {

            if (playerRadioButtonHead.Checked) { player.Hit = (int)Parts.Head; }
            if (playerRadioButtonBody.Checked) { player.Hit = (int)Parts.Body; }
            if (playerRadioButtonLegs.Checked) { player.Hit = (int)Parts.Legs; }

            if (playerBlockedRadioButtonHead.Checked) { player.Set = (int)Parts.Head; }
            if (playerBlockedRadioButtonBody.Checked) { player.Set = (int)Parts.Body; }
            if (playerBlockedRadioButtonLegs.Checked) { player.Set = (int)Parts.Legs; }
            game = new GameController(player, npc);

            UpdateHP();
            UpdateLog(); 
        }

        private void UpdateLog()
        {
            listBox1.Items.Add(logUser);
            listBox1.Items.Add(logBot);
        }

        private void UpdateHP()
        {
            userHpLabel.Text = player.HP.ToString();
            botHpLabel.Text = npc.HP.ToString();
            userProgressBar.Value = player.HP;
            botProgressBar.Value = npc.HP;
        }
        public string PlayerName { get;set;}

        private void GameForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = PlayerName;
            player.Name = PlayerName;
            npc.Name = "Bot";
            botNameLabel.Text = npc.Name;
            pictureBox1.Image = FightClub.Properties.Resources.fight;
            pictureBox2.Image = FightClub.Properties.Resources.bot;
        }
        public void Reset()
        {
            listBox1.Items.Clear();
            player.HP = 100;
            npc.HP = 100;
            UpdateHP();
        }
        

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }
    }
}
