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
    public partial class MainForm : Form
    {
        GameForm game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            game = new GameForm();
            game.PlayerName = nameTextBox.Text;
            game.ShowDialog();
            this.Close();     
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                enterButton.PerformClick();
            }
        }
    }
}
