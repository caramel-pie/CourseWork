using System.Linq.Expressions;
using Year2_Lab1.Views.Workers;

namespace Year2_Lab1
{
    public partial class MainA : Form
    {
        public MainA()
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

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddClient().Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddItem().Show();
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteClient().Show();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteItem().Show();
        }

        private void clientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditClient().Show();
        }

        private void itemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new EditItem().Show();
        }

        private void clientToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ClientProfile().Show();
        }

        private void itemToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ItemProfile().Show();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WorkerProfile().Show();
        }

        private void workerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EditWorker().Show();
        }

        private void workerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AddWorker().Show();
        }
    }
}