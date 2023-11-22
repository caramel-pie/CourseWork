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
            var matquery = new List<string>();
            var query = new List<string>();

            foreach (var material in matBox.CheckedItems)
            {
                matquery.Add((material as string).Split(" ")[0]);
            }
            if (matquery.Count > 0)
            {
                query.Add($"`material_id` IN ('{String.Join("' , '", matquery)}')");
            }
            var conquery = new List<string>();
            foreach (var condition in conBox.CheckedItems)
            {
                conquery.Add(condition as string);
            }
            if (conquery.Count > 0)
            {
                query.Add($"`condition` IN ('{String.Join("' , '", conquery)}')");
            }
            if (minpled.Text.Length > 0)
            {
                query.Add($"`pledget`>{minpled.Text}");
            }
            if (maxpled.Text.Length > 0)
            {
                query.Add($"`pledget`<{maxpled.Text}");
            }
            MessageBox.Show(String.Join(" AND ", query));
            var data = DataBase.getInstance.QueriesDataset($"SELECT * FROM `items` WHERE {String.Join(" AND ", query)}");
            dataGridView1.DataSource = data.Tables[0];
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataBase.getInstance.QueriesDataset($"SELECT * FROM `items` WHERE `title` LIKE '%{textBox.Text}%' OR `id`={textBox.Text}").Tables[0];
        }
    }
}
