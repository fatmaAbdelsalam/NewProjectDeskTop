using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskApp
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodesDefinition codesDefinition = new CodesDefinition();
            this.Hide();
            codesDefinition.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperationsPage operationsPage = new OperationsPage();
            this.Hide();
            operationsPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search searchPage = new Search();
            this.Hide();
            searchPage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PaiedPage paiedPage = new PaiedPage();
            this.Hide();
            paiedPage.Show();
        }
    }
}
