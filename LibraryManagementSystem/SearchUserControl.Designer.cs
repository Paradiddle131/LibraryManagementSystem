namespace LibraryManagementSystem
{
	partial class SearchUserControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserControl));
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userSearchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userSearchViewDataSet = new LibraryManagementSystem.userSearchViewDataSet();
			this.searchViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.searchDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchDataSet1 = new LibraryManagementSystem.searchDataSet();
			this.searchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtSearch = new LollipopTextBox();
			this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.authorDataSet = new LibraryManagementSystem.libraryDataSet2();
			this.authorsTableAdapter = new LibraryManagementSystem.libraryDataSet2TableAdapters.authorsTableAdapter();
			this.searchViewTableAdapter = new LibraryManagementSystem.searchDataSetTableAdapters.SearchViewTableAdapter();
			this.userSearchViewTableAdapter = new LibraryManagementSystem.userSearchViewDataSetTableAdapters.userSearchViewTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchViewBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.searchViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.authorDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSearch.AutoGenerateColumns = false;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorNameDataGridViewTextBoxColumn,
            this.authorSurnameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
			this.dgvSearch.DataSource = this.userSearchViewBindingSource;
			this.dgvSearch.Location = new System.Drawing.Point(37, 69);
			this.dgvSearch.Margin = new System.Windows.Forms.Padding(0);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(535, 243);
			this.dgvSearch.TabIndex = 9;
			this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearch_CellClick);
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
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			// 
			// userSearchViewBindingSource
			// 
			this.userSearchViewBindingSource.DataMember = "userSearchView";
			this.userSearchViewBindingSource.DataSource = this.userSearchViewDataSet;
			// 
			// userSearchViewDataSet
			// 
			this.userSearchViewDataSet.DataSetName = "userSearchViewDataSet";
			this.userSearchViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// searchViewBindingSource1
			// 
			this.searchViewBindingSource1.DataMember = "SearchView";
			this.searchViewBindingSource1.DataSource = this.searchDataSet1BindingSource;
			// 
			// searchDataSet1BindingSource
			// 
			this.searchDataSet1BindingSource.DataSource = this.searchDataSet1;
			this.searchDataSet1BindingSource.Position = 0;
			// 
			// searchDataSet1
			// 
			this.searchDataSet1.DataSetName = "searchDataSet";
			this.searchDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// searchViewBindingSource
			// 
			this.searchViewBindingSource.DataMember = "SearchView";
			// 
			// txtSearch
			// 
			this.txtSearch.FocusedColor = "#508ef5";
			this.txtSearch.FontColor = "#999999";
			this.txtSearch.IsEnabled = true;
			this.txtSearch.Location = new System.Drawing.Point(37, 30);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Multiline = false;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.ReadOnly = false;
			this.txtSearch.Size = new System.Drawing.Size(535, 24);
			this.txtSearch.TabIndex = 8;
			this.txtSearch.Text = "Search for a book by its name, author or category";
			this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.UseSystemPasswordChar = false;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
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
			// searchViewTableAdapter
			// 
			this.searchViewTableAdapter.ClearBeforeFill = true;
			// 
			// userSearchViewTableAdapter
			// 
			this.userSearchViewTableAdapter.ClearBeforeFill = true;
			// 
			// SearchUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.dgvSearch);
			this.Controls.Add(this.txtSearch);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SearchUserControl";
			this.Size = new System.Drawing.Size(800, 325);
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource booksBindingSource;
		private System.Windows.Forms.BindingSource searchDataSetBindingSource;
		private SearchDataSet searchDataSet;
		private System.Windows.Forms.DataGridView dgvSearch;
		private System.Windows.Forms.BindingSource searchViewBindingSource;
		private LollipopTextBox txtSearch;
		private System.Windows.Forms.BindingSource authorsBindingSource;
		private libraryDataSet2 authorDataSet;
		private libraryDataSet2TableAdapters.authorsTableAdapter authorsTableAdapter;
		private searchDataSetTableAdapters.SearchViewTableAdapter searchViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource searchViewBindingSource1;
		private System.Windows.Forms.BindingSource searchDataSet1BindingSource;
		private searchDataSet searchDataSet1;
		private System.Windows.Forms.BindingSource userSearchViewBindingSource;
		private userSearchViewDataSet userSearchViewDataSet;
		private userSearchViewDataSetTableAdapters.userSearchViewTableAdapter userSearchViewTableAdapter;
	}
}
