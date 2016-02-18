using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FightClub
{
    public partial class SaveForm : Form
    {
        List<ISave> collection = null;

        public SaveForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ExportToExcel(collection);
        }

        void ExportToExcel(List<ISave> table)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Name";
            workSheet.Cells[1, "B"] = "HP";
            workSheet.Cells[1, "C"] = "Damage";
            workSheet.Cells[1, "D"] = "Win";

            int row = 1;
            foreach (ISave c in table)
            {
                row++;
                workSheet.Cells[row, "A"] = c.Name;
                workSheet.Cells[row, "B"] = c.HP;
                workSheet.Cells[row, "C"] = c.Damage;
                workSheet.Cells[row, "D"] = c.Win;
            }

            workSheet.Range["A1"].AutoFormat(
                Microsoft.Office.Interop.Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

            workSheet.SaveAs(string.Format(@"{0}\Inventory.xlsx", Environment.CurrentDirectory));
            excelApp.Quit();
            MessageBox.Show("The FightClub.xslx file has been saved to app folder", "Export complete!");
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = collection;
        }

        private void ChangeHeight()
        {
            dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                               dataGridView1.ColumnHeadersHeight;
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
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            collection = new List<ISave> 
            {
                new Player{ Name = "Player", HP = 100, Damage = 5, Win = 1},
                new NPC{  Name = "Bot", HP = 100, Damage = 10, Win = 0}
            };
            DataGridInit();
            UpdateGrid();
        }

    }
}
