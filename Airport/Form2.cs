using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void InsertStaff_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO STAFF VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion a Staff is Successfully Completed !");
        }

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.egypt_AirDataSet.STAFF);
        }

        private void UpdateStaff_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update STAFF SET SSN = '" + textBox1.Text + "' , ADDRESS = '" + textBox2.Text + "' , YEARS_WORK = '" + textBox3.Text + "' ,SALARY = '" + textBox4.Text + "' , HOME_TWON = '" + textBox5.Text + "' , FIRST_NAME = '" + textBox6.Text + "' , POSITION = '" + textBox7.Text + "' WHERE SSN = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updating a Staff is Successfully Completed !");

        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM STAFF WHERE SSN = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion a Staff is Successfully Completed !");

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Planes_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }

        private void Flights_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form8 F8 = new Form8();
            F8.Show();
            this.Hide();
        }
    }
}
