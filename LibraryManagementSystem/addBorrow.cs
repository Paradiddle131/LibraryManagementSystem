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

namespace LibraryManagementSystem
{
	public partial class addBorrow : Form
	{
		dbForLMS.Checkout checkout = new dbForLMS.Checkout();
		public addBorrow()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(dbForLMS.Checkout.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			checkout.Show();
		}
		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM borrows";
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "borrows");
				dgvBorrow.DataSource = ds.Tables["borrows"];
				connection.Close();
			}
		}

		public void clear()
		{
			nudStudentID.Value = 0;
			nudBookID.Value = 0;
			dtpTakenDate.Text = "01 / 01 / 1900";
			dtpBroughtDate.Text = "01 / 01 / 1900";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "INSERT INTO borrows(studentId,bookId,takenDate,broughtDate) " +
					"VALUES('" + nudStudentID.Value + "','" + nudBookID.Value + "','" +
					dtpTakenDate.Text + "','" + dtpBroughtDate.Text + "')";
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				listing(); // must be called after the connection closed
				MessageBox.Show("Added.");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "UPDATE borrows SET borrowId='" + nudStudentID.Value +
					"',bookId='" + nudBookID.Value + "',takenDate='" + dtpTakenDate.Text +
					"',broughtDate='" + dtpBroughtDate.Text +
					"'WHERE borrowId=@number";
				cmd.Parameters.AddWithValue("@number", dgvBorrow.CurrentRow.Cells[0].Value.ToString());
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				MessageBox.Show("Edited.");
				clear();
				listing();
			}
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
					cmd.CommandText = "DELETE FROM borrows WHERE borrowId=@number";
					cmd.Parameters.AddWithValue("@number", dgvBorrow.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			nudStudentID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[1].Value.ToString());
			nudBookID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[2].Value.ToString());
			dtpTakenDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[3].Value.ToString());
			dtpBroughtDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[4].Value.ToString());
		}

		private void addBorrow_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'borrowsDataSet.borrows' table. You can move, or remove it, as needed.
			this.borrowsTableAdapter.Fill(this.borrowsDataSet.borrows);

		}
	}
}
