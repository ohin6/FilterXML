using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
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

namespace FilterData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tutorial on https://www.youtube.com/watch?v=k44-N4Pegag&t=219s
        private void Btn_Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel WorkBook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    //Create a DataTable from file selected in OpenFileDialog
                    Cursor.Current = Cursors.WaitCursor;
                    System.Data.DataTable dt = new System.Data.DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName))//using XMLworkbook from the selected file from openfiledialog
                    {
                        bool isFirstRow = true; //first row added as Header
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows)
                        {
                            if (isFirstRow)
                            {
                                //Adding Column
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;

                            }
                            else
                            {
                                //adding data
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                            }
                        }
                        //convert datatable to datagridview viewer
                        dataGridView1.DataSource = dt.DefaultView;
                        Lbl_Total.Text = $"Total Records: {dataGridView1.RowCount}"; //change lbl.total to display number of rows in datagrid view
                        Cursor.Current = Cursors.Default;

                    }
                }
            }
        }

       //allow user defined search terms on dataTable
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView1.DataSource as DataView; //datatable in datagridview as variable Dataview (allows changes to datatable without affecting original file)
                if (dv != null)
                    dv.RowFilter = Txt_Search.Text;//RowFilter allows query of dataview table from textbox search input (Txt_search)
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);//error popup icon
            }
        }

        private void Txt_Search_KeyPress(object sender, KeyPressEventArgs e) //called this function by going into From1.cs{design} select textbox-> actions ->keypress
        {
            if (e.KeyChar == (char)13)// limiting search terms to 13 characters?
                btn_Search.PerformClick();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"Y:\Liverpool projects\Windows form app\Test";
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "txt|*.txt";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                TextWriter writer = new StreamWriter(saveFileDialog1.FileName.ToString());

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------");
                }
                writer.Close();
                MessageBox.Show("Data Exported");
            }

        }
    }
}
