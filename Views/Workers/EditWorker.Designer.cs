namespace Year2_Lab1.Views.Workers
{
    partial class EditWorker
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
            cardBox = new TextBox();
            label5 = new Label();
            depBox = new ComboBox();
            passBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            birthTime = new DateTimePicker();
            buttonEX = new Button();
            emailBox = new TextBox();
            label2 = new Label();
            phoneBox = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            numBox = new TextBox();
            adressBox = new TextBox();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            labelNum = new Label();
            labelAdress = new Label();
            labelAge = new Label();
            labelSurname = new Label();
            labelName = new Label();
            Boxid = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // cardBox
            // 
            cardBox.Location = new Point(420, 280);
            cardBox.Name = "cardBox";
            cardBox.Size = new Size(298, 31);
            cardBox.TabIndex = 110;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(446, 254);
            label5.Name = "label5";
            label5.Size = new Size(241, 23);
            label5.TabIndex = 109;
            label5.Text = "Enter the card number:";
            // 
            // depBox
            // 
            depBox.FormattingEnabled = true;
            depBox.Location = new Point(420, 349);
            depBox.Name = "depBox";
            depBox.Size = new Size(298, 33);
            depBox.TabIndex = 108;
            // 
            // passBox
            // 
            passBox.Location = new Point(420, 220);
            passBox.Name = "passBox";
            passBox.Size = new Size(298, 31);
            passBox.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(446, 323);
            label3.Name = "label3";
            label3.Size = new Size(251, 23);
            label3.TabIndex = 106;
            label3.Text = "Choose the department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(471, 194);
            label4.Name = "label4";
            label4.Size = new Size(211, 23);
            label4.TabIndex = 105;
            label4.Text = "Enter the password:";
            // 
            // birthTime
            // 
            birthTime.Location = new Point(86, 220);
            birthTime.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            birthTime.Name = "birthTime";
            birthTime.Size = new Size(300, 31);
            birthTime.TabIndex = 104;
            birthTime.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
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
            buttonEX.TabIndex = 103;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(420, 160);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(298, 31);
            emailBox.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(483, 134);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 101;
            label2.Text = "Enter the email:";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(420, 100);
            phoneBox.MaxLength = 13;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(298, 31);
            phoneBox.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(483, 74);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 99;
            label1.Text = "Enter the phone:";
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(349, 483);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 39);
            buttonSave.TabIndex = 98;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numBox
            // 
            numBox.Location = new Point(86, 349);
            numBox.Name = "numBox";
            numBox.Size = new Size(298, 31);
            numBox.TabIndex = 97;
            // 
            // adressBox
            // 
            adressBox.Location = new Point(86, 280);
            adressBox.Name = "adressBox";
            adressBox.Size = new Size(298, 31);
            adressBox.TabIndex = 96;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(86, 160);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(298, 31);
            surnameBox.TabIndex = 95;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(86, 100);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(298, 31);
            nameBox.TabIndex = 94;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(86, 323);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(304, 23);
            labelNum.TabIndex = 93;
            labelNum.Text = "Enter the identification code:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(137, 254);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(179, 23);
            labelAdress.TabIndex = 92;
            labelAdress.Text = "Enter the adress:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(149, 194);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(147, 23);
            labelAge.TabIndex = 91;
            labelAge.Text = "Enter the age:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(133, 134);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(200, 23);
            labelSurname.TabIndex = 90;
            labelSurname.Text = "Enter the surname:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(149, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 23);
            labelName.TabIndex = 89;
            labelName.Text = "Enter the name:";
            // 
            // Boxid
            // 
            Boxid.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Boxid.Location = new Point(299, 432);
            Boxid.Name = "Boxid";
            Boxid.Size = new Size(206, 31);
            Boxid.TabIndex = 112;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(335, 406);
            label6.Name = "label6";
            label6.Size = new Size(136, 23);
            label6.TabIndex = 111;
            label6.Text = "Enter the ID:";
            // 
            // EditWorker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(Boxid);
            Controls.Add(label6);
            Controls.Add(cardBox);
            Controls.Add(label5);
            Controls.Add(depBox);
            Controls.Add(passBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(birthTime);
            Controls.Add(buttonEX);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(phoneBox);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(numBox);
            Controls.Add(adressBox);
            Controls.Add(surnameBox);
            Controls.Add(nameBox);
            Controls.Add(labelNum);
            Controls.Add(labelAdress);
            Controls.Add(labelAge);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "EditWorker";
            Text = "EditWorker";
            Load += EditWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cardBox;
        private Label label5;
        private ComboBox depBox;
        private TextBox passBox;
        private Label label3;
        private Label label4;
        private DateTimePicker birthTime;
        private Button buttonEX;
        private TextBox emailBox;
        private Label label2;
        private TextBox phoneBox;
        private Label label1;
        private Button buttonSave;
        private TextBox numBox;
        private TextBox adressBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private Label labelNum;
        private Label labelAdress;
        private Label labelAge;
        private Label labelSurname;
        private Label labelName;
        private TextBox Boxid;
        private Label label6;
    }
}