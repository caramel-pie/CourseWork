namespace Year2_Lab1.Views.Workers
{
    partial class AddWorker
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
            birthTime = new DateTimePicker();
            passBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            depBox = new ComboBox();
            cardBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonEX
            // 
            buttonEX.BackColor = Color.Pink;
            buttonEX.Cursor = Cursors.Hand;
            buttonEX.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonEX.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEX.Location = new Point(15, 14);
            buttonEX.Name = "buttonEX";
            buttonEX.Size = new Size(34, 34);
            buttonEX.TabIndex = 81;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(446, 151);
            emailBox.MaxLength = 50;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(298, 31);
            emailBox.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(509, 125);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 79;
            label2.Text = "Enter the email:";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(446, 91);
            phoneBox.MaxLength = 13;
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(298, 31);
            phoneBox.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(509, 65);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 77;
            label1.Text = "Enter the phone:";
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(378, 406);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 39);
            buttonSave.TabIndex = 74;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numBox
            // 
            numBox.Location = new Point(112, 340);
            numBox.Name = "numBox";
            numBox.Size = new Size(298, 31);
            numBox.TabIndex = 73;
            // 
            // adressBox
            // 
            adressBox.Location = new Point(112, 271);
            adressBox.Name = "adressBox";
            adressBox.Size = new Size(298, 31);
            adressBox.TabIndex = 72;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(112, 151);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(298, 31);
            surnameBox.TabIndex = 71;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(112, 91);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(298, 31);
            nameBox.TabIndex = 70;
            // 
            // labelNum
            // 
            labelNum.AutoSize = true;
            labelNum.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNum.Location = new Point(112, 314);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(304, 23);
            labelNum.TabIndex = 68;
            labelNum.Text = "Enter the identification code:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(163, 245);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(179, 23);
            labelAdress.TabIndex = 66;
            labelAdress.Text = "Enter the adress:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(175, 185);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(147, 23);
            labelAge.TabIndex = 65;
            labelAge.Text = "Enter the age:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(159, 125);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(200, 23);
            labelSurname.TabIndex = 64;
            labelSurname.Text = "Enter the surname:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(175, 65);
            labelName.Name = "labelName";
            labelName.Size = new Size(167, 23);
            labelName.TabIndex = 63;
            labelName.Text = "Enter the name:";
            // 
            // birthTime
            // 
            birthTime.Location = new Point(112, 211);
            birthTime.MaxDate = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            birthTime.Name = "birthTime";
            birthTime.Size = new Size(300, 31);
            birthTime.TabIndex = 82;
            birthTime.Value = new DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // passBox
            // 
            passBox.Location = new Point(446, 211);
            passBox.Name = "passBox";
            passBox.Size = new Size(298, 31);
            passBox.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(472, 314);
            label3.Name = "label3";
            label3.Size = new Size(251, 23);
            label3.TabIndex = 84;
            label3.Text = "Choose the department:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(497, 185);
            label4.Name = "label4";
            label4.Size = new Size(211, 23);
            label4.TabIndex = 83;
            label4.Text = "Enter the password:";
            // 
            // depBox
            // 
            depBox.FormattingEnabled = true;
            depBox.Location = new Point(446, 340);
            depBox.Name = "depBox";
            depBox.Size = new Size(298, 33);
            depBox.TabIndex = 86;
            // 
            // cardBox
            // 
            cardBox.Location = new Point(446, 271);
            cardBox.Name = "cardBox";
            cardBox.Size = new Size(298, 31);
            cardBox.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(472, 245);
            label5.Name = "label5";
            label5.Size = new Size(241, 23);
            label5.TabIndex = 87;
            label5.Text = "Enter the card number:";
            // 
            // AddWorker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 471);
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
            Name = "AddWorker";
            Text = "AddWorker";
            Load += AddWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DateTimePicker birthTime;
        private TextBox passBox;
        private Label label3;
        private Label label4;
        private ComboBox depBox;
        private TextBox cardBox;
        private Label label5;
    }
}