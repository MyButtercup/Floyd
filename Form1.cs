using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        double[] xArray;
        double[] yArray;

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
            CreateGraph();
        }

        public void CreateArrow()
        {
            int xTemp, yTemp;
            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            pen.Width = 3;
            pen.CustomStartCap = new AdjustableArrowCap(3, 3);
            //pen.StartCap = LineCap.ArrowAnchor;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (Smezh[i,j].Value.ToString() != "∞")
                    {
                        if (i == j)
                        {
                            xTemp = i - 1;
                            yTemp = j - 1;
                            g.DrawArc(pen, (float)xArray[xTemp] + 15, (float)yArray[yTemp], 50, 50, 90, -180);
                            g.DrawString(Smezh[i,j].Value.ToString(), new Font("Times New Roman", 15), Brushes.Black, (float)xArray[xTemp] + 30, (float)yArray[yTemp] - 20);
                        }
                        else
                        {
                            xTemp = i - 1;
                            yTemp = j - 1;
                            g.DrawLine(pen, (float)xArray[xTemp] + 25, (float)yArray[xTemp] + 25, (float)xArray[yTemp] + 25, (float)yArray[yTemp] + 25);
                            float x = (((float)xArray[xTemp] + 25) + ((float)xArray[yTemp] + 25)) / (float)2;
                            float y = (((float)yArray[xTemp] + 25) + ((float)yArray[yTemp] + 25)) / (float)2;
                            g.DrawString(Smezh[i, j].Value.ToString(), new Font("Times New Roman", 15), Brushes.Black, x, y);
                        }
                    }
                }
            }
        }

        public void CreateGraph()
        {
            xArray = new double[N];
            yArray = new double[N];
            double radiusMin = 50;
            double radius = 150;
            double corner = 0;
            double corner1 = (360 / N) * Math.PI / 180;
            for (int i = 0; i < N; i++)
            {
                xArray[i] = (radius * Math.Cos(corner)) + 180;
                yArray[i] = (radius * Math.Sin(corner)) + 180;
                corner += corner1;
            }
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            char l = 'A';
            for (int i = 0; i < N; i++)
            {
                g.DrawEllipse(pen, (float)xArray[i], (float)yArray[i], (float)radiusMin, (float)radiusMin);
                g.DrawString(l.ToString(), new Font("Arial", 14), Brushes.Black, (float)xArray[i] + 15, (float)yArray[i] + 15);
                l++;
            }
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
                data.Rows[0].Cells[k].Style.BackColor = Color.Moccasin;
                data.Rows[k].Cells[0].Style.BackColor = Color.Moccasin;
            }
            return dt;
        }

        public void CreateGridL(int n, DataGridView data)
        {
            data.DataSource = SourceL;
            for (int k = 0; k < n; k++)
            {
                data.Rows[0].Cells[k].Style.BackColor = Color.Moccasin;
                data.Rows[k].Cells[0].Style.BackColor = Color.Moccasin;
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
                data.Rows[0].Cells[k].Style.BackColor = Color.Moccasin;
                data.Rows[k].Cells[0].Style.BackColor = Color.Moccasin;
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
            CreateArrow();
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
                        tableS.Rows[i].Cells[i].Style.BackColor = Color.Pink;
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

        private void inputN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
