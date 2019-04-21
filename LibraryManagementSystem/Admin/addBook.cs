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
	public partial class addBook : Form
	{
		searchBook sb;
		AdminForm af;
		//DataGridView dgv;
		public addBook()
		{
			InitializeComponent();
			sb = new searchBook(dgvBook);
		}

		SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void addBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'booksDataSet.books' table. You can move, or remove it, as needed.
			this.booksTableAdapter1.Fill(this.booksDataSet.books);
			// TODO: This line of code loads data into the 'books.books' table. You can move, or remove it, as needed.
			this.booksTableAdapter.Fill(this.books.books);
			listing();
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM books";
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "books");
				dgvBook.DataSource = ds.Tables["books"];
				connection.Close();
			}
		}

		public void clear()
		{
			txtBookName.Text = "";
			numPageCount.Value = 0;
			numPoint.Value = 0;
			numAuthorID.Value = 0;
			numTypeID.Value = 0;
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "INSERT INTO books(name,pagecount,point,authorId,typeId) " +
					"VALUES('" + txtBookName.Text + "','" + numPageCount.Value + "','" +
					numPoint.Value + "','" + numAuthorID.Value + "','" + numTypeID.Value + "')";
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
				cmd.CommandText = "UPDATE books SET name='" + txtBookName.Text +
					"',pagecount='" + numPageCount.Value + "',point='" + numPoint.Value +
					"',authorId='" + numAuthorID.Value + "',typeId='" + numTypeID.Value +
					"'WHERE bookId=@number";
				cmd.Parameters.AddWithValue("@number", dgvBook.CurrentRow.Cells[0].Value.ToString());
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
					cmd.CommandText = "DELETE FROM books WHERE bookId=@number";
					cmd.Parameters.AddWithValue("@number", dgvBook.CurrentRow.Cells[0].Value.ToString());
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
			numPageCount.Maximum = numPageCount.Maximum = numPageCount.Maximum =
				numPoint.Maximum = numAuthorID.Maximum = numTypeID.Maximum = int.MaxValue;
			//int index = Int32.Parse(e.ToString());
			txtBookName.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
			//numPageCount.Value = (int)dgvBook.CurrentRow.Cells[2].Value.ToString();
			numPageCount.Value = int.Parse(dgvBook.CurrentRow.Cells[2].Value.ToString());
			numPoint.Value = int.Parse(dgvBook.CurrentRow.Cells[3].Value.ToString());
			numAuthorID.Value = int.Parse(dgvBook.CurrentRow.Cells[4].Value.ToString());
			numTypeID.Value = int.Parse(dgvBook.CurrentRow.Cells[5].Value.ToString());
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}
		#region Focus
		private void txtBookName_Enter(object sender, EventArgs e)
		{
			if (txtBookName.Text == "<Enter Book Name>")
				txtBookName.Text = "";
		}

		private void txtBookName_Leave(object sender, EventArgs e)
		{
			if (txtBookName.Text.Trim() == "")
				txtBookName.Text = "<Enter Book Name>";
		}
		#endregion
	}
}