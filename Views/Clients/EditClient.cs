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
using Year2_Lab1.Utils;

namespace Year2_Lab1
{
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int age;
            bool isValidAge = int.TryParse(ageBar.Text, out age);
            bool corrName = !string.IsNullOrEmpty(nameBox.Text);
            bool corrSur = !string.IsNullOrEmpty(surnameBox.Text);

            if (corrName && corrSur && isValidAge)
            {
                Client client = new Client(nameBox.Text, surnameBox.Text, age, docBox.Text, int.Parse(numBox.Text), adressBox.Text, int.Parse(idBox.Text));
                if (DataBase.getInstance.UpdateClientData(client) == 1)
                {
                    this.Close();
                    MessageBox.Show("Success");
                    new ClientProfile().Show();
                }
            }
            else
                MessageBox.Show("Please, enter valid data.");
        }
    }
}
