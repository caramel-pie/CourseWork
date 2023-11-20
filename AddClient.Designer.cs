namespace Year2_Lab1
{
    partial class AddClient
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
            labelName = new Label();
            labelSurname = new Label();
            labelAge = new Label();
            labelAdress = new Label();
            labelDoc = new Label();
            labelNum = new Label();
            docBox = new ListBox();
            nameBox = new TextBox();
            surnameBox = new TextBox();
            adressBox = new TextBox();
            numBox = new TextBox();
            buttonSave = new Button();
            linkLabel1 = new LinkLabel();
            ageBar = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageBar).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(172, 63);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Enter the name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(152, 147);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(200, 23);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Enter the surname:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(172, 234);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(147, 23);
            labelAge.TabIndex = 2;
            labelAge.Text = "Enter the age:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(160, 323);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(179, 23);
            labelAdress.TabIndex = 3;
            labelAdress.Text = "Enter the adress:";
            // 
            // labelDoc
            // 
            labelDoc.AutoSize = true;
            labelDoc.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDoc.Location = new Point(137, 412);
            labelDoc.Name = "labelDoc";
            labelDoc.Size = new Size(236, 23);
            labelDoc.TabIndex = 4;
            labelDoc.Text = "Choose the document:";
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(109, 503);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(298, 23);
            labelNum.TabIndex = 5;
            labelNum.Text = "Enter the document number:";
            // 
            // docBox
            // 
            docBox.FormattingEnabled = true;
            docBox.ItemHeight = 25;
            docBox.Items.AddRange(new object[] { "Passport", "Driver license", "Inter-passport", "Indentif-code" });
            docBox.Location = new Point(109, 438);
            docBox.Name = "docBox";
            docBox.Size = new Size(298, 29);
            docBox.TabIndex = 6;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(109, 89);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(298, 31);
            nameBox.TabIndex = 7;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(109, 173);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(298, 31);
            surnameBox.TabIndex = 8;
            // 
            // adressBox
            // 
            adressBox.Location = new Point(109, 349);
            adressBox.Name = "adressBox";
            adressBox.Size = new Size(298, 31);
            adressBox.TabIndex = 9;
            // 
            // numBox
            // 
            numBox.Location = new Point(109, 529);
            numBox.Name = "numBox";
            numBox.Size = new Size(298, 31);
            numBox.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(192, 584);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 39);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(113, 3, 60);
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(113, 3, 60);
            linkLabel1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(113, 3, 60);
            linkLabel1.Location = new Point(160, 21);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(196, 21);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Client already exists";
            linkLabel1.VisitedLinkColor = Color.FromArgb(113, 3, 60);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ageBar
            // 
            ageBar.Location = new Point(109, 260);
            ageBar.Maximum = new decimal(new int[] { 82, 0, 0, 0 });
            ageBar.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            ageBar.Name = "ageBar";
            ageBar.Size = new Size(298, 31);
            ageBar.TabIndex = 15;
            ageBar.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(527, 658);
            Controls.Add(ageBar);
            Controls.Add(linkLabel1);
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
            Name = "AddClient";
            Text = "AddClient";
            ((System.ComponentModel.ISupportInitialize)ageBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelAge;
        private Label labelAdress;
        private Label labelDoc;
        private Label labelNum;
        private ListBox docBox;
        private TextBox nameBox;
        private TextBox surnameBox;
        private TextBox adressBox;
        private TextBox numBox;
        private Button buttonSave;
        private LinkLabel linkLabel1;
        private NumericUpDown ageBar;
    }
}