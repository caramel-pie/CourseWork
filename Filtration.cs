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
    public partial class Filtration : Form
    {
        public Filtration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Filtration_Load(object sender, EventArgs e)
        {
            var materials = DataBase.getInstance.MaterialChoice();
            foreach (var material in materials)
            {
                matBox.Items.Add(material.ToString());
            }
            var conditions = DataBase.getInstance.GetConditions();
            foreach (var condition in conditions)
            {
                conBox.Items.Add(condition.ToString());
            }
        }
    }
}
