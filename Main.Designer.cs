namespace Year2_Lab1
{
    partial class Main
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
            addItemToolStripMenuItem = new ToolStripMenuItem();
            deleteClientToolStripMenuItem = new ToolStripMenuItem();
            deleteItemToolStripMenuItem = new ToolStripMenuItem();
            editClientToolStripMenuItem = new ToolStripMenuItem();
            editItemToolStripMenuItem = new ToolStripMenuItem();
            showItemProfileToolStripMenuItem = new ToolStripMenuItem();
            showClientProfileToolStripMenuItem = new ToolStripMenuItem();
            clientsButton = new Button();
            itemsButton = new Button();
            SQLbutton = new Button();
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
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, addClientToolStripMenuItem, addItemToolStripMenuItem, deleteClientToolStripMenuItem, deleteItemToolStripMenuItem, editClientToolStripMenuItem, editItemToolStripMenuItem, showItemProfileToolStripMenuItem, showClientProfileToolStripMenuItem });
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
            exitToolStripMenuItem.Size = new Size(303, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // addClientToolStripMenuItem
            // 
            addClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            addClientToolStripMenuItem.Size = new Size(303, 34);
            addClientToolStripMenuItem.Text = "Add client";
            addClientToolStripMenuItem.Click += addClientToolStripMenuItem_Click;
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(303, 34);
            addItemToolStripMenuItem.Text = "Add item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // deleteClientToolStripMenuItem
            // 
            deleteClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            deleteClientToolStripMenuItem.Size = new Size(303, 34);
            deleteClientToolStripMenuItem.Text = "Delete client ";
            deleteClientToolStripMenuItem.Click += deleteClientToolStripMenuItem_Click;
            // 
            // deleteItemToolStripMenuItem
            // 
            deleteItemToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            deleteItemToolStripMenuItem.Size = new Size(303, 34);
            deleteItemToolStripMenuItem.Text = "Delete item";
            deleteItemToolStripMenuItem.Click += deleteItemToolStripMenuItem_Click;
            // 
            // editClientToolStripMenuItem
            // 
            editClientToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            editClientToolStripMenuItem.Size = new Size(303, 34);
            editClientToolStripMenuItem.Text = "Edit client";
            editClientToolStripMenuItem.Click += editClientToolStripMenuItem_Click;
            // 
            // editItemToolStripMenuItem
            // 
            editItemToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            editItemToolStripMenuItem.Size = new Size(303, 34);
            editItemToolStripMenuItem.Text = "Edit item";
            editItemToolStripMenuItem.Click += editItemToolStripMenuItem_Click;
            // 
            // showItemProfileToolStripMenuItem
            // 
            showItemProfileToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showItemProfileToolStripMenuItem.Name = "showItemProfileToolStripMenuItem";
            showItemProfileToolStripMenuItem.Size = new Size(303, 34);
            showItemProfileToolStripMenuItem.Text = "Show item profile";
            showItemProfileToolStripMenuItem.Click += showItemProfileToolStripMenuItem_Click;
            // 
            // showClientProfileToolStripMenuItem
            // 
            showClientProfileToolStripMenuItem.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            showClientProfileToolStripMenuItem.Name = "showClientProfileToolStripMenuItem";
            showClientProfileToolStripMenuItem.Size = new Size(303, 34);
            showClientProfileToolStripMenuItem.Text = "Show client profile";
            showClientProfileToolStripMenuItem.Click += showClientProfileToolStripMenuItem_Click;
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
            clientsButton.Size = new Size(149, 55);
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
            itemsButton.Location = new Point(429, 217);
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
            SQLbutton.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SQLbutton.Location = new Point(265, 278);
            SQLbutton.Name = "SQLbutton";
            SQLbutton.Size = new Size(319, 34);
            SQLbutton.TabIndex = 3;
            SQLbutton.Text = "SQL";
            SQLbutton.UseVisualStyleBackColor = true;
            SQLbutton.Click += SQLbutton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 105, 183);
            ClientSize = new Size(878, 544);
            Controls.Add(SQLbutton);
            Controls.Add(itemsButton);
            Controls.Add(clientsButton);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "Main";
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
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem deleteClientToolStripMenuItem;
        private ToolStripMenuItem deleteItemToolStripMenuItem;
        private ToolStripMenuItem editClientToolStripMenuItem;
        private ToolStripMenuItem editItemToolStripMenuItem;
        private Button SQLbutton;
        private ToolStripMenuItem showItemProfileToolStripMenuItem;
        private ToolStripMenuItem showClientProfileToolStripMenuItem;
    }
}