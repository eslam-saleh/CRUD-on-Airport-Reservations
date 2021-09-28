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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void FLIGHTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fLIGHTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egypt_AirDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.egypt_AirDataSet.FLIGHT);
            // TODO: This line of code loads data into the 'egypt_AirDataSet.PLANE' table. You can move, or remove it, as needed.
            this.pLANETableAdapter.Fill(this.egypt_AirDataSet.PLANE);
            // TODO: This line of code loads data into the 'egypt_AirDataSet.PLANE' table. You can move, or remove it, as needed.
            this.pLANETableAdapter.Fill(this.egypt_AirDataSet.PLANE);
            // TODO: This line of code loads data into the 'egypt_AirDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.egypt_AirDataSet.FLIGHT);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }

        private void PLANEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pLANEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egypt_AirDataSet);

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }
    }
}
