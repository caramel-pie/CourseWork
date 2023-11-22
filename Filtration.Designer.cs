namespace Year2_Lab1
{
    partial class Filtration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            minpled = new TextBox();
            maxpled = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            matBox = new CheckedListBox();
            conBox = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 98);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Filtration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Material:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 416);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 36;
            label4.Text = "Minimal pledget:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 489);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 37;
            label5.Text = "Maximal pledget:";
            // 
            // minpled
            // 
            minpled.Location = new Point(37, 444);
            minpled.Name = "minpled";
            minpled.Size = new Size(150, 31);
            minpled.TabIndex = 38;
            // 
            // maxpled
            // 
            maxpled.Location = new Point(37, 517);
            maxpled.Name = "maxpled";
            maxpled.Size = new Size(150, 31);
            maxpled.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 281);
            label6.Name = "label6";
            label6.Size = new Size(94, 25);
            label6.TabIndex = 40;
            label6.Text = "Condition:";
            // 
            // button1
            // 
            button1.Location = new Point(54, 566);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 42;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(599, 344);
            dataGridView1.TabIndex = 43;
            // 
            // matBox
            // 
            matBox.FormattingEnabled = true;
            matBox.Location = new Point(37, 160);
            matBox.Name = "matBox";
            matBox.Size = new Size(180, 116);
            matBox.TabIndex = 46;
            // 
            // conBox
            // 
            conBox.FormattingEnabled = true;
            conBox.Location = new Point(37, 313);
            conBox.Name = "conBox";
            conBox.Size = new Size(180, 88);
            conBox.TabIndex = 47;
            // 
            // Filtration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 634);
            Controls.Add(conBox);
            Controls.Add(matBox);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(maxpled);
            Controls.Add(minpled);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Filtration";
            Text = "Filtration";
            Load += Filtration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox typeBox;
        private Label label4;
        private Label label5;
        private TextBox minpled;
        private TextBox maxpled;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView1;
        private CheckedListBox matBox;
        private CheckedListBox conBox;
    }
}