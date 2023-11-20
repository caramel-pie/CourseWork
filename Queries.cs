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
    public partial class Queries : Form
    {
        public Queries()
        {
            InitializeComponent();
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBase.getInstance.QueriesDataset(SQLBox.Text).Tables[0];
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
