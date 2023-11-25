namespace Year2_Lab1
{
    partial class Queries
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
            SQLBox = new TextBox();
            buttonSQL = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            labelType = new Label();
            buttonEX = new Button();
            statbutton = new Button();
            statBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SQLBox
            // 
            SQLBox.Location = new Point(12, 107);
            SQLBox.Name = "SQLBox";
            SQLBox.Size = new Size(776, 31);
            SQLBox.TabIndex = 0;
            // 
            // buttonSQL
            // 
            buttonSQL.Cursor = Cursors.Hand;
            buttonSQL.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSQL.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSQL.Location = new Point(12, 149);
            buttonSQL.Name = "buttonSQL";
            buttonSQL.Size = new Size(112, 34);
            buttonSQL.TabIndex = 1;
            buttonSQL.Text = "Do SQL";
            buttonSQL.UseVisualStyleBackColor = true;
            buttonSQL.Click += buttonSQL_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 209);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(12, 74);
            labelType.Name = "labelType";
            labelType.Size = new Size(221, 23);
            labelType.TabIndex = 47;
            labelType.Text = "Write the query here:";
            // 
            // buttonEX
            // 
            buttonEX.BackColor = Color.Pink;
            buttonEX.Cursor = Cursors.Hand;
            buttonEX.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonEX.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEX.Location = new Point(12, 12);
            buttonEX.Name = "buttonEX";
            buttonEX.Size = new Size(34, 34);
            buttonEX.TabIndex = 62;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            buttonEX.Click += buttonEX_Click;
            // 
            // statbutton
            // 
            statbutton.Cursor = Cursors.Hand;
            statbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            statbutton.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            statbutton.Location = new Point(269, 194);
            statbutton.Name = "statbutton";
            statbutton.Size = new Size(112, 34);
            statbutton.TabIndex = 63;
            statbutton.Text = "Run";
            statbutton.UseVisualStyleBackColor = true;
            statbutton.Click += statbutton_Click;
            // 
            // statBox
            // 
            statBox.FormattingEnabled = true;
            statBox.Items.AddRange(new object[] { "Most valuable departments", "Count by material" });
            statBox.Location = new Point(12, 194);
            statBox.Name = "statBox";
            statBox.Size = new Size(251, 33);
            statBox.TabIndex = 64;
            // 
            // Queries
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(800, 466);
            Controls.Add(statBox);
            Controls.Add(statbutton);
            Controls.Add(buttonEX);
            Controls.Add(labelType);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSQL);
            Controls.Add(SQLBox);
            Name = "Queries";
            Text = "Queries";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SQLBox;
        private Button buttonSQL;
        private DataGridView dataGridView1;
        private Label label1;
        private Label labelType;
        private Button buttonEX;
        private Button statbutton;
        private ComboBox statBox;
    }
}