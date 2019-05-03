using dbForLMS;
using LibraryManagementSystem.User;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class searchBook : Form
	{
		private readonly LollipopTextBox stuName;
		private readonly LollipopTextBox stuSurname;
		private readonly Label nameLabel;
		private readonly Label surnameLabel;
		public searchBook(LollipopTextBox stuName, LollipopTextBox stuSurname)
		{
			InitializeComponent();
		}
		public searchBook(Label nameLabel, Label surnameLabel)
		{
			InitializeComponent();
		}

		public searchBook()
		{
			InitializeComponent();
		}

		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void listing()
		{
			connection.Open();
			SqlCommand cmd = new SqlCommand
			{
				Connection = connection,
				CommandText = "SELECT * FROM library.dbo.userSearchView"
			};
			SqlDataAdapter adpr = new SqlDataAdapter(cmd);
			//DataSet ds = new DataSet();
			connection.Close();
		}
		private void BtnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//UserForm uf = new UserForm();
			//uf.Show();
		}

		private void SearchBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'userSearchDataSet.userSearchView' table. You can move, or remove it, as needed.
			userSearchViewTableAdapter.Fill(userSearchDataSet.userSearchView);
		}
		#region Search ToolStrip Buttons
		private void SearchAuthorNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchAuthorName(userSearchDataSet.userSearchView, authorNameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchAuthorSurnameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchAuthorSurname1(userSearchDataSet.userSearchView, authorSurnameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchBookNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchBookName1(userSearchDataSet.userSearchView, bookNameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchCategoryToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.SearchCategory(userSearchDataSet.userSearchView, categoryToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}

		private void ResetFilterToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				userSearchViewTableAdapter.ResetFilters(userSearchDataSet.userSearchView);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			authorNameToolStripTextBox.Text = "";
			authorSurnameToolStripTextBox.Text = "";
			bookNameToolStripTextBox.Text = "";
			categoryToolStripTextBox.Text = "";
		}
		#endregion
		private void DgvBookForBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//string bookid = "labeldefault";
			//if (dgvBookForBorrow.CurrentRow.Cells[1].Value.ToString() ==
			//	dgvSearch.CurrentRow.Cells[2].Value.ToString())
			//{
			//	bookid = dgvBookForBorrow.CurrentRow.Cells[0].Value.ToString();
			//}
			//label1.Text = bookid;
			//if (dgvBookForBorrow.CurrentRow.Cells[0].Value.ToString() ==
			//	dgv.CurrentRow.Cells[1].Value.ToString())
			//{
			//	studentid = dgv.CurrentRow.Cells[1].Value.ToString();
			//}

		}

		public string[] getNames()
		{
			return new string
		}

		private void BtnBorrow_Click(object sender, EventArgs e)
		{
			addBook abook = new addBook();
			abook.addBook_Load(sender, e);

			string thisAuthorName = dgvSearch.CurrentRow.Cells[0].Value.ToString();
			string thisAuthorSurname = dgvSearch.CurrentRow.Cells[1].Value.ToString();
			string thisBookName = dgvSearch.CurrentRow.Cells[2].Value.ToString();
			string thisCategory = dgvSearch.CurrentRow.Cells[3].Value.ToString();

			int bookId = abook.getBookId(thisBookName);

			UserProfile up = new UserProfile();
			Login login = new Login();
			UserForm uf = new UserForm();


			foreach (DataGridViewRow searchRow in dgvSearch.Rows)
			{
				foreach (DataGridViewRow userRow in up.dgvBorrowDisplay.Rows)
				{
					userRow.Cells[0].Value = login.txtName.Text; // Student Name
					userRow.Cells[1].Value = login.txtSurname.Text; // Student Surname
					userRow.Cells[2].Value = thisBookName; // Book Name
					userRow.Cells[3].Value = thisAuthorName; // Author Name
					userRow.Cells[4].Value = thisAuthorSurname; // Author Surname
					userRow.Cells[5].Value = DateTime.Now; // Borrow Date
					userRow.Cells[6].Value = DateTime.Now.AddDays(21); // Return Date
				}
			}

			if (connection.State == ConnectionState.Closed)
			{
				int count = 0; // Trigger should be created only once.
				connection.Open();
				if (count == 0)
				{
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText =
						"Insert Into userBorrowView(" +
						"studentName, studentSurname, bookName, authorName, authorSurname, " +
						"takenDate, broughtDate" +
						") " +
						"values('" + login.GetNameAndSurname() + "','" + surnameLabel.Text + "','" + thisBookName + "','" +
						thisAuthorName + "','" + thisAuthorSurname + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + DateTime.Now.AddDays(21).ToString("yyyy/MM/dd") +
						"') " +
						"OPTION (QUERYTRACEON 460); " +
						"DBCC TRACEOFF(460, -1); "
					};
					count++;
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					//MessageBox.Show("Borrowed", "Borrow Successful");
					listing(); // must be called after the connection closed
				}
				else
				{
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText =
						"Insert Into userBorrowView( " +
						"studentName, studentSurname, bookName, authorName, authorSurname, " +
						"takenDate, broughtDate " +
						") " +
						"values( " +
						"'addedName','addedSurname','addedBookName','addedAuthorName','addedAuthorSurname', " +
						"'2019-01-01','2019-01-22' " +
						") " +
						"OPTION (QUERYTRACEON 460); " +
						"DBCC TRACEOFF(460, -1); "
					};
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					//MessageBox.Show("Borrowed", "Borrow Successful");
					listing(); // must be called after the connection closed
				}
			}
		}
	}
}
