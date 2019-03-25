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

namespace LibraryManagementSystem
{
	public partial class addType : Form
	{
		dbForLMS.Checkout checkout = new dbForLMS.Checkout();
		public addType()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(dbForLMS.Checkout.ConnectionString);

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			checkout.Show();
		}

		private void addType_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'typeDataSet.types' table. You can move, or remove it, as needed.
			this.typesTableAdapter.Fill(this.typeDataSet.types);

		}

		public void listing()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM types";
				SqlDataAdapter adpr = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adpr.Fill(ds, "types");
				dgvType.DataSource = ds.Tables["types"];
				//dgvAuthor.Columns[0].Visible = false; // hides ID column
				connection.Close();
			}
		}

		public void clear()
		{
			txtTypeName.Text = "";
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "INSERT INTO types(name) VALUES('" + txtTypeName.Text + "')";
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
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "UPDATE types SET name='" + txtTypeName.Text + "'WHERE typeId=@number";
				cmd.Parameters.AddWithValue("@number", dgvType.CurrentRow.Cells[0].Value.ToString());
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
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = connection;
					cmd.CommandText = "DELETE FROM types WHERE typeId=@number";
					cmd.Parameters.AddWithValue("@number", dgvType.CurrentRow.Cells[0].Value.ToString());
					cmd.ExecuteNonQuery();
					cmd.Dispose();
					connection.Close();
					listing();
					MessageBox.Show("Deleted.");
				}
			}
		}

		private void txtTypeName_Enter(object sender, EventArgs e)
		{
			if (txtTypeName.Text == "<Enter Type Name>")
				txtTypeName.Text = "";
		}

		private void txtTypeName_Leave(object sender, EventArgs e)
		{
			if (txtTypeName.Text.Trim() == "")
				txtTypeName.Text = "<Enter Type Name>";
		}

		private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTypeName.Text = dgvType.CurrentRow.Cells[1].Value.ToString();
		}
	}
}
