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
			this.userBorrowViewDataSet = new LibraryManagementSystem.userBorrowViewDataSet();
			this.userBorrowViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userBorrowViewTableAdapter = new LibraryManagementSystem.userBorrowViewDataSetTableAdapters.userBorrowViewTableAdapter();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.borrowDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorSurnameDataGridViewTextBoxColumn,
            this.borrowDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userBorrowViewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(594, 270);
			this.dataGridView1.TabIndex = 0;
			// 
			// userBorrowViewDataSet
			// 
			this.userBorrowViewDataSet.DataSetName = "userBorrowViewDataSet";
			this.userBorrowViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userBorrowViewBindingSource
			// 
			this.userBorrowViewBindingSource.DataMember = "userBorrowView";
			this.userBorrowViewBindingSource.DataSource = this.userBorrowViewDataSet;
			// 
			// userBorrowViewTableAdapter
			// 
			this.userBorrowViewTableAdapter.ClearBeforeFill = true;
			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			// 
			// studentSurnameDataGridViewTextBoxColumn
			// 
			this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student Surname";
			this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Student Surname";
			this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			// 
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			// 
			// authorSurnameDataGridViewTextBoxColumn
			// 
			this.authorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Author Surname";
			this.authorSurnameDataGridViewTextBoxColumn.HeaderText = "Author Surname";
			this.authorSurnameDataGridViewTextBoxColumn.Name = "authorSurnameDataGridViewTextBoxColumn";
			// 
			// borrowDateDataGridViewTextBoxColumn
			// 
			this.borrowDateDataGridViewTextBoxColumn.DataPropertyName = "Borrow Date";
			this.borrowDateDataGridViewTextBoxColumn.HeaderText = "Borrow Date";
			this.borrowDateDataGridViewTextBoxColumn.Name = "borrowDateDataGridViewTextBoxColumn";
			// 
			// returnDateDataGridViewTextBoxColumn
			// 
			this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return Date";
			this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
			this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
			// 
			// UserUserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.dataGridView1);
			this.Name = "UserUserControl1";
			this.Size = new System.Drawing.Size(600, 325);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userBorrowViewBindingSource;
		private userBorrowViewDataSet userBorrowViewDataSet;
		private userBorrowViewDataSetTableAdapters.userBorrowViewTableAdapter userBorrowViewTableAdapter;
	}
}
