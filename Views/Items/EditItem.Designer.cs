namespace Year2_Lab1
{
    partial class EditItem
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
            condBox = new ListBox();
            buttonSave = new Button();
            pledgetBox = new TextBox();
            titleBox = new TextBox();
            labelAdress = new Label();
            labelAge = new Label();
            labelTitle = new Label();
            labelType = new Label();
            Boxid = new TextBox();
            label2 = new Label();
            owBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            typeBox = new ComboBox();
            buttonEX = new Button();
            departBox = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // condBox
            // 
            condBox.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            condBox.FormattingEnabled = true;
            condBox.ItemHeight = 21;
            condBox.Items.AddRange(new object[] { "New", "Used", "To repair" });
            condBox.Location = new Point(115, 186);
            condBox.Name = "condBox";
            condBox.Size = new Size(300, 25);
            condBox.TabIndex = 39;
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(196, 572);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 37;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // pledgetBox
            // 
            pledgetBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pledgetBox.Location = new Point(115, 244);
            pledgetBox.MaxLength = 7;
            pledgetBox.Name = "pledgetBox";
            pledgetBox.Size = new Size(300, 31);
            pledgetBox.TabIndex = 36;
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.Location = new Point(115, 122);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(300, 31);
            titleBox.TabIndex = 35;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(165, 218);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(188, 23);
            labelAdress.TabIndex = 34;
            labelAdress.Text = "Enter the pledget:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(155, 160);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(211, 23);
            labelAge.TabIndex = 33;
            labelAge.Text = "Enter the condition:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(183, 96);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(154, 23);
            labelTitle.TabIndex = 32;
            labelTitle.Text = "Enter the title:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(168, 30);
            labelType.Name = "labelType";
            labelType.Size = new Size(179, 23);
            labelType.TabIndex = 31;
            labelType.Text = "Choose the type:";
            // 
            // Boxid
            // 
            Boxid.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Boxid.Location = new Point(115, 315);
            Boxid.Name = "Boxid";
            Boxid.Size = new Size(300, 31);
            Boxid.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 289);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 42;
            label2.Text = "Enter the ID:";
            // 
            // owBox
            // 
            owBox.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            owBox.Location = new Point(115, 386);
            owBox.Name = "owBox";
            owBox.Size = new Size(300, 31);
            owBox.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 360);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 46;
            label1.Text = "Enter the owner's ID:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(115, 449);
            dateTimePicker1.MinDate = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 29);
            dateTimePicker1.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(143, 423);
            label3.Name = "label3";
            label3.Size = new Size(221, 23);
            label3.TabIndex = 48;
            label3.Text = "Enter the finish date:";
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(115, 56);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(300, 33);
            typeBox.TabIndex = 50;
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
            // departBox
            // 
            departBox.FormattingEnabled = true;
            departBox.Location = new Point(115, 516);
            departBox.Name = "departBox";
            departBox.Size = new Size(300, 33);
            departBox.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(140, 490);
            label4.Name = "label4";
            label4.Size = new Size(251, 23);
            label4.TabIndex = 65;
            label4.Text = "Choose the department:";
            // 
            // EditItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(505, 626);
            Controls.Add(departBox);
            Controls.Add(label4);
            Controls.Add(buttonEX);
            Controls.Add(typeBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(owBox);
            Controls.Add(label1);
            Controls.Add(Boxid);
            Controls.Add(label2);
            Controls.Add(condBox);
            Controls.Add(buttonSave);
            Controls.Add(pledgetBox);
            Controls.Add(titleBox);
            Controls.Add(labelAdress);
            Controls.Add(labelAge);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "EditItem";
            Text = "EditItem";
            Load += EditItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox condBox;
        private Button buttonSave;
        private TextBox pledgetBox;
        private TextBox titleBox;
        private Label labelAdress;
        private Label labelAge;
        private Label labelTitle;
        private Label labelType;
        private TextBox Boxid;
        private Label label2;
        private TextBox owBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox typeBox;
        private Button buttonEX;
        private ComboBox departBox;
        private Label label4;
    }
}