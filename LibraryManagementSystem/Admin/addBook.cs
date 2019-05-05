using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class addBook : Form
	{
		//public DataGridView dbook { get { return dgvBook; } } // used => instead
		public DataGridView dbook => dgvBook;
		public DataGridViewRow drbook => dgvBook.CurrentRow;

		private readonly searchBook sb;
		private readonly AdminForm af;
		//DataGridView dgv;
		public addBook()
		{
			InitializeComponent();
			//sb = new searchBook(dgvBook);
			sb = new searchBook();
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		public void addBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'booksDataSet.books' table. You can move, or remove it, as needed.
			//booksTableAdapter.Fill(booksDataSet.books);
			// TODO: This line of code loads data into the 'booksDataSet.books' table. You can move, or remove it, as needed.
			booksTableAdapter.Fill(booksDataSet.books);
			listing();
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "SELECT DISTINCT * FROM books"
				};
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
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO books(bookName,pagecount,point,authorId,typeId) " +
					"VALUES('" + txtBookName.Text + "','" + numPageCount.Value + "','" +
					numPoint.Value + "','" + numAuthorID.Value + "','" + numTypeID.Value + "')"
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
					CommandText = "UPDATE books SET bookName='" + txtBookName.Text +
					"',pagecount='" + numPageCount.Value + "',point='" + numPoint.Value +
					"',authorId='" + numAuthorID.Value + "',typeId='" + numTypeID.Value +
					"'WHERE bookId=@number"
				};
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
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText = "DELETE FROM books WHERE bookId=@number"
					};
					cmd.Parameters.AddWithValue("@number", dgvBook.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		public int GetBookId(string bookname)
		{// if the method declared AFTER the listing() method, call listing();
			int rowIndex = -1;
			foreach (DataGridViewRow row in dgvBook.Rows)
			{// if the Rows has 0 item, dgv may not be public
				if (row.Cells[1].Value.ToString().Equals(bookname))
				{
					rowIndex = row.Index;
					//MessageBox.Show(int.Parse(row.Cells[0].Value.ToString()).ToString());
					return int.Parse(dgvBook.Rows[rowIndex].Cells[0].Value.ToString());
				}
			}

			MessageBox.Show("Couldn't return the book id correctly.", "Error");
			return -1;

			//searchBook sb = new searchBook();
			////if (bookname == dgvBook.CurrentRow.Cells[1].Value.ToString())
			//if ()
			//{
			//	MessageBox.Show(int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString()).ToString());
			//	return int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString());
			//}
			//else
			//{
			//	MessageBox.Show("Couldn't return the authorname correctly.", "Error");
			//	return -1;
			//}
		}

		public int GetQuantity(string bookname)
		{
			foreach (DataGridViewRow row in dgvBook.Rows)
			{
				if (row.Cells[1].Value.ToString() == bookname)
				{
					return int.Parse(row.Cells[6].Value.ToString());
				}
			}
			return -1;
		}

		private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvBook.CurrentCell.Value != DBNull.Value && dgvBook.CurrentRow.Cells[0].Value != DBNull.Value &&
					dgvBook.CurrentRow.Cells[1].Value != DBNull.Value && dgvBook.CurrentRow.Cells[2].Value != DBNull.Value &&
					dgvBook.CurrentRow.Cells[3].Value != DBNull.Value && dgvBook.CurrentRow.Cells[4].Value != DBNull.Value &&
					dgvBook.CurrentRow.Cells[5].Value != DBNull.Value)
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
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}
		#region Focus
		private void txtBookName_Enter(object sender, EventArgs e)
		{
			if (txtBookName.Text == "<Enter Book Name>")
			{
				txtBookName.Text = "";
			}
		}

		private void txtBookName_Leave(object sender, EventArgs e)
		{
			if (txtBookName.Text.Trim() == "")
			{
				txtBookName.Text = "<Enter Book Name>";
			}
		}
		#endregion
	}
}