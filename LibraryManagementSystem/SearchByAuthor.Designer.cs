namespace LibraryManagementSystem
{
	partial class SearchByAuthor
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchByAuthor));
			this.txtSearch = new LollipopTextBox();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authorDataSet = new LibraryManagementSystem.libraryDataSet2();
			this.authorsTableAdapter = new LibraryManagementSystem.libraryDataSet2TableAdapters.authorsTableAdapter();
			this.btnBack = new System.Windows.Forms.Button();
			this.searchDataSet = new LibraryManagementSystem.searchDataSet();
			this.searchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchViewTableAdapter = new LibraryManagementSystem.searchDataSetTableAdapters.SearchViewTableAdapter();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.FocusedColor = "#508ef5";
			this.txtSearch.FontColor = "#999999";
			this.txtSearch.IsEnabled = true;
			this.txtSearch.Location = new System.Drawing.Point(24, 56);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Multiline = false;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.ReadOnly = false;
			this.txtSearch.Size = new System.Drawing.Size(742, 24);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.Text = "Search for a book by its name, author or category";
			this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.UseSystemPasswordChar = false;
			this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToAddRows = false;
			this.dgvSearch.AllowUserToDeleteRows = false;
			this.dgvSearch.AutoGenerateColumns = false;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorNameDataGridViewTextBoxColumn,
            this.authorSurnameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn});
			this.dgvSearch.DataSource = this.searchViewBindingSource;
			this.dgvSearch.Location = new System.Drawing.Point(24, 95);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.ReadOnly = true;
			this.dgvSearch.Size = new System.Drawing.Size(742, 293);
			this.dgvSearch.TabIndex = 2;
			// 
			// authorsBindingSource
			// 
			this.authorsBindingSource.DataMember = "authors";
			this.authorsBindingSource.DataSource = this.authorDataSet;
			// 
			// authorDataSet
			// 
			this.authorDataSet.DataSetName = "authorDataSet";
			this.authorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// authorsTableAdapter
			// 
			this.authorsTableAdapter.ClearBeforeFill = true;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(24, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 7;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// searchDataSet
			// 
			this.searchDataSet.DataSetName = "searchDataSet";
			this.searchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// searchViewBindingSource
			// 
			this.searchViewBindingSource.DataMember = "SearchView";
			this.searchViewBindingSource.DataSource = this.searchDataSet;
			// 
			// searchViewTableAdapter
			// 
			this.searchViewTableAdapter.ClearBeforeFill = true;
			// 
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorSurnameDataGridViewTextBoxColumn
			// 
			this.authorSurnameDataGridViewTextBoxColumn.DataPropertyName = "Author Surname";
			this.authorSurnameDataGridViewTextBoxColumn.HeaderText = "Author Surname";
			this.authorSurnameDataGridViewTextBoxColumn.Name = "authorSurnameDataGridViewTextBoxColumn";
			this.authorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentSurnameDataGridViewTextBoxColumn
			// 
			this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student Surname";
			this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Student Surname";
			this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
			this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// SearchByAuthor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 400);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dgvSearch);
			this.Controls.Add(this.txtSearch);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 400);
			this.Name = "SearchByAuthor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SearchByAuthor";
			this.Load += new System.EventHandler(this.SearchByAuthor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.authorDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.searchViewBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private LollipopTextBox txtSearch;
		private System.Windows.Forms.DataGridView dgvSearch;
		private libraryDataSet2 authorDataSet;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private libraryDataSet2TableAdapters.authorsTableAdapter authorsTableAdapter;
		private System.Windows.Forms.Button btnBack;
		private searchDataSet searchDataSet;
		private System.Windows.Forms.BindingSource searchViewBindingSource;
		private searchDataSetTableAdapters.SearchViewTableAdapter searchViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
	}
}