namespace Year2_Lab1
{
    partial class ClientsTable
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonEX = new Button();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1075, 149);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(422, 33);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 1;
            label1.Text = "List of clients";
            // 
            // buttonEX
            // 
            buttonEX.BackColor = Color.Pink;
            buttonEX.Cursor = Cursors.Hand;
            buttonEX.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonEX.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEX.Location = new Point(11, 12);
            buttonEX.Name = "buttonEX";
            buttonEX.Size = new Size(34, 34);
            buttonEX.TabIndex = 2;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            buttonEX.Click += buttonEX_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(423, 228);
            label2.Name = "label2";
            label2.Size = new Size(219, 37);
            label2.TabIndex = 4;
            label2.Text = "List of items";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.MistyRose;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 268);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1075, 149);
            dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(449, 429);
            label3.Name = "label3";
            label3.Size = new Size(154, 37);
            label3.TabIndex = 6;
            label3.Text = "Receipts";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.MistyRose;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(11, 469);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(1075, 149);
            dataGridView3.TabIndex = 5;
            // 
            // ClientsTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(1098, 630);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(buttonEX);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ClientsTable";
            Text = "ClientsTable";
            Load += ClientsTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonEX;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
    }
}