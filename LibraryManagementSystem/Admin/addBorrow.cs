using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class addBorrow : Form
	{
		private readonly searchBook sb;
		private readonly AdminForm af;
		public addBorrow()
		{
			InitializeComponent();
			sb = new searchBook(dgvBorrow);
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}
		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "SELECT * FROM borrows"
				};
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
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO borrows(studentId,bookId,takenDate,broughtDate) " +
					"VALUES('" + nudStudentID.Value + "','" + nudBookID.Value + "','" +
					dtpTakenDate.Text + "','" + dtpBroughtDate.Text + "')"
				};
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
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "UPDATE borrows SET borrowId='" + nudStudentID.Value +
					"',bookId='" + nudBookID.Value + "',takenDate='" + dtpTakenDate.Text +
					"',broughtDate='" + dtpBroughtDate.Text +
					"'WHERE borrowId=@number"
				};
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
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText = "DELETE FROM borrows WHERE borrowId=@number"
					};
					cmd.Parameters.AddWithValue("@number", dgvBorrow.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		private void addBorrow_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'borrowsDataSet.borrows' table. You can move, or remove it, as needed.
			borrowsTableAdapter.Fill(borrowsDataSet.borrows);

		}

		private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (dgvBorrow.SelectedCells.Contains(null)) return;
			if (dgvBorrow.CurrentCell.Value == null)
			{
				return;
			}
			//nudStudentID.Maximum = nudBookID.Maximum = 9999;
			nudStudentID.Maximum = nudBookID.Maximum = int.MaxValue;
			// Default range of the numeric up down properties is [0,100] and this causes an "ArgumentOutOfRangeException" 
			// when the user clicks a cell which contains a value out of the range. 
			// Therefore, we had to set the maximum value as higher like 9999.
			nudStudentID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[1].Value.ToString());
			nudBookID.Value = int.Parse(dgvBorrow.CurrentRow.Cells[2].Value.ToString());
			dtpTakenDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[3].Value.ToString());
			dtpBroughtDate.Value = Convert.ToDateTime(dgvBorrow.CurrentRow.Cells[4].Value.ToString());
			dgvBorrow.PerformLayout();
		}
	}
}
