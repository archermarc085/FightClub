using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class GameForm : Form,IView
    {
        IPlayer player = new Player();
        IPlayer npc = new NPC();
        string fullpath = "Log.txt";
        Presenter presenter;
        public Level difficulty { get; set; }
        public GameForm()
        {
            InitializeComponent();
            UpdateHP();
        }
        private void fightButton_Click(object sender, EventArgs e)
        {
            userdamageLabel.Text = player.Damage.ToString();
         
            if (playerRadioButtonHead.Checked) { player.Hit = (int)Parts.Head; }
            if (playerRadioButtonBody.Checked) { player.Hit = (int)Parts.Body; }
            if (playerRadioButtonLegs.Checked) { player.Hit = (int)Parts.Legs; }

            if (playerBlockedRadioButtonHead.Checked) { player.Set = (int)Parts.Head; }
            if (playerBlockedRadioButtonBody.Checked) { player.Set = (int)Parts.Body; }
            if (playerBlockedRadioButtonLegs.Checked) { player.Set = (int)Parts.Legs; }

            if (Battle != null)
                Battle(this, new GameEventArgs("Fight"));
            UpdateHP();
            UpdateLog();
            CheckHp();
            RadioButtonUnchecked();
        }

        private void CheckHp()
        {
            if (player.HP == 0 || npc.HP == 0)
            {
                 playerBlockedRadioButtonHead.AutoCheck = false;
                 playerBlockedRadioButtonBody.AutoCheck = false;
                 playerBlockedRadioButtonLegs.AutoCheck = false;
                 playerRadioButtonHead.AutoCheck = false;
                 playerRadioButtonBody.AutoCheck = false;
                 playerRadioButtonLegs.AutoCheck = false;
                 fightButton.Visible = false;
            }
        }

        private void RadioButtonUnchecked()
        {
            playerBlockedRadioButtonHead.Checked = false;
            playerBlockedRadioButtonBody.Checked = false;
            playerBlockedRadioButtonLegs.Checked = false;
            playerRadioButtonHead.Checked = false;
            playerRadioButtonBody.Checked = false;
            playerRadioButtonLegs.Checked = false;
        }

        private void UpdateLog()
        {
            listBox1.Items.Add(player.log);
            listBox1.Items.Add(npc.log);
        }

        private void UpdateHP()
        {
            userHpLabel.Text = player.HP.ToString();
            botHpLabel.Text = npc.HP.ToString();
            userProgressBar.Value = player.HP;
            botProgressBar.Value = npc.HP;
        }
        public string PlayerName
        {
            get { return userNameLabel.Text; }
            set { userNameLabel.Text = value; }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = FightClub.Properties.Resources.fight;
            pictureBox2.Image = FightClub.Properties.Resources.bot;
            presenter = new Presenter(this, player, npc);
            presenter.Difficulty();
        }
        public void Reset()
        {
            listBox1.Items.Clear();
            fightButton.Visible = true;
            playerBlockedRadioButtonHead.AutoCheck = true;
            playerBlockedRadioButtonBody.AutoCheck = true;
            playerBlockedRadioButtonLegs.AutoCheck = true;
            playerRadioButtonHead.AutoCheck = true;
            playerRadioButtonBody.AutoCheck = true;
            playerRadioButtonLegs.AutoCheck = true;

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
        public int PlayerHp
        {
            get
            {
                return userProgressBar.Value;
            }
            set
            {
                userProgressBar.Value = value;
                userHpLabel.Text = value.ToString();
            }
        }
        public int BotHp
        {
            get
            {
                return botProgressBar.Value;
            }
            set
            {
                botProgressBar.Value = value;
                botHpLabel.Text = value.ToString();
            }
        }
        public string BotName
        {
            get { return botNameLabel.Text; }
            set { botNameLabel.Text = value; }
        }
        public string BotDamage
        {
            get { return botdamageLabel.Text; }
            set { botdamageLabel.Text = value; }
        }
        public string PlayerDamage
        {
            get { return userdamageLabel.Text; }
            set { userdamageLabel.Text = value; }
        }
        public event GameForceHandler Battle;


      

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(fullpath);
            sw.WriteLine(string.Format("Fight: {0} vs {1} ", PlayerName, npc.Name));
            sw.WriteLine(string.Format("Level difficulty: {0}", difficulty.ToString()));
            foreach (string s in listBox1.Items)
            {
                sw.WriteLine(s);
            }
            sw.WriteLine("End battle!");
            sw.Close();
            MessageBox.Show("Saved!");
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm saving = new SaveForm();
            saving.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
