
namespace Floyd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.inputN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Smezh = new System.Windows.Forms.DataGridView();
            this.tableL = new System.Windows.Forms.DataGridView();
            this.tableS = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Smezh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество вершин";
            // 
            // inputN
            // 
            this.inputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputN.Location = new System.Drawing.Point(332, 6);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(100, 32);
            this.inputN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(447, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ввести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Smezh
            // 
            this.Smezh.AllowUserToAddRows = false;
            this.Smezh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Smezh.ColumnHeadersVisible = false;
            this.Smezh.Location = new System.Drawing.Point(35, 61);
            this.Smezh.Name = "Smezh";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Smezh.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Smezh.RowHeadersVisible = false;
            this.Smezh.Size = new System.Drawing.Size(240, 150);
            this.Smezh.TabIndex = 3;
            // 
            // tableL
            // 
            this.tableL.AllowUserToAddRows = false;
            this.tableL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableL.ColumnHeadersVisible = false;
            this.tableL.Location = new System.Drawing.Point(567, 61);
            this.tableL.Name = "tableL";
            this.tableL.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableL.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableL.RowHeadersVisible = false;
            this.tableL.Size = new System.Drawing.Size(240, 150);
            this.tableL.TabIndex = 4;
            // 
            // tableS
            // 
            this.tableS.AllowUserToAddRows = false;
            this.tableS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableS.ColumnHeadersVisible = false;
            this.tableS.Location = new System.Drawing.Point(1038, 61);
            this.tableS.Name = "tableS";
            this.tableS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableS.RowHeadersVisible = false;
            this.tableS.Size = new System.Drawing.Size(240, 150);
            this.tableS.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(417, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Создать таблицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(446, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Шаг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 804);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableS);
            this.Controls.Add(this.tableL);
            this.Controls.Add(this.Smezh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Floyd";
            ((System.ComponentModel.ISupportInitialize)(this.Smezh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Smezh;
        private System.Windows.Forms.DataGridView tableL;
        private System.Windows.Forms.DataGridView tableS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

