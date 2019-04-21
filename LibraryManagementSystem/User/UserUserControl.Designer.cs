using LibraryManagementSystem.Data.Datasets;

namespace LibraryManagementSystem
{
	partial class UserUserControl1
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUserControl1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.borrowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.takenDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.broughtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.borrowsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.borrowDataSet = new LibraryManagementSystem.Data.Datasets.borrowDataSet();
			this.borrowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.borrowsDataSet = new LibraryManagementSystem.Data.Datasets.BorrowsDataSet();
			this.borrowsTableAdapter = new LibraryManagementSystem.Data.Datasets.BorrowsDataSetTableAdapters.borrowsTableAdapter();
			this.borrowsTableAdapter1 = new LibraryManagementSystem.Data.Datasets.borrowDataSetTableAdapters.borrowsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.bookIdDataGridViewTextBoxColumn,
            this.takenDateDataGridViewTextBoxColumn,
            this.broughtDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.borrowsBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(250, 46);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(330, 242);
			this.dataGridView1.TabIndex = 0;
			// 
			// borrowIdDataGridViewTextBoxColumn
			// 
			this.borrowIdDataGridViewTextBoxColumn.DataPropertyName = "borrowId";
			this.borrowIdDataGridViewTextBoxColumn.HeaderText = "borrowId";
			this.borrowIdDataGridViewTextBoxColumn.Name = "borrowIdDataGridViewTextBoxColumn";
			this.borrowIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentIdDataGridViewTextBoxColumn
			// 
			this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
			this.studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
			this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			// 
			// takenDateDataGridViewTextBoxColumn
			// 
			this.takenDateDataGridViewTextBoxColumn.DataPropertyName = "takenDate";
			this.takenDateDataGridViewTextBoxColumn.HeaderText = "takenDate";
			this.takenDateDataGridViewTextBoxColumn.Name = "takenDateDataGridViewTextBoxColumn";
			// 
			// broughtDateDataGridViewTextBoxColumn
			// 
			this.broughtDateDataGridViewTextBoxColumn.DataPropertyName = "broughtDate";
			this.broughtDateDataGridViewTextBoxColumn.HeaderText = "broughtDate";
			this.broughtDateDataGridViewTextBoxColumn.Name = "broughtDateDataGridViewTextBoxColumn";
			// 
			// borrowsBindingSource1
			// 
			this.borrowsBindingSource1.DataMember = "borrows";
			this.borrowsBindingSource1.DataSource = this.borrowDataSet;
			// 
			// borrowDataSet
			// 
			this.borrowDataSet.DataSetName = "borrowDataSet";
			this.borrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// borrowsBindingSource
			// 
			this.borrowsBindingSource.DataMember = "borrows";
			this.borrowsBindingSource.DataSource = this.borrowsDataSet;
			// 
			// borrowsDataSet
			// 
			this.borrowsDataSet.DataSetName = "BorrowsDataSet";
			this.borrowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// borrowsTableAdapter
			// 
			this.borrowsTableAdapter.ClearBeforeFill = true;
			// 
			// borrowsTableAdapter1
			// 
			this.borrowsTableAdapter1.ClearBeforeFill = true;
			// 
			// UserUserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.dataGridView1);
			this.Name = "UserUserControl1";
			this.Size = new System.Drawing.Size(792, 324);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.borrowsDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource borrowsBindingSource;
		private BorrowsDataSet borrowsDataSet;
		private Data.Datasets.BorrowsDataSetTableAdapters.borrowsTableAdapter borrowsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn takenDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn broughtDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource borrowsBindingSource1;
		private borrowDataSet borrowDataSet;
		private Data.Datasets.borrowDataSetTableAdapters.borrowsTableAdapter borrowsTableAdapter1;
	}
}
