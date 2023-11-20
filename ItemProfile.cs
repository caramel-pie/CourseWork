using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year2_Lab1
{
    public partial class ItemProfile : Form
    {
        public ItemProfile()
        {
            InitializeComponent();
        }

        private void ItemProfile_Load(object sender, EventArgs e)
        {
            int itemID;
            bool parsed = int.TryParse(idBox.Text, out itemID);
            if (!parsed)
                itemID = 0;
            Item item = DataBase.getInstance.GetItem(itemID);
            if (item.id == 0)
                return;
            typeLab.Text = item.material_id.ToString();
            pledlab.Text = item.pledget.ToString();
            condLab.Text = item.condition.ToString();
            titleLab.Text = item.title;
            Receipt receipt = DataBase.getInstance.GetReceipt(itemID);
            Client client = DataBase.getInstance.GetClient(receipt.clientid);
            owLab.Text = client.ToString();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            ItemProfile_Load(sender, e);
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            int itemID;
            bool parsed = int.TryParse(idBox.Text, out itemID);
            var receipt = new DataBase().GetReceipt(itemID);
            Printer.TakeReceipt(receipt);
            MessageBox.Show("Done! Check the files.");
        }

        private void buttonEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditItem().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DeleteItem().Show();
        }
    }
}
