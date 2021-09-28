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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void FLIGHTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fLIGHTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egypt_AirDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.egypt_AirDataSet.FLIGHT);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }
    }
}
