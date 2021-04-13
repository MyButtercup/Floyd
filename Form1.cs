using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floyd
{
    public partial class Form1 : Form
    {
        int N;
        DataTable Source;
        DataTable SourceL;
        int IterCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = int.Parse(inputN.Text);
            //количество столбцов и строк на 1 больше
            int k = N;
            Smezh.Width = tableL.Width = tableS.Width = 343;
            Smezh.Height = tableS.Height = tableL.Height = 345;
            Source = CreateGrid(++k, Smezh);
            SourceL = Source;
            AdjustGrid(Smezh);
            IterCount = 0;
        }

        public void AdjustGrid(DataGridView data)
        {
            int nc, nr;
            nc = data.ColumnCount;
            nr = data.RowCount;

            for (int i = 0; i < nc; i++)
            {
                data.Rows[i].Height = 30;
                data.Columns[i].Width = 30;
            }
        }

        public DataTable CreateGrid(int n, DataGridView data)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < n; i++)
            {
                DataColumn column = new DataColumn();
                column.ReadOnly = false;
                dt.Columns.Add(column);
            }
           
            DataRow row;
            char l1 = 'A';
           for (int j = 0; j < n; j++)
            {
                row = dt.NewRow();
                for (int i = 0; i < n; i++)
                {
                    if (j == 0)
                    {
                        char l = 'A';
                        for (int k = 1; k < n; k++)
                        {
                            row[k] = l;
                            l++;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            row[i] = l1;
                            l1++;
                        }
                        else
                        row[i] = "*";
                    }      
                }
                dt.Rows.Add(row);
            }
            data.DataSource = dt;
            for (int k = 0; k < n; k++)
            {
                data.Rows[0].Cells[k].Style.BackColor = Color.Green;
                data.Rows[k].Cells[0].Style.BackColor = Color.Green;
            }
            return dt;
        }

        public void CreateGridL(int n, DataGridView data)
        {
            data.DataSource = SourceL;
            for (int k = 0; k < n; k++)
            {
                data.Rows[0].Cells[k].Style.BackColor = Color.Green;
                data.Rows[k].Cells[0].Style.BackColor = Color.Green;
            }
        }

        public void CreateGridS(int n, DataGridView data)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < n; i++)
            {
                DataColumn column = new DataColumn();
                dt.Columns.Add(column);
            }

            DataRow row;
            char l1 = 'A';
            
            for (int j = 0; j < n; j++)
            {
                char l = 'A';
                row = dt.NewRow();
                for (int i = 0; i < n; i++)
                {
                    if (j == 0)
                    {
                        l = 'A';
                        for (int k = 1; k < n; k++)
                        {
                            row[k] = l;
                            l++; 
                            
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            row[i] = l1;
                            l1++;
                        }
                        else
                        {
                            row[i] = l;
                            l++;
                        }
                    }
                } 
                dt.Rows.Add(row);
            }    
            data.DataSource = dt;
            for (int k = 0; k < n; k++)
            {
                data.Rows[0].Cells[k].Style.BackColor = Color.Green;
                data.Rows[k].Cells[0].Style.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = N;
            ++k;
            CreateGridS(k, tableS);
            AdjustGrid(tableS);
            CreateGridL(k, tableL);
            AdjustGrid(tableL);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
