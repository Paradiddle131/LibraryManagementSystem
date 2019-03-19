using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
	public partial class IssueUserControl : UserControl
	{
		public IssueUserControl()
		{
			InitializeComponent();
		}

		private const string ConnectionString = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=libraryDB;Integrated Security=True";
		SqlConnection connection = new SqlConnection(ConnectionString);


		void clear()
		{
			txtName.Text = "";
			txtSurname.Text = "";
			txtBookName.Text = "";
			txtAuthor.Text = "";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
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
				listing(); // must be called after the connection closed
				MessageBox.Show("Added.");
			}
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM BookIssueTable";
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "BookIssueTable");
				dataGridView1.DataSource = ds.Tables["BookIssueTable"];
				//dataGridView1.Columns[0].Visible = false; // hides ID column
				connection.Close();
			}
		}

		private void IssueUserControl_load(object sender, EventArgs e)
		{
			listing();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete?", "Hold On!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
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

		private static IssueUserControl _instance;
		public IssueUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new IssueUserControl();
				return _instance;
			}
		}

		private void bookIssueTableBindingSource1_CurrentChanged(object sender, EventArgs e)
		{

		}
	}
	}
}
