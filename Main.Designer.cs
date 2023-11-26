namespace Year2_Lab1
{
    partial class Main
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
            labelNum = new Label();
            buttonSave = new Button();
            logBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            idBox = new TextBox();
            SuspendLayout();
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(399, 183);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(78, 23);
            labelNum.TabIndex = 32;
            labelNum.Text = "Log In:";
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(385, 365);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 31;
            buttonSave.Text = "Submit";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // logBox
            // 
            logBox.Location = new Point(359, 249);
            logBox.Name = "logBox";
            logBox.Size = new Size(160, 31);
            logBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(384, 223);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 33;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(423, 287);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 35;
            label2.Text = "ID:";
            // 
            // idBox
            // 
            idBox.Location = new Point(359, 313);
            idBox.Name = "idBox";
            idBox.Size = new Size(160, 31);
            idBox.TabIndex = 34;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(878, 544);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Controls.Add(labelNum);
            Controls.Add(buttonSave);
            Controls.Add(logBox);
            ForeColor = Color.Black;
            Name = "Main";
            Text = "Pawnshop";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNum;
        private Button buttonSave;
        private TextBox logBox;
        private Label label1;
        private Label label2;
        private TextBox idBox;
    }
}