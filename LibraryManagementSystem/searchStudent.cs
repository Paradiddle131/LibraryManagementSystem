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
	public partial class searchStudent : Form
	{
		public searchStudent()
		{
			InitializeComponent();
		}
		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void SearchStudent_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'adminSearchViewDataSet.adminSearchView' table. You can move, or remove it, as needed.
			this.adminSearchViewTableAdapter.Fill(this.adminSearchViewDataSet.adminSearchView);
			listing();
		}
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
		/*
		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand cmd = new SqlCommand
			{
				Connection = connection
			};
			//SqlDataAdapter adpr = new SqlDataAdapter("SELECT * FROM authors " +
			//"WHERE name LIKE '" + txtSearch.Text + "'%'", connection);
			//SqlDataAdapter adpr = new SqlDataAdapter(" SELECT * FROM [searchView]" + 
			//	"WHERE name, surname LIKE" + txtSearch.Text + "'%'", connection);

			SqlDataAdapter adpr = new SqlDataAdapter(
				"SELECT name FROM authors WHERE name LIKE '@" + txtSearch.Text + "%' ORDER BY name ASC;", connection);
			DataTable dt = new DataTable();
			adpr.Fill(dt);
			dgvSearch.DataSource = dt;
			connection.Close();
			listing();
		}
		*/
		private void BtnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SearchStudentNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.adminSearchViewTableAdapter.SearchStudentName(this.adminSearchViewDataSet.adminSearchView, studentNameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void SearchStudentSurnameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.adminSearchViewTableAdapter.SearchStudentSurname(this.adminSearchViewDataSet.adminSearchView, surnameToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void ResetFiltersToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.adminSearchViewTableAdapter.ResetFilters(this.adminSearchViewDataSet.adminSearchView);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
	}
}
