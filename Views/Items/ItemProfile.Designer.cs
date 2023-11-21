namespace Year2_Lab1
{
    partial class ItemProfile
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
            ownerID = new Label();
            labelPledget = new Label();
            labelCond = new Label();
            labelTitle = new Label();
            labelType = new Label();
            typeLab = new Label();
            pledlab = new Label();
            owLab = new Label();
            condLab = new Label();
            titleLab = new Label();
            idBox = new TextBox();
            buttonReceipt = new Button();
            label1 = new Label();
            buttonEX = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ownerID
            // 
            ownerID.AutoSize = true;
            ownerID.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ownerID.Location = new Point(49, 312);
            ownerID.Name = "ownerID";
            ownerID.Size = new Size(124, 23);
            ownerID.TabIndex = 39;
            ownerID.Text = "Owner's id:";
            // 
            // labelPledget
            // 
            labelPledget.AutoSize = true;
            labelPledget.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPledget.Location = new Point(49, 267);
            labelPledget.Name = "labelPledget";
            labelPledget.Size = new Size(90, 23);
            labelPledget.TabIndex = 34;
            labelPledget.Text = "Pledget:";
            // 
            // labelCond
            // 
            labelCond.AutoSize = true;
            labelCond.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCond.Location = new Point(49, 220);
            labelCond.Name = "labelCond";
            labelCond.Size = new Size(117, 23);
            labelCond.TabIndex = 33;
            labelCond.Text = "Condition:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(49, 176);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(63, 23);
            labelTitle.TabIndex = 32;
            labelTitle.Text = "Title:";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelType.Location = new Point(49, 129);
            labelType.Name = "labelType";
            labelType.Size = new Size(66, 23);
            labelType.TabIndex = 31;
            labelType.Text = "Type:";
            // 
            // typeLab
            // 
            typeLab.AutoSize = true;
            typeLab.Location = new Point(121, 129);
            typeLab.Name = "typeLab";
            typeLab.Size = new Size(33, 25);
            typeLab.TabIndex = 40;
            typeLab.Text = "___";
            // 
            // pledlab
            // 
            pledlab.AutoSize = true;
            pledlab.Location = new Point(145, 265);
            pledlab.Name = "pledlab";
            pledlab.Size = new Size(33, 25);
            pledlab.TabIndex = 41;
            pledlab.Text = "___";
            // 
            // owLab
            // 
            owLab.AutoSize = true;
            owLab.Location = new Point(179, 311);
            owLab.Name = "owLab";
            owLab.Size = new Size(33, 25);
            owLab.TabIndex = 42;
            owLab.Text = "___";
            // 
            // condLab
            // 
            condLab.AutoSize = true;
            condLab.Location = new Point(170, 219);
            condLab.Name = "condLab";
            condLab.Size = new Size(33, 25);
            condLab.TabIndex = 43;
            condLab.Text = "___";
            // 
            // titleLab
            // 
            titleLab.AutoSize = true;
            titleLab.Location = new Point(121, 174);
            titleLab.Name = "titleLab";
            titleLab.Size = new Size(33, 25);
            titleLab.TabIndex = 44;
            titleLab.Text = "___";
            // 
            // idBox
            // 
            idBox.Location = new Point(154, 63);
            idBox.Name = "idBox";
            idBox.Size = new Size(150, 31);
            idBox.TabIndex = 45;
            idBox.TextChanged += idBox_TextChanged;
            // 
            // buttonReceipt
            // 
            buttonReceipt.Cursor = Cursors.Hand;
            buttonReceipt.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            buttonReceipt.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReceipt.Location = new Point(49, 355);
            buttonReceipt.Name = "buttonReceipt";
            buttonReceipt.Size = new Size(172, 31);
            buttonReceipt.TabIndex = 46;
            buttonReceipt.Text = "Print receipt";
            buttonReceipt.UseVisualStyleBackColor = true;
            buttonReceipt.Click += buttonReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(49, 66);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 61;
            label1.Text = "Item №";
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
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            button1.Font = new Font("Lucida Fax", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(49, 392);
            button1.Name = "button1";
            button1.Size = new Size(172, 27);
            button1.TabIndex = 63;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ItemProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(475, 443);
            Controls.Add(button1);
            Controls.Add(buttonEX);
            Controls.Add(label1);
            Controls.Add(buttonReceipt);
            Controls.Add(idBox);
            Controls.Add(titleLab);
            Controls.Add(condLab);
            Controls.Add(owLab);
            Controls.Add(pledlab);
            Controls.Add(typeLab);
            Controls.Add(ownerID);
            Controls.Add(labelPledget);
            Controls.Add(labelCond);
            Controls.Add(labelTitle);
            Controls.Add(labelType);
            Name = "ItemProfile";
            Text = "ItemProfile";
            Load += ItemProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ownerID;
        private Label labelPledget;
        private Label labelCond;
        private Label labelTitle;
        private Label labelType;
        private Label typeLab;
        private Label pledlab;
        private Label owLab;
        private Label condLab;
        private Label titleLab;
        private TextBox idBox;
        private Button buttonReceipt;
        private Label label1;
        private Button buttonEX;
        private Button button1;
    }
}