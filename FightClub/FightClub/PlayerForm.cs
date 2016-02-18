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
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
            pictureBox1.Image = FightClub.Properties.Resources.fight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
