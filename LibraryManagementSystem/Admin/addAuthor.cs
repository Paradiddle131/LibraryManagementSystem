using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
	public partial class addAuthor : Form
	{
		public DataGridView dAuthor => dgvAuthor;

		private readonly AdminForm af;
		//private readonly bool isAdm;
		private readonly SqlConnection connection = new SqlConnection(AdminForm.ConnectionString);
		public addAuthor()
		{
			InitializeComponent();
		}

		private void addAuthor_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'authorsDataSet.authors' table. You can move, or remove it, as needed.
			authorsTableAdapter.Fill(authorsDataSet.authors);
			listing();
		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "SELECT * FROM authors"
				};
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "authors");
				dgvAuthor.DataSource = ds.Tables["authors"];
				//dgvAuthor.Columns[0].Visible = false; // hides ID column
				connection.Close();
			}
		}

		public void clear()
		{
			txtAuthorName.Text = "";
			txtAuthorSurname.Text = "";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "INSERT INTO authors(name,surname) VALUES('" + txtAuthorName.Text + "','" + txtAuthorSurname.Text + "')"
				};
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				listing(); // must be called after the connection closed
				MessageBox.Show("Added.");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand
				{
					Connection = connection,
					CommandText = "UPDATE authors SET name='" + txtAuthorName.Text + "',surname='" + txtAuthorSurname.Text + "'WHERE authorId=@number"
				};
				cmd.Parameters.AddWithValue("@number", dgvAuthor.CurrentRow.Cells[0].Value.ToString());
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				connection.Close();
				MessageBox.Show("Edited.");
				clear();
				listing();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete?", "Hold On!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					SqlCommand cmd = new SqlCommand
					{
						Connection = connection,
						CommandText = "DELETE FROM authors WHERE authorId=@number"
					};
					cmd.Parameters.AddWithValue("@number", dgvAuthor.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtAuthorName.Text = dgvAuthor.CurrentRow.Cells[1].Value.ToString();
			txtAuthorSurname.Text = dgvAuthor.CurrentRow.Cells[2].Value.ToString();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Hide();
			//AdminForm af = new AdminForm();
			//af.Show();
		}

		#region Focus
		private void txtAuthorName_Enter(object sender, EventArgs e)
		{
			//when the textbox gains focus:
			if (txtAuthorName.Text == "<Enter Author Name>")
			{
				txtAuthorName.Text = "";
			}
		}

		private void txtAuthorName_Leave(object sender, EventArgs e)
		{
			if (txtAuthorName.Text.Trim() == "")
			{
				txtAuthorName.Text = "<Enter Author Name>";
			}
		}

		private void txtAuthorSurname_Enter(object sender, EventArgs e)
		{
			if (txtAuthorSurname.Text == "<Enter Author Surname>")
			{
				txtAuthorSurname.Text = "";
			}
		}

		private void txtAuthorSurname_Leave(object sender, EventArgs e)
		{
			if (txtAuthorSurname.Text.Trim() == "")
			{
				txtAuthorSurname.Text = "<Enter Author Surname>";
			}
		}
		#endregion
	}
}
