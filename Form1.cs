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
        //количество вершин графа
        int N;
        //для главного грида
        DataTable Source;
        //для таблицы L
        DataTable SourceL;
        //количество шагов алгоритма
        int IterCount = 1;
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
            IterCount = 1;
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
                        row[i] = "∞";
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
            StepFloyd();
            
        }

        public void StepFloyd()
        {
            int ColorIt = IterCount - 1;
            if (ColorIt > 0)
            {
                for (int i = 1; i <= N; i++)
                {

                    for (int j = 1; j <= N; j++)
                    {
                        tableL.Rows[ColorIt].Cells[j].Style.BackColor = Color.White;
                        tableL.Rows[i].Cells[ColorIt].Style.BackColor = Color.White;
                        tableS.Rows[i].Cells[ColorIt].Style.BackColor = Color.White;
                    }
                }
            }
            if (IterCount <= N)
            {
                for (int i = 1; i <= N; i++)
                {
                    if (i == IterCount)
                    {
                        for (int j = 1; j <= N; j++)
                        {
                            tableL.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                        }
                        continue;
                    }
                    for (int j = 1; j <= N; j++)
                    {
                        if (j == IterCount)
                        {
                            for (int k = 1; k <= N; k++)
                            {
                               tableL.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                               tableS.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                            }
                            continue;
                        }
                            
                        if (tableL.Rows[IterCount].Cells[j].Value.ToString() != "∞" && tableL.Rows[i].Cells[IterCount].Value.ToString() != "∞")
                        {
                            int a = int.Parse(tableL.Rows[IterCount].Cells[j].Value.ToString());
                            int b = int.Parse(tableL.Rows[i].Cells[IterCount].Value.ToString());

                            if (tableL.Rows[i].Cells[j].Value.ToString() == "∞" || int.Parse(tableL.Rows[i].Cells[j].Value.ToString()) > (a + b))
                            {
                                tableL.Rows[i].Cells[j].Value = a + b;
                                tableS.Rows[i].Cells[j].Value = tableS.Rows[i].Cells[IterCount].Value;
                            }
                        }
                    }
                }
                IterCount++;
            }
            else
            {
                MessageBox.Show("Алгоритм закончен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
