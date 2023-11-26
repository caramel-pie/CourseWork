using System;
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
    public partial class WorkerProfile : Form
    {
        public WorkerProfile()
        {
            InitializeComponent();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            WorkerProfile_Load(sender, e);
        }

        private void WorkerProfile_Load(object sender, EventArgs e)
        {
            int workerID;
            bool parsed = int.TryParse(idBox.Text, out workerID);
            if (!parsed)
                workerID = 0;
            Worker worker = DataBase.getInstance.GetWorker(workerID);
            if (worker.id == 0)
                return;
            nameLab.Text = worker.name;
            surnameLab.Text = worker.surname;
            adressLab.Text = worker.adress;
            posLab.Text = worker.position.ToString();
            emaillab.Text = worker.email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataBase.getInstance.FireWorker(Int32.Parse(idBox.Text)) == 1)
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error");
            this.Close();
        }
    }
}
