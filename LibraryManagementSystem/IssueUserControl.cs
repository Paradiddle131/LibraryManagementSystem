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

		private void btnAddAuthor_Click(object sender, EventArgs e)
		{
			this.Hide();
			addAuthor AddAuthorForm = new addAuthor();
			AddAuthorForm.Show();
		}

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			this.Hide();
			addBook AddBookForm = new addBook();
			AddBookForm.Show();
		}
	}
	}