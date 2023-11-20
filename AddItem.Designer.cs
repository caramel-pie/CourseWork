namespace Year2_Lab1
{
    partial class AddItem
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
            pledgetBox = new TextBox();
            titleBox = new TextBox();
            labelAdress = new Label();
            labelAge = new Label();
            labelTitle = new Label();
            labelType = new Label();
            condBox = new ListBox();
            idBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            typeBox = new ComboBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonSave.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(216, 543);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 39);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // pledgetBox
            // 
            pledgetBox.Location = new Point(182, 314);
            pledgetBox.MaxLength = 7;
            pledgetBox.Name = "pledgetBox";
            pledgetBox.Size = new Size(182, 31);
            pledgetBox.TabIndex = 23;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(182, 145);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(182, 31);
            titleBox.TabIndex = 22;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAdress.Location = new Point(182, 288);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(188, 23);
            labelAdress.TabIndex = 17;
            labelAdress.Text = "Enter the pledget:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(170, 203);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(211, 23);
            labelAge.TabIndex = 16;
            labelAge.Text = "Enter the condition:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(195, 119);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(154, 23);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Enter the title:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(185, 40);
            labelType.Name = "labelType";
            labelType.Size = new Size(179, 23);
            labelType.TabIndex = 14;
            labelType.Text = "Choose the type:";
            // 
            // condBox
            // 
            condBox.FormattingEnabled = true;
            condBox.ItemHeight = 25;
            condBox.Items.AddRange(new object[] { "New", "Used", "To repair" });
            condBox.Location = new Point(182, 229);
            condBox.Name = "condBox";
            condBox.Size = new Size(182, 29);
            condBox.TabIndex = 28;
            // 
            // idBox
            // 
            idBox.Location = new Point(182, 400);
            idBox.MaxLength = 7;
            idBox.Name = "idBox";
            idBox.Size = new Size(182, 31);
            idBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 374);
            label1.Name = "label1";
            label1.Size = new Size(218, 23);
            label1.TabIndex = 29;
            label1.Text = "Enter the owner's id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 461);
            label2.Name = "label2";
            label2.Size = new Size(221, 23);
            label2.TabIndex = 31;
            label2.Text = "Enter the finish date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(132, 487);
            dateTimePicker1.MinDate = new DateTime(2023, 11, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 29);
            dateTimePicker1.TabIndex = 32;
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(182, 66);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(182, 33);
            typeBox.TabIndex = 33;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(543, 635);
            Controls.Add(typeBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(label1);
            Controls.Add(condBox);
            Controls.Add(buttonSave);
            Controls.Add(pledgetBox);
            Controls.Add(titleBox);
            Controls.Add(labelAdress);
            Controls.Add(labelAge);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "AddItem";
            Text = "AddItem";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private TextBox pledgetBox;
        private TextBox titleBox;
        private Label labelAdress;
        private Label labelAge;
        private Label labelTitle;
        private Label labelType;
        private ListBox condBox;
        private TextBox idBox;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox typeBox;
    }
}