using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbForLMS
{
	public partial class Form1 : Form
	{
		private const string ConnectionString = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True";
		SqlConnection connection = new SqlConnection(ConnectionString);
		public Form1()
		{
			InitializeComponent();
		}

		void clear()
		{
			txtName.Text = "";
			txtSurname.Text = "";
			txtBookName.Text = "";
			txtAuthor.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "INSERT INTO BookIssueTable(StudentName,Surname,BookName,BookAuthor) VALUES('" + txtName.Text + "','" + txtSurname.Text + "','" + 
					txtBookName.Text + "','" + txtAuthor.Text + "')";
				//cmd.CommandText = "INSERT INTO BookIssueTable(Name,Surname,Book Name,Book Author,Issue Date,Return Date) VALUES('" + txtName + "','" + txtSurname + "','" + 
				//txtBookName + "','" + txtAuthor + "')";
				//cmd.CommandText = "INSERT INTO BookIssueTable(ItemID,ItemName) VALUES (@ItemIDss,@Namess)";
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				listing();
				MessageBox.Show("Added.");
			}
		}

		void listing()
		{
			if(connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM BookIssueTable";
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "BookIssueTable");
				dataGridView1.DataSource = ds.Tables["BookIssueTable"];
 //				dataGridView1.Columns[0].Visible = false; // hides ID column
				connection.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listing();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to delete?","Hold On!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = connection;
					cmd.CommandText = "DELETE FROM BookIssueTable WHERE ID=@number";
					cmd.Parameters.AddWithValue("@number", dataGridView1.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					//MessageBox.Show("Deleted.");
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "UPDATE BookIssueTable SET StudentName='" + txtName.Text + "',Surname='" + txtSurname.Text + "',BookName='" + txtBookName.Text + "',BookAuthor='" + txtAuthor.Text + "'WHERE ID=@number";
				cmd.Parameters.AddWithValue("@number", dataGridView1.CurrentRow.Cells[0].Value.ToString());
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				MessageBox.Show("Edited.");
				clear();
				listing();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			txtBookName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtAuthor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
		}
	}
}
