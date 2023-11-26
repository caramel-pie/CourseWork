namespace Year2_Lab1.Views.Workers
{
    partial class WorkerProfile
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
            button1 = new Button();
            buttonEX = new Button();
            label1 = new Label();
            adressLab = new Label();
            label2 = new Label();
            idBox = new TextBox();
            surnameLab = new Label();
            posLab = new Label();
            emaillab = new Label();
            nameLab = new Label();
            ownerID = new Label();
            labelPledget = new Label();
            labelTitle = new Label();
            labelType = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            button1.Font = new Font("Lucida Fax", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(49, 369);
            button1.Name = "button1";
            button1.Size = new Size(172, 27);
            button1.TabIndex = 79;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEX
            // 
            buttonEX.BackColor = Color.Pink;
            buttonEX.Cursor = Cursors.Hand;
            buttonEX.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonEX.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEX.Location = new Point(20, 20);
            buttonEX.Name = "buttonEX";
            buttonEX.Size = new Size(34, 34);
            buttonEX.TabIndex = 78;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 77;
            label1.Text = "Worker №";
            // 
            // adressLab
            // 
            adressLab.AutoSize = true;
            adressLab.Location = new Point(142, 225);
            adressLab.Name = "adressLab";
            adressLab.Size = new Size(33, 25);
            adressLab.TabIndex = 76;
            adressLab.Text = "___";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 316);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 75;
            label2.Text = "Email:";
            // 
            // idBox
            // 
            idBox.BackColor = Color.PapayaWhip;
            idBox.Location = new Point(171, 68);
            idBox.Name = "idBox";
            idBox.Size = new Size(150, 31);
            idBox.TabIndex = 74;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // surnameLab
            // 
            surnameLab.AutoSize = true;
            surnameLab.Location = new Point(160, 179);
            surnameLab.Name = "surnameLab";
            surnameLab.Size = new Size(33, 25);
            surnameLab.TabIndex = 73;
            surnameLab.Text = "___";
            // 
            // posLab
            // 
            posLab.AutoSize = true;
            posLab.Location = new Point(160, 270);
            posLab.Name = "posLab";
            posLab.Size = new Size(33, 25);
            posLab.TabIndex = 72;
            posLab.Text = "___";
            // 
            // emaillab
            // 
            emaillab.AutoSize = true;
            emaillab.Location = new Point(132, 314);
            emaillab.Name = "emaillab";
            emaillab.Size = new Size(33, 25);
            emaillab.TabIndex = 71;
            emaillab.Text = "___";
            // 
            // nameLab
            // 
            nameLab.AutoSize = true;
            nameLab.Location = new Point(129, 132);
            nameLab.Name = "nameLab";
            nameLab.Size = new Size(33, 25);
            nameLab.TabIndex = 70;
            nameLab.Text = "___";
            // 
            // ownerID
            // 
            ownerID.AutoSize = true;
            ownerID.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ownerID.Location = new Point(51, 272);
            ownerID.Name = "ownerID";
            ownerID.Size = new Size(100, 23);
            ownerID.TabIndex = 69;
            ownerID.Text = "Position:";
            // 
            // labelPledget
            // 
            labelPledget.AutoSize = true;
            labelPledget.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPledget.Location = new Point(51, 227);
            labelPledget.Name = "labelPledget";
            labelPledget.Size = new Size(85, 23);
            labelPledget.TabIndex = 68;
            labelPledget.Text = "Adress:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(51, 181);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(103, 23);
            labelTitle.TabIndex = 67;
            labelTitle.Text = "Surname:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(51, 134);
            labelType.Name = "labelType";
            labelType.Size = new Size(72, 23);
            labelType.TabIndex = 66;
            labelType.Text = "Name:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            button2.Font = new Font("Lucida Fax", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(50, 402);
            button2.Name = "button2";
            button2.Size = new Size(172, 27);
            button2.TabIndex = 80;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // WorkerProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonEX);
            Controls.Add(label1);
            Controls.Add(adressLab);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(surnameLab);
            Controls.Add(posLab);
            Controls.Add(emaillab);
            Controls.Add(nameLab);
            Controls.Add(ownerID);
            Controls.Add(labelPledget);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "WorkerProfile";
            Text = "WorkerProfile";
            Load += WorkerProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonEX;
        private Label label1;
        private Label adressLab;
        private Label label2;
        private TextBox idBox;
        private Label surnameLab;
        private Label posLab;
        private Label emaillab;
        private Label nameLab;
        private Label ownerID;
        private Label labelPledget;
        private Label labelTitle;
        private Label labelType;
        private Button button2;
    }
}