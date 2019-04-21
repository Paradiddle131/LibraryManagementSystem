using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class searchBook : Form
	{
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
				CommandText = "SELECT * FROM library.dbo.adminSearchView"
			};
			SqlDataAdapter adpr = new SqlDataAdapter(cmd);
			//DataSet ds = new DataSet();
			connection.Close();
		}
		private void BtnBack_Click(object sender, EventArgs e)
		{
			this.Close();
			UserForm uf = new UserForm();
			uf.Show();
		}

		private void SearchBook_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'userSearchViewDataSet.userSearchView' table. You can move, or remove it, as needed.
			this.userSearchViewTableAdapter.Fill(this.userSearchViewDataSet.userSearchView);

		}

		private void SearchAuthorNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.userSearchViewTableAdapter.SearchAuthorName(this.userSearchViewDataSet.userSearchView, authorNameToolStripTextBox.Text);
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
				this.userSearchViewTableAdapter.SearchAuthorSurname(this.userSearchViewDataSet.userSearchView, authorSurnameToolStripTextBox.Text);
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
				this.userSearchViewTableAdapter.SearchBookName(this.userSearchViewDataSet.userSearchView, bookNameToolStripTextBox.Text);
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
				this.userSearchViewTableAdapter.SearchCategory(this.userSearchViewDataSet.userSearchView, categoryToolStripTextBox.Text);
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
				this.userSearchViewTableAdapter.ResetFilter(this.userSearchViewDataSet.userSearchView);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
