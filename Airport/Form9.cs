using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Egypt_AirDataSet.PASSENGER' table. You can move, or remove it, as needed.
            this.PASSENGERTableAdapter.Fill(this.Egypt_AirDataSet.PASSENGER);

            this.reportViewer1.RefreshReport();
        }
    }
}
