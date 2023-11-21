using MySqlX.XDevAPI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Year2_Lab1
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            int pledget;
            bool isValidPledget = int.TryParse(pledgetBox.Text, out pledget);

            if (!string.IsNullOrEmpty(typeBox.Text) && !string.IsNullOrEmpty(titleBox.Text) && !string.IsNullOrEmpty(condBox.Text) && isValidPledget)
            {
                uint matid = uint.Parse(typeBox.Text.Split()[0]);
                Item item = new Item(matid, titleBox.Text, condBox.Text, pledget, int.Parse(Boxid.Text));
                int clientID = Convert.ToInt32(owBox.Text);
                Receipt receipt = new Receipt(DateTime.Now, dateTimePicker1.Value, pledget, clientID, int.Parse(Boxid.Text), pledget);
                if (DataBase.getInstance.UpdateItemData(item, receipt, clientID) == 1)
                {
                    this.Close();
                    MessageBox.Show("Success");
                    new ItemProfile().Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Please, fill in all the fields.");
            }

        }

        private void EditItem_Load(object sender, EventArgs e)
        {
            var materials = DataBase.getInstance.MaterialChoice();
            foreach (var material in materials)
            {
                typeBox.Items.Add(material.ToString());
            }
        }
    }
}
