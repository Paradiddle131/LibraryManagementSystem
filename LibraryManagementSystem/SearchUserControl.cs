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
		public SearchUserControl()
		{
			InitializeComponent();
		}

		private void btnSearchByAuthor_Click(object sender, EventArgs e)
		{
			this.Hide();
			SearchByAuthor searchByAuthorForm = new SearchByAuthor();
			searchByAuthorForm.Show();
		}
	}
}
