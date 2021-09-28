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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
  
        }

        private void ShowPassenger_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.PASSENGER' table. You can move, or remove it, as needed.
            this.pASSENGERTableAdapter.Fill(this.egypt_AirDataSet.PASSENGER);
        }

        private void InsertPassenger_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            if (radioButton1.Checked)
                sqlCommand.CommandText = "INSERT INTO PASSENGER VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','Male','" + textBox6.Text + "')";
            else
                sqlCommand.CommandText = "INSERT INTO PASSENGER VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','Female','" + textBox6.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion a Passenger is Successfully Completed !");
        }

        private void UpdatePassenger_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            if (radioButton1.Checked)
                sqlCommand.CommandText = "Update PASSENGER SET PASSPORT_ID = '" + textBox1.Text + "' , FLIGHT_NO = '" + textBox2.Text + "' , SOURCE = '" + textBox3.Text + "' ,DESTINATION = '" + textBox4.Text + "' , FIRST_NAME = '" + textBox5.Text + "' ,SEX = 'Male', PHONE = '" + textBox6.Text + "'  WHERE PASSPORT_ID = '" + textBox1.Text + "'";
            else
                sqlCommand.CommandText = "Update PASSENGER SET PASSPORT_ID = '" + textBox1.Text + "' , FLIGHT_NO = '" + textBox2.Text + "' , SOURCE = '" + textBox3.Text + "' ,DESTINATION = '" + textBox4.Text + "' , FIRST_NAME = '" + textBox5.Text + "' ,SEX = 'Female', PHONE = '" + textBox6.Text + "'  WHERE PASSPORT_ID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updating a Passenger is Successfully Completed !");
        }

        private void DeletePassenger_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM PASSENGER WHERE PASSPORT_ID = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion a Passenger is Successfully Completed !");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Show();
            this.Hide();
        }
    }
}
