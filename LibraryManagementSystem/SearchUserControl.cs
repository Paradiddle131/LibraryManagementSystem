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
	public partial class SearchUserControl : UserControl
	{
		private static SearchUserControl _instance;
		public SearchUserControl Instance
		{
			get
			{
				if (_instance == null)
					_instance = new SearchUserControl();
				return _instance;
			}
		}
		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);

		private void SearchUserControl_Load(object sender, EventArgs e)
		{
			this.userSearchViewTableAdapter.Fill(this.userSearchViewDataSet.userSearchView);
			listing();
		}
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
		public SearchUserControl()
		{
			InitializeComponent();
		}
		#region TextBox Focus
		private void TxtSearch_Enter(object sender, EventArgs e)
		{
			if (txtSearch.Text == "Search for a book by its name, author or category")
			{
				txtSearch.Text = "";
			}
		}
		
		private void TxtSearch_Leave(object sender, EventArgs e)
		{
			if (txtSearch.Text.Trim() == "")
			{
				txtSearch.Text = "Search for a book by its name, author or category";
			}
		}
		#endregion

		private void TxtSearch_TextChanged(object sender, EventArgs e)
		{
			this.userSearchViewTableAdapter.Fill(this.userSearchViewDataSet.userSearchView);
			listing();
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
				"SELECT name FROM authors WHERE name like 'z%' ORDER BY name ASC;", connection);
			DataTable dt = new DataTable();
			adpr.Fill(dt);
			dgvSearch.DataSource = dt;
			connection.Close();
		}

		private void DgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
