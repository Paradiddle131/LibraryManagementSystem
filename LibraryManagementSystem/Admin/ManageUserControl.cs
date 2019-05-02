using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class ManageUserControl : UserControl
	{
		public bool isAdmin = false;
		public ManageUserControl()
		{
			InitializeComponent();
		}

		private static ManageUserControl _instance;
		public ManageUserControl Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ManageUserControl();
				}

				return _instance;
			}
		}

		private void btnAddAuthor_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//addAuthor AddAuthorForm = new addAuthor(isAdmin);
			addAuthor AddAuthorForm = new addAuthor();
			AddAuthorForm.Show();
		}

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			//this.Hide();
			addBook AddBookForm = new addBook();
			AddBookForm.Show();
		}

		private void btnAddBorrow_Click(object sender, EventArgs e)
		{
			//this.Hide();
			addBorrow AddBorrowForm = new addBorrow();
			AddBorrowForm.Show();
		}

		private void bnAddStudent_Click(object sender, EventArgs e)
		{
			//this.Hide();
			addStudent AddStudentForm = new addStudent();
			AddStudentForm.Show();
		}

		private void btnAddType_Click(object sender, EventArgs e)
		{
			//this.Hide();
			addType AddTypeForm = new addType();
			AddTypeForm.Show();
		}
	}
}