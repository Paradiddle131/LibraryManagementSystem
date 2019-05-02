using System;
using System.Data.SqlClient;
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
			adminSearchViewTableAdapter.Fill(adminSearchViewDataSet.adminSearchView);
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
		private void BtnBack_Click(object sender, EventArgs e)
		{
			Close();
			AdminForm af = new AdminForm();
			af.Show();
		}

		private void SearchStudentNameToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				adminSearchViewTableAdapter.SearchStudentName(adminSearchViewDataSet.adminSearchView, studentNameToolStripTextBox.Text);
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
				adminSearchViewTableAdapter.SearchStudentSurname(adminSearchViewDataSet.adminSearchView, studentSurnameToolStripTextBox.Text);
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
				adminSearchViewTableAdapter.ResetFilters(adminSearchViewDataSet.adminSearchView);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			studentNameToolStripTextBox.Text = "";
			studentSurnameToolStripTextBox.Text = "";
		}
	}
}
