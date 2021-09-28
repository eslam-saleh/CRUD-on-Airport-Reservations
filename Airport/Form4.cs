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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        
        }

        private void InsertFlight_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            if (checkBox1.CheckState == CheckState.Checked)
                sqlCommand.CommandText = "INSERT INTO FLIGHT VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',1)";
            else
                sqlCommand.CommandText = "INSERT INTO FLIGHT VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',0)";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion a Flight is Successfully Completed !");

        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            if (checkBox1.CheckState == CheckState.Checked)
                sqlCommand.CommandText = "Update FLIGHT SET FLIGHT_NO = '" + textBox1.Text + "' , MODEL_NO = '" + textBox2.Text + "' , _From = '" + textBox3.Text + "' ,_To = '" + textBox4.Text + "' , _Time = '" + textBox5.Text + "' , IS_STOP = 1  WHERE FLIGHT_NO = '" + textBox1.Text + "'";
            else
                sqlCommand.CommandText = "Update FLIGHT SET FLIGHT_NO = '" + textBox1.Text + "' , MODEL_NO = '" + textBox2.Text + "' , _From = '" + textBox3.Text + "' ,_To = '" + textBox4.Text + "' , _Time = '" + textBox5.Text + "' , IS_STOP = 0  WHERE FLIGHT_NO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updating a Flight is Successfully Completed !");

        }

        private void DeleteFlight_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM FLIGHT WHERE FLIGHT_NO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion a Flight is Successfully Completed !");

        }

        private void ShowFlight_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.egypt_AirDataSet.FLIGHT);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void JoinFlights_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            this.Hide();
        }

        private void OperationsFlights_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Show();
            this.Hide();
        }
    }
}
