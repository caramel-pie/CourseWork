namespace Year2_Lab1
{
    partial class ClientProfile
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
            idBox = new TextBox();
            surnameLab = new Label();
            docnumLab = new Label();
            doctypelab = new Label();
            nameLab = new Label();
            ownerID = new Label();
            labelPledget = new Label();
            labelTitle = new Label();
            labelType = new Label();
            adressLab = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonEX = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idBox
            // 
            idBox.BackColor = Color.PapayaWhip;
            idBox.Location = new Point(163, 60);
            idBox.Name = "idBox";
            idBox.Size = new Size(150, 31);
            idBox.TabIndex = 56;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // surnameLab
            // 
            surnameLab.AutoSize = true;
            surnameLab.Location = new Point(152, 171);
            surnameLab.Name = "surnameLab";
            surnameLab.Size = new Size(33, 25);
            surnameLab.TabIndex = 55;
            surnameLab.Text = "___";
            // 
            // docnumLab
            // 
            docnumLab.AutoSize = true;
            docnumLab.Location = new Point(219, 263);
            docnumLab.Name = "docnumLab";
            docnumLab.Size = new Size(33, 25);
            docnumLab.TabIndex = 53;
            docnumLab.Text = "___";
            // 
            // doctypelab
            // 
            doctypelab.AutoSize = true;
            doctypelab.Location = new Point(253, 307);
            doctypelab.Name = "doctypelab";
            doctypelab.Size = new Size(33, 25);
            doctypelab.TabIndex = 52;
            doctypelab.Text = "___";
            // 
            // nameLab
            // 
            nameLab.AutoSize = true;
            nameLab.Location = new Point(121, 124);
            nameLab.Name = "nameLab";
            nameLab.Size = new Size(33, 25);
            nameLab.TabIndex = 51;
            nameLab.Text = "___";
            // 
            // ownerID
            // 
            ownerID.AutoSize = true;
            ownerID.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ownerID.Location = new Point(43, 264);
            ownerID.Name = "ownerID";
            ownerID.Size = new Size(170, 23);
            ownerID.TabIndex = 50;
            ownerID.Text = "Document type:";
            // 
            // labelPledget
            // 
            labelPledget.AutoSize = true;
            labelPledget.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPledget.Location = new Point(43, 219);
            labelPledget.Name = "labelPledget";
            labelPledget.Size = new Size(85, 23);
            labelPledget.TabIndex = 49;
            labelPledget.Text = "Adress:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(43, 173);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(103, 23);
            labelTitle.TabIndex = 47;
            labelTitle.Text = "Surname:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(43, 126);
            labelType.Name = "labelType";
            labelType.Size = new Size(72, 23);
            labelType.TabIndex = 46;
            labelType.Text = "Name:";
            // 
            // adressLab
            // 
            adressLab.AutoSize = true;
            adressLab.Location = new Point(134, 217);
            adressLab.Name = "adressLab";
            adressLab.Size = new Size(33, 25);
            adressLab.TabIndex = 58;
            adressLab.Text = "___";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 308);
            label2.Name = "label2";
            label2.Size = new Size(204, 23);
            label2.TabIndex = 57;
            label2.Text = "Document number:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(381, 271);
            dataGridView1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(42, 63);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 60;
            label1.Text = "Client №";
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
            buttonEX.TabIndex = 61;
            buttonEX.Text = "X";
            buttonEX.UseVisualStyleBackColor = false;
            buttonEX.Click += buttonEX_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            button1.Font = new Font("Lucida Fax", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(41, 361);
            button1.Name = "button1";
            button1.Size = new Size(172, 27);
            button1.TabIndex = 65;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(852, 403);
            Controls.Add(button1);
            Controls.Add(buttonEX);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(adressLab);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(surnameLab);
            Controls.Add(docnumLab);
            Controls.Add(doctypelab);
            Controls.Add(nameLab);
            Controls.Add(ownerID);
            Controls.Add(labelPledget);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "ClientProfile";
            Text = "ClientProfile";
            Load += ClientProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idBox;
        private Label surnameLab;
        private Label docnumLab;
        private Label doctypelab;
        private Label nameLab;
        private Label ownerID;
        private Label labelPledget;
        private Label labelTitle;
        private Label labelType;
        private Label adressLab;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonEX;
        private Button button1;
    }
}