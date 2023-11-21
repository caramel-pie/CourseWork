using System.Linq.Expressions;

namespace Year2_Lab1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            new ClientsTable().Show();
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            new ItemsTable().Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddClient().Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddItem().Show();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteClient().Show();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteItem().Show();
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditClient().Show();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditItem().Show();
        }

        private void SQLbutton_Click(object sender, EventArgs e)
        {
            new Queries().Show();
        }

        private void showItemProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ItemProfile().Show();
        }

        private void showClientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ClientProfile().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Filtration().Show();
        }
    }
}