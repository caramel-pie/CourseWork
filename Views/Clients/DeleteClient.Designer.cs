namespace Year2_Lab1
{
    partial class DeleteClient
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
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(173, 282);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numBox
            // 
            numBox.Location = new Point(144, 230);
            numBox.Name = "numBox";
            numBox.Size = new Size(164, 31);
            numBox.TabIndex = 24;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(161, 189);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(136, 23);
            labelNum.TabIndex = 19;
            labelNum.Text = "Enter the ID:";
            // 
            // DeleteClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(473, 509);
            Controls.Add(buttonSave);
            Controls.Add(numBox);
            Controls.Add(labelNum);
            Name = "DeleteClient";
            Text = "DeleteClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private TextBox numBox;
        private Label labelNum;
    }
}