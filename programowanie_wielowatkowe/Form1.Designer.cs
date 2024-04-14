namespace programowanie_wielowatkowe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            create_matrix = new Button();
            rankBox1 = new TextBox();
            label1 = new Label();
            matrixView1 = new DataGridView();
            matrixView2 = new DataGridView();
            matrixView3 = new DataGridView();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)matrixView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixView3).BeginInit();
            SuspendLayout();
            // 
            // create_matrix
            // 
            create_matrix.Location = new Point(194, 60);
            create_matrix.Name = "create_matrix";
            create_matrix.Size = new Size(100, 100);
            create_matrix.TabIndex = 0;
            create_matrix.Text = "Stwórz";
            create_matrix.UseVisualStyleBackColor = true;
            create_matrix.Click += create_matrix_Click;
            // 
            // rankBox1
            // 
            rankBox1.Location = new Point(59, 112);
            rankBox1.Name = "rankBox1";
            rankBox1.Size = new Size(113, 23);
            rankBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 94);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 2;
            label1.Text = "Podaj rząd macierzy";
            // 
            // matrixView1
            // 
            matrixView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            matrixView1.DefaultCellStyle = dataGridViewCellStyle1;
            matrixView1.Location = new Point(318, 12);
            matrixView1.Name = "matrixView1";
            matrixView1.Size = new Size(232, 210);
            matrixView1.TabIndex = 3;
            // 
            // matrixView2
            // 
            matrixView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            matrixView2.DefaultCellStyle = dataGridViewCellStyle2;
            matrixView2.Location = new Point(556, 12);
            matrixView2.Name = "matrixView2";
            matrixView2.Size = new Size(232, 210);
            matrixView2.TabIndex = 6;
            // 
            // matrixView3
            // 
            matrixView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView3.Location = new Point(556, 228);
            matrixView3.Name = "matrixView3";
            matrixView3.Size = new Size(232, 210);
            matrixView3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 352);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 334);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 9;
            label3.Text = "Czas mnożenia low level";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 290);
            label4.Name = "label4";
            label4.Size = new Size(140, 15);
            label4.TabIndex = 11;
            label4.Text = "Czas mnożenia high level";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 396);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 378);
            label5.Name = "label5";
            label5.Size = new Size(180, 15);
            label5.TabIndex = 13;
            label5.Text = "Czas mnożenia na jednym wątku";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(59, 199);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(235, 23);
            progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(matrixView3);
            Controls.Add(matrixView2);
            Controls.Add(matrixView1);
            Controls.Add(label1);
            Controls.Add(rankBox1);
            Controls.Add(create_matrix);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)matrixView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_matrix;
        private TextBox rankBox1;
        private Label label1;
        private DataGridView matrixView1;
        private DataGridView matrixView2;
        private DataGridView matrixView3;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ProgressBar progressBar1;
    }
}
