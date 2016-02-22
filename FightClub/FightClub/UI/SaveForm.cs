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
    public partial class SaveForm : Form
    {
        List<ISave> collection = null;
        public SaveForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            dataRecords.DataSource = null;
            dataRecords.DataSource = collection;
        }

        private void ChangeHeight()
        {
            dataRecords.Height = dataRecords.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                               dataRecords.ColumnHeadersHeight;
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ChangeHeight();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChangeHeight();
        }
        private void DataGridInit()
        {
            this.dataRecords.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataRecords.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            collection = new List<ISave> 
            {
                new Player{ Name = Transfer.PlayerName, Win = Transfer.player_count_win},
                new NPC{  Name = Transfer.BotName, Win = Transfer.bot_count_win}
            };
            UpdateGrid();
            DataGridInit();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Stream mysteam;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mysteam = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter writer = new StreamWriter(mysteam);
                    try
                    {
                        for (int i = 0; i < dataRecords.RowCount; i++)
                        {
                            writer.WriteLine("---------------------------------");
                            for (int j = 0; j < dataRecords.ColumnCount; j++)
                            {
                                writer.Write("|" + "\t" + dataRecords.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                            writer.WriteLine();
                            writer.WriteLine("---------------------------------");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        writer.Close();
                    }
                    mysteam.Close();
                }
            }

        }
    }
}
