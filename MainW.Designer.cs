namespace Year2_Lab1
{
    partial class MainW
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            addClientToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            itemToolStripMenuItem = new ToolStripMenuItem();
            deleteClientToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem1 = new ToolStripMenuItem();
            itemToolStripMenuItem1 = new ToolStripMenuItem();
            editClientToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem2 = new ToolStripMenuItem();
            itemToolStripMenuItem2 = new ToolStripMenuItem();
            showItemProfileToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem3 = new ToolStripMenuItem();
            itemToolStripMenuItem3 = new ToolStripMenuItem();
            clientsButton = new Button();
            itemsButton = new Button();
            SQLbutton = new Button();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, addClientToolStripMenuItem, deleteClientToolStripMenuItem, editClientToolStripMenuItem, showItemProfileToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Padding = new Padding(10, 10, 10, 0);
            menuToolStripMenuItem.Size = new Size(103, 41);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // addClientToolStripMenuItem
            // 
            addClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem, itemToolStripMenuItem });
            addClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            addClientToolStripMenuItem.Size = new Size(270, 34);
            addClientToolStripMenuItem.Text = "Add";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(270, 34);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // itemToolStripMenuItem
            // 
            itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            itemToolStripMenuItem.Size = new Size(270, 34);
            itemToolStripMenuItem.Text = "Item ";
            itemToolStripMenuItem.Click += itemToolStripMenuItem_Click;
            // 
            // deleteClientToolStripMenuItem
            // 
            deleteClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem1, itemToolStripMenuItem1 });
            deleteClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            deleteClientToolStripMenuItem.Size = new Size(270, 34);
            deleteClientToolStripMenuItem.Text = "Delete";
            // 
            // clientToolStripMenuItem1
            // 
            clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            clientToolStripMenuItem1.Size = new Size(270, 34);
            clientToolStripMenuItem1.Text = "Client";
            clientToolStripMenuItem1.Click += clientToolStripMenuItem1_Click;
            // 
            // itemToolStripMenuItem1
            // 
            itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            itemToolStripMenuItem1.Size = new Size(270, 34);
            itemToolStripMenuItem1.Text = "Item ";
            itemToolStripMenuItem1.Click += itemToolStripMenuItem1_Click;
            // 
            // editClientToolStripMenuItem
            // 
            editClientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem2, itemToolStripMenuItem2 });
            editClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            editClientToolStripMenuItem.Size = new Size(270, 34);
            editClientToolStripMenuItem.Text = "Edit";
            // 
            // clientToolStripMenuItem2
            // 
            clientToolStripMenuItem2.Name = "clientToolStripMenuItem2";
            clientToolStripMenuItem2.Size = new Size(270, 34);
            clientToolStripMenuItem2.Text = "Client";
            clientToolStripMenuItem2.Click += clientToolStripMenuItem2_Click;
            // 
            // itemToolStripMenuItem2
            // 
            itemToolStripMenuItem2.Name = "itemToolStripMenuItem2";
            itemToolStripMenuItem2.Size = new Size(270, 34);
            itemToolStripMenuItem2.Text = "Item";
            itemToolStripMenuItem2.Click += itemToolStripMenuItem2_Click;
            // 
            // showItemProfileToolStripMenuItem
            // 
            showItemProfileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem3, itemToolStripMenuItem3 });
            showItemProfileToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showItemProfileToolStripMenuItem.Name = "showItemProfileToolStripMenuItem";
            showItemProfileToolStripMenuItem.Size = new Size(270, 34);
            showItemProfileToolStripMenuItem.Text = "Show profile";
            showItemProfileToolStripMenuItem.Click += showItemProfileToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem3
            // 
            clientToolStripMenuItem3.Name = "clientToolStripMenuItem3";
            clientToolStripMenuItem3.Size = new Size(270, 34);
            clientToolStripMenuItem3.Text = "Client";
            clientToolStripMenuItem3.Click += clientToolStripMenuItem3_Click;
            // 
            // itemToolStripMenuItem3
            // 
            itemToolStripMenuItem3.Name = "itemToolStripMenuItem3";
            itemToolStripMenuItem3.Size = new Size(270, 34);
            itemToolStripMenuItem3.Text = "Item";
            itemToolStripMenuItem3.Click += itemToolStripMenuItem3_Click;
            // 
            // clientsButton
            // 
            clientsButton.Cursor = Cursors.Hand;
            clientsButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            clientsButton.FlatAppearance.BorderSize = 2;
            clientsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            clientsButton.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clientsButton.Location = new Point(265, 217);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(155, 55);
            clientsButton.TabIndex = 1;
            clientsButton.Text = "Clients";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // itemsButton
            // 
            itemsButton.Cursor = Cursors.Hand;
            itemsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            itemsButton.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            itemsButton.Location = new Point(265, 278);
            itemsButton.Name = "itemsButton";
            itemsButton.Size = new Size(155, 55);
            itemsButton.TabIndex = 2;
            itemsButton.Text = "Items";
            itemsButton.UseVisualStyleBackColor = true;
            itemsButton.Click += itemsButton_Click;
            // 
            // SQLbutton
            // 
            SQLbutton.Cursor = Cursors.Hand;
            SQLbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 179, 218);
            SQLbutton.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SQLbutton.Location = new Point(265, 339);
            SQLbutton.Name = "SQLbutton";
            SQLbutton.Size = new Size(319, 42);
            SQLbutton.TabIndex = 3;
            SQLbutton.Text = "Query";
            SQLbutton.UseVisualStyleBackColor = true;
            SQLbutton.Click += SQLbutton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Fax", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(429, 278);
            button1.Name = "button1";
            button1.Size = new Size(155, 55);
            button1.TabIndex = 4;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Fax", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(429, 217);
            button2.Name = "button2";
            button2.Size = new Size(151, 55);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainW
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(878, 544);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SQLbutton);
            Controls.Add(itemsButton);
            Controls.Add(clientsButton);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "MainW";
            Text = "Pawnshop";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button clientsButton;
        private Button itemsButton;
        private ToolStripMenuItem addClientToolStripMenuItem;
        private ToolStripMenuItem deleteClientToolStripMenuItem;
        private ToolStripMenuItem editClientToolStripMenuItem;
        private Button SQLbutton;
        private ToolStripMenuItem showItemProfileToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem1;
        private ToolStripMenuItem itemToolStripMenuItem1;
        private ToolStripMenuItem clientToolStripMenuItem2;
        private ToolStripMenuItem itemToolStripMenuItem2;
        private ToolStripMenuItem clientToolStripMenuItem3;
        private ToolStripMenuItem itemToolStripMenuItem3;
        private Button button2;
    }
}