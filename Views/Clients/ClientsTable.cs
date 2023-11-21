using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Year2_Lab1.Utils;

namespace Year2_Lab1
{
    public partial class ClientsTable : Form
    {
        public ClientsTable()
        {
            InitializeComponent();
        }

        private void ClientsTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.getInstance.LoadClientDataset().Tables[0];
            dataGridView2.DataSource = DataBase.getInstance.LoadItemDataset().Tables[0];
            dataGridView3.DataSource = DataBase.getInstance.LoadReceiptDataset().Tables[0];
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
