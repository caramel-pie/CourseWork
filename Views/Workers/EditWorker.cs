﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year2_Lab1.Models;

namespace Year2_Lab1.Views.Workers
{
    public partial class EditWorker : Form
    {
        public EditWorker()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int depid = int.Parse(depBox.Text.Split()[0]);
            Worker worker = new Worker(nameBox.Text, surnameBox.Text, birthTime.Value, numBox.Text, phoneBox.Text, emailBox.Text, adressBox.Text, cardBox.Text, 1, passBox.Text, depid, int.Parse(Boxid.Text.ToString()));
            if (DataBase.getInstance.UpdateWorker(worker) == 1)
            {
                MessageBox.Show("Success");
                new WorkerProfile().Show();
            }
        }

        private void EditWorker_Load(object sender, EventArgs e)
        {
            var departments = DataBase.getInstance.DepartmentChoice();
            foreach (var department in departments)
            {
                depBox.Items.Add(department.ToString());
            }
        }
    }
}
