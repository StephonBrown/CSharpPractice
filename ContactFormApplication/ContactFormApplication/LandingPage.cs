using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactFormApplication
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.contactDBDataSet.Person);
            // TODO: This line of code loads data into the 'contactDBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.contactDBDataSet.Person);

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a picture.\nI have no idea what it is from.", "About");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void personBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
