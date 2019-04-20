using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class SearchByAuthor : Form
	{
		AdminForm af;
		bool isAdm;
		public SearchByAuthor(bool isAdm)
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
				CommandText = "SELECT * FROM library"
			};
			SqlDataAdapter adpr = new SqlDataAdapter(cmd);
			//DataSet ds = new DataSet();
			connection.Close();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = new SqlCommand
			{
				Connection = connection
			};
			SqlDataAdapter adpr = new SqlDataAdapter("SELECT * FROM authors " +
			"WHERE name LIKE '" + txtSearch.Text + "'%'", connection);
			DataTable dt = new DataTable();
			adpr.Fill(dt);
			dgvSearch.DataSource = dt;
			connection.Close();
		}

		private void Search_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'searchDataSet.books' table. You can move, or remove it, as needed.
			authorsTableAdapter.Fill(authorDataSet.authors);
			// TODO: This line of code loads data into the 'searchDataSet.authors' table. You can move, or remove it, as needed.
			authorsTableAdapter.Fill(authorDataSet.authors);
			listing();

		}
		#region Focus
		private void txtSearch_Enter(object sender, EventArgs e)
		{
			if (txtSearch.Text == "Search for a book by its name, author or category")
			{
				txtSearch.Text = "";
			}
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() == "")
			{
				txtSearch.Text = "Search for a book by its name, author or category";
			}
		}
		#endregion
		private void SearchByAuthor_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'libraryDataSet2.authors' table. You can move, or remove it, as needed.
			authorsTableAdapter.Fill(authorDataSet.authors);

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();/*
			if (!isAdm)
			{
				UserForm uf = new UserForm();
				uf.Show();
			}
			else
			{
				AdminForm af = new AdminForm();
				af.Show();
			}*/
		}
	}
}
