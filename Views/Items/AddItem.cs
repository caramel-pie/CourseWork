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
    public partial class AddItem : Form
    {
        public AddItem()
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
                Item item = new Item(matid, titleBox.Text, condBox.Text, pledget, 0);
                Receipt receipt = new Receipt(DateTime.Now, dateTimePicker1.Value, 0, 0, 0, 0);
                int clientID = Convert.ToInt32(idBox.Text);
                if (DataBase.getInstance.ClientPresent(clientID))
                {
                    DataBase.getInstance.CreateItem(item, clientID, receipt);
                    MessageBox.Show("Success");
                }
                else
                    MessageBox.Show("This client does not exists yet");

                new ItemProfile().Show();
            }
            else
            {
                MessageBox.Show("Please, fill in all the fields.");
            }
        }
        private void AddItem_Load(object sender, EventArgs e)
        {
            var materials = DataBase.getInstance.MaterialChoice();
            foreach (var material in materials)
            {
                typeBox.Items.Add(material.ToString());
            }
        }
    }
}
