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
using dbForLMS;

namespace LibraryManagementSystem
{
	public partial class SearchByAuthor : Form
	{
		dbForLMS.Checkout checkout = new dbForLMS.Checkout();
		public SearchByAuthor()
		{
			InitializeComponent();
		}

	private const string ConnectionString = @"Data Source=DESKTOP-VGI8J75\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
	SqlConnection connection = new SqlConnection(ConnectionString);

	private void listing()
	{
		connection.Open();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = connection;
		cmd.CommandText = "SELECT * FROM library";
		SqlDataAdapter adpr = new SqlDataAdapter(cmd);
		//DataSet ds = new DataSet();
		connection.Close();
	}

	private void txtSearch_TextChanged(object sender, EventArgs e)
	{
		connection.Open();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = connection;
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
		this.authorsTableAdapter.Fill(this.authorDataSet.authors);
		// TODO: This line of code loads data into the 'searchDataSet.authors' table. You can move, or remove it, as needed.
		this.authorsTableAdapter.Fill(this.authorDataSet.authors);
		listing();

	}

	private void txtSearch_Enter(object sender, EventArgs e)
	{
		if (txtSearch.Text == "Search for a book by its name, author or category")
			txtSearch.Text = "";
	}

	private void txtSearch_Leave(object sender, EventArgs e)
	{
		if (txtSearch.Text.Trim() == "")
			txtSearch.Text = "Search for a book by its name, author or category";
	}

		private void SearchByAuthor_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'libraryDataSet2.authors' table. You can move, or remove it, as needed.
			this.authorsTableAdapter.Fill(this.authorDataSet.authors);

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			checkout.Show();
		}
	}
}
