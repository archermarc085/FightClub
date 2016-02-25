using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class SaveForm : Form
    {
        List<Save> collection = null;
        string fullpath = "";
       //const string fileName = "records.txt";
        public SaveForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            dataRecords.DataSource = null;
            dataRecords.DataSource = collection;
        }

        //private void ChangeHeight()
        //{
        //    dataRecords.Height = dataRecords.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
        //                       dataRecords.ColumnHeadersHeight;
        //}
        //private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    ChangeHeight();
        //}

        //private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    ChangeHeight();
        //}
        //private void DataGridInitHeight()
        //{
        //    this.dataRecords.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
        //    this.dataRecords.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
        //}

        private void SaveForm_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string filepath = path.Replace(@"\bin\Debug", "");
            string folder = @"\Resources\records.txt";
            fullpath = filepath + folder;

            collection = new List<Save> 
            {
                new Save(){ Name = StaticValues.PlayerName, Win = StaticValues.player_count_win},
                new Save(){  Name = StaticValues.BotName, Win = StaticValues.bot_count_win}
            };
            UpdateGrid();
        }

        private List<Save> Open() 
        {
            var users = new List<Save>();

            if (File.Exists(fullpath))
            {
                foreach (var line in File.ReadAllLines(fullpath))
                {
                    try
                    {
                        var columns = line.Split('\t');
                        users.Add(new Save() { Name = columns[0], Win = Convert.ToInt32(columns[1]) });
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
            users.Sort();
            return users;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(fullpath))
            {
                TextWriter sw = new StreamWriter(fullpath, true, System.Text.Encoding.Default);
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
                TextWriter sw = new StreamWriter(fullpath, false, System.Text.Encoding.Default);
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

        static void Serialize()
        {
            List<Save> list = new List<Save>();
            list.Add(new Save() { Name = StaticValues.PlayerName, Win = StaticValues.player_count_win });
            list.Add(new Save() { Name = StaticValues.BotName, Win = StaticValues.bot_count_win });
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, list);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        static void Deserialize()
        {
            StringBuilder str = new StringBuilder();
            List<Save> list = null;

            FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                list = (List<Save>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            foreach (var de in list)
            {
                str.AppendLine(de.Name + "\t" + de.Win);
            }
                MessageBox.Show( str.ToString(),"PVE");
        }

        private void pveButton_Click(object sender, EventArgs e)
        {
            Serialize();
            Deserialize();
        }

    }
}
