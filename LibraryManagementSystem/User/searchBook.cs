using dbForLMS;
using LibraryManagementSystem.User;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class searchBook : Form
	{
		public string firstname = "";
		public string lastname = "";
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

		private void BtnBorrow_Click(object sender, EventArgs e)
		{
			addStudent astudent = new addStudent();
			astudent.addStudent_Load(sender, e); // dgv won't load in the background without this line
			addBook abook = new addBook();
			abook.addBook_Load(sender, e); // won't be able to reach if you forget making it public

			string fullNameInput = Interaction.InputBox("Enter your full name please:", "Your Full Name.", "");
			StartPosition = FormStartPosition.CenterScreen;
			//MessageBox.Show("Full Name is: " + fullNameInput);
			string[] splitted = fullNameInput.Split(' ');
			List<string> firstnameL = new List<string>();
			for (int i = 0; i < splitted.Length; i++)
			{
				if (splitted.Length == 2 && firstname == "")
				{
					firstname = splitted[i];
				}
				else if (splitted.Length > 2 && i != splitted.Length - 1)
				{
					firstname += splitted[i] + " ";
					//firstnameL.Add(splitted[i]);
				}
			}
			lastname = splitted[splitted.Length - 1];
			#region If the student is not registered
			if (!astudent.isStudentRegistered(firstname, lastname))
			{
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText =
						"INSERT INTO students(" +
						"studentName, studentSurname)" +
						"VALUES('" +
						firstname + "','" + lastname +
						"') " +
						"OPTION (QUERYTRACEON 460); " +
						"DBCC TRACEOFF(460, -1); "
						/*
						Connection = connection,
						CommandText =
						"Insert Into userBorrowView(" +
						"studentName, studentSurname, bookName, authorName, authorSurname, " +
						"takenDate, broughtDate" +
						") " +
						"values('" + firstname + "','" + lastname + "','" + thisBookName + "','" +
						thisAuthorName + "','" + thisAuthorSurname + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + DateTime.Now.AddDays(21).ToString("yyyy/MM/dd") +
						"') " +
						"OPTION (QUERYTRACEON 460); " +
						"DBCC TRACEOFF(460, -1); "*/
					};
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					//MessageBox.Show("Borrowed", "Borrow Successful");
					listing(); // must be called after the connection closed
				}
			}
			#endregion
			string thisAuthorName = dgvSearch.CurrentRow.Cells[0].Value.ToString();
			string thisAuthorSurname = dgvSearch.CurrentRow.Cells[1].Value.ToString();
			string thisBookName = dgvSearch.CurrentRow.Cells[2].Value.ToString();
			string thisCategory = dgvSearch.CurrentRow.Cells[3].Value.ToString();

			int bookId = abook.getBookId(thisBookName);
			int studentId = astudent.getStudentId(firstname, lastname);
			MessageBox.Show("book id:" + bookId.ToString(), "student id:" + studentId.ToString());
			UserProfile up = new UserProfile();
			/*
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
			}*/

			if (connection.State == ConnectionState.Closed)
			{
				int count = 0; // Trigger should be created only once.
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText =
					"INSERT INTO borrows(" +
					"studentId, bookId, takenDate, broughtDate)" +
					"VALUES('" +
					studentId + "','" + bookId + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + DateTime.Now.AddDays(21).ToString("yyyy/MM/dd") +
					"') " +
					"OPTION (QUERYTRACEON 460); " +
					"DBCC TRACEOFF(460, -1); "
					/*
					Connection = connection,
					CommandText =
					"Insert Into userBorrowView(" +
					"studentName, studentSurname, bookName, authorName, authorSurname, " +
					"takenDate, broughtDate" +
					") " +
					"values('" + firstname + "','" + lastname + "','" + thisBookName + "','" +
					thisAuthorName + "','" + thisAuthorSurname + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + DateTime.Now.AddDays(21).ToString("yyyy/MM/dd") +
					"') " +
					"OPTION (QUERYTRACEON 460); " +
					"DBCC TRACEOFF(460, -1); "*/
				};
				count++;
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				//MessageBox.Show("Borrowed", "Borrow Successful");
				listing(); // must be called after the connection closed
			}
		}
	}
}