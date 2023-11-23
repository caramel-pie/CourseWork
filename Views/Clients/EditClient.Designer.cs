namespace Year2_Lab1
{
    partial class EditClient
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
            adressBox = new TextBox();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            docBox = new ListBox();
            labelNum = new Label();
            labelDoc = new Label();
            labelAdress = new Label();
            labelAge = new Label();
            labelSurname = new Label();
            labelName = new Label();
            idBox = new TextBox();
            label1 = new Label();
            ageBar = new NumericUpDown();
            emailBox = new TextBox();
            label2 = new Label();
            phoneBox = new TextBox();
            label3 = new Label();
            buttonEX = new Button();
            ((System.ComponentModel.ISupportInitialize)ageBar).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(239, 586);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numBox
            // 
            numBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numBox.Location = new Point(179, 342);
            numBox.Name = "numBox";
            numBox.Size = new Size(236, 31);
            numBox.TabIndex = 24;
            // 
            // adressBox
            // 
            adressBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            adressBox.Location = new Point(179, 228);
            adressBox.Name = "adressBox";
            adressBox.Size = new Size(236, 31);
            adressBox.TabIndex = 23;
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            surnameBox.Location = new Point(175, 108);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(236, 31);
            surnameBox.TabIndex = 22;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(179, 48);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(236, 31);
            nameBox.TabIndex = 21;
            // 
            // docBox
            // 
            docBox.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            docBox.FormattingEnabled = true;
            docBox.ItemHeight = 21;
            docBox.Items.AddRange(new object[] { "Passport", "Driver license", "Inter-passport", "Indentif-code" });
            docBox.Location = new Point(179, 288);
            docBox.Name = "docBox";
            docBox.Size = new Size(236, 25);
            docBox.TabIndex = 20;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(202, 316);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(191, 23);
            labelNum.TabIndex = 19;
            labelNum.Text = "Enter the number:";
            // 
            // labelDoc
            // 
            labelDoc.AutoSize = true;
            labelDoc.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoc.Location = new Point(179, 262);
            labelDoc.Name = "labelDoc";
            labelDoc.Size = new Size(236, 23);
            labelDoc.TabIndex = 18;
            labelDoc.Text = "Choose the document:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(202, 202);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(179, 23);
            labelAdress.TabIndex = 17;
            labelAdress.Text = "Enter the adress:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(216, 142);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(147, 23);
            labelAge.TabIndex = 16;
            labelAge.Text = "Enter the age:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(193, 82);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(200, 23);
            labelSurname.TabIndex = 15;
            labelSurname.Text = "Enter the surname:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(209, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 23);
            labelName.TabIndex = 14;
            labelName.Text = "Enter the name:";
            // 
            // idBox
            // 
            idBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            idBox.Location = new Point(179, 522);
            idBox.Name = "idBox";
            idBox.Size = new Size(236, 31);
            idBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 496);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 27;
            label1.Text = "Enter the ID:";
            // 
            // ageBar
            // 
            ageBar.Location = new Point(179, 168);
            ageBar.Maximum = new decimal(new int[] { 82, 0, 0, 0 });
            ageBar.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageBar.Name = "ageBar";
            ageBar.Size = new Size(236, 31);
            ageBar.TabIndex = 29;
            ageBar.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // emailBox
            // 
            emailBox.Location = new Point(175, 462);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(240, 31);
            emailBox.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(209, 436);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 32;
            label2.Text = "Enter the email:";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(175, 402);
            phoneBox.MaxLength = 13;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(240, 31);
            phoneBox.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(209, 376);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 30;
            label3.Text = "Enter the phone:";
            // 
            // buttonEX
            // 
            buttonEX.BackColor = Color.Pink;
            buttonEX.Cursor = Cursors.Hand;
            buttonEX.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonEX.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEX.Location = new Point(12, 11);
            buttonEX.Name = "buttonEX";
            buttonEX.Size = new Size(34, 34);
            buttonEX.TabIndex = 62;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            buttonEX.Click += buttonEX_Click;
            // 
            // EditClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(571, 644);
            Controls.Add(buttonEX);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(phoneBox);
            Controls.Add(label3);
            Controls.Add(ageBar);
            Controls.Add(idBox);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(numBox);
            Controls.Add(adressBox);
            Controls.Add(surnameBox);
            Controls.Add(nameBox);
            Controls.Add(docBox);
            Controls.Add(labelNum);
            Controls.Add(labelDoc);
            Controls.Add(labelAdress);
            Controls.Add(labelAge);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "EditClient";
            Text = "EditClient";
            ((System.ComponentModel.ISupportInitialize)ageBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private TextBox numBox;
        private TextBox adressBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private ListBox docBox;
        private Label labelNum;
        private Label labelDoc;
        private Label labelAdress;
        private Label labelAge;
        private Label labelSurname;
        private Label labelName;
        private TextBox idBox;
        private Label label1;
        private NumericUpDown ageBar;
        private TextBox emailBox;
        private Label label2;
        private TextBox phoneBox;
        private Label label3;
        private Button buttonEX;
    }
}