using System;
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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void ageBar_Validating_1(object sender, CancelEventArgs e)
        {
            int age;
            if (!int.TryParse(ageBar.Text, out age) || age < 18)
            {
                MessageBox.Show("Age must be 18 or above.");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client client = new Client(nameBox.Text, surnameBox.Text, 0, docBox.Text, int.Parse(numBox.Text.ToString()), adressBox.Text, 0);
            int age;
            bool isValidAge = int.TryParse(ageBar.Text, out age);
            client.age = age;
            if (!string.IsNullOrEmpty(client.name) && !string.IsNullOrEmpty(client.surname) && isValidAge)
            {
                if (DataBase.getInstance.CreateClient(client) == 1)
                    MessageBox.Show("Success");
                //new ClientProfile().Show();
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Please, fill in all the fields.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new AddItem().Show();
        }
    }
}
