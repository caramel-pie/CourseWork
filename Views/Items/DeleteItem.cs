﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2_Lab1
{
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (DataBase.getInstance.DeleteItem(Int32.Parse(numBox.Text)) == 1)
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error");
            this.Close();
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
