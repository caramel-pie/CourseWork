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
    public partial class ItemsTable : Form
    {
        public ItemsTable()
        {
            InitializeComponent();
        }

        private void ItemsTable_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.getInstance.LoadItemDataset().Tables[0];
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
