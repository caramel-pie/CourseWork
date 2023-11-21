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
    public partial class ClientProfile : Form
    {
        public ClientProfile()
        {
            InitializeComponent();
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            int id;
            bool parsed = int.TryParse(idBox.Text, out id);
            if (!parsed)
                id = 0;
            Client client = DataBase.getInstance.GetClient(id);
            if (client.id == 0)
                return;
            nameLab.Text = client.name;
            surnameLab.Text = client.surname;
            adressLab.Text = client.adress;
            docnumLab.Text = client.docnum.ToString();
            doctypelab.Text = client.doctype.ToString();

            dataGridView1.DataSource = DataBase.getInstance.ClientsItems((uint)id).Tables[0];
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            ClientProfile_Load(sender, e);
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditClient().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DeleteClient().Show();
        }
    }
}
