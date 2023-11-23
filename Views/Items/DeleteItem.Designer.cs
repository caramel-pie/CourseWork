namespace Year2_Lab1
{
    partial class DeleteItem
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
            buttonSave = new Button();
            numBox = new TextBox();
            labelNum = new Label();
            buttonEX = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(177, 237);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 28;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numBox
            // 
            numBox.Location = new Point(151, 187);
            numBox.Name = "numBox";
            numBox.Size = new Size(160, 31);
            numBox.TabIndex = 27;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(165, 149);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(136, 23);
            labelNum.TabIndex = 29;
            labelNum.Text = "Enter the ID:";
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
            // DeleteItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(450, 450);
            Controls.Add(buttonEX);
            Controls.Add(labelNum);
            Controls.Add(buttonSave);
            Controls.Add(numBox);
            Name = "DeleteItem";
            Text = "DeleteItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private TextBox numBox;
        private Label labelNum;
        private Button buttonEX;
    }
}