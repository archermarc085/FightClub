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
        const string fileName = "records.txt";
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
        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ChangeHeight();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChangeHeight();
        }
        private void DataGridInitHeight()
        {
            this.dataRecords.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataRecords.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            collection = new List<ISave> 
            {
                new Player{ Name = Transfer.PlayerName, Win = Transfer.player_count_win},
                new NPC{  Name = Transfer.BotName, Win = Transfer.bot_count_win}
            };
            DataGridInitHeight();         
            UpdateGrid();
        }

        private List<ISave> Open() 
        {
            var users = new List<ISave>();

            if (File.Exists(fileName))
            {
                foreach (var line in File.ReadAllLines(fileName))
                {
                    try
                    {
                        var columns = line.Split('\t');
                        users.Add(new Player() { Name = columns[0], Win = Convert.ToInt16(columns[1]) });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Loaded!");
            }
            else 
            {
                MessageBox.Show("File not found!");
            }
            return users;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                TextWriter sw = new StreamWriter(fileName, true, System.Text.Encoding.Default);
                for (int i = 0; i < dataRecords.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataRecords.Columns.Count; j++)
                    {
                        try
                        {
                            sw.Write(dataRecords.Rows[i].Cells[j].Value.ToString() + "\t");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                     }
                    sw.WriteLine();
                }
                sw.Close();
                MessageBox.Show("Data Saved!");
            }
            else 
            {
                TextWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default);
                for (int i = 0; i < dataRecords.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataRecords.Columns.Count; j++)
                    {
                        try
                        {
                            sw.Write(dataRecords.Rows[i].Cells[j].Value.ToString() + "\t");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                     }
                    sw.WriteLine();
                }
                sw.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            collection = Open();
            UpdateGrid();
        }
    }
}
