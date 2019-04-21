using LibraryManagementSystem.Data.Views;

namespace LibraryManagementSystem
{
	partial class searchBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchBook));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnBack = new System.Windows.Forms.Button();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userSearchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userSearchViewDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userSearchViewDataSet = new LibraryManagementSystem.Data.Views.userSearchViewDataSet();
			this.searchAuthorNameToolStrip = new System.Windows.Forms.ToolStrip();
			this.authorNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.authorNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchAuthorNameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.searchAuthorSurnameToolStrip = new System.Windows.Forms.ToolStrip();
			this.authorSurnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.authorSurnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchAuthorSurnameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.searchBookNameToolStrip = new System.Windows.Forms.ToolStrip();
			this.bookNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.bookNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchBookNameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.searchCategoryToolStrip = new System.Windows.Forms.ToolStrip();
			this.categoryToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.categoryToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchCategoryToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.userSearchViewTableAdapter = new LibraryManagementSystem.Data.Views.userSearchViewDataSetTableAdapters.userSearchViewTableAdapter();
			this.resetFilterToolStrip = new System.Windows.Forms.ToolStrip();
			this.resetFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBorrow = new LollipopButton();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvBookForBorrow = new System.Windows.Forms.DataGridView();
			this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pagecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.booksForBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookForBorrowView = new LibraryManagementSystem.Data.Views.bookForBorrowView();
			this.bookForBorrow = new LibraryManagementSystem.Data.Datasets.bookForBorrow();
			this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.libraryDataSet3 = new LibraryManagementSystem.Data.Datasets.libraryDataSet3();
			this.booksForBorrowTableAdapter = new LibraryManagementSystem.Data.Views.bookForBorrowViewTableAdapters.booksForBorrowTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSet)).BeginInit();
			this.searchAuthorNameToolStrip.SuspendLayout();
			this.searchAuthorSurnameToolStrip.SuspendLayout();
			this.searchBookNameToolStrip.SuspendLayout();
			this.searchCategoryToolStrip.SuspendLayout();
			this.resetFilterToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookForBorrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksForBorrowBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookForBorrowView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookForBorrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(12, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 13;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToOrderColumns = true;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSearch.AutoGenerateColumns = false;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.authorNameDataGridViewTextBoxColumn,
			this.authorSurnameDataGridViewTextBoxColumn,
			this.bookNameDataGridViewTextBoxColumn,
			this.categoryDataGridViewTextBoxColumn});
			this.dgvSearch.DataSource = this.userSearchViewBindingSource;
			this.dgvSearch.Location = new System.Drawing.Point(9, 198);
			this.dgvSearch.Margin = new System.Windows.Forms.Padding(0);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(762, 293);
			this.dgvSearch.TabIndex = 14;
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
			this.userSearchViewBindingSource.DataSource = this.userSearchViewDataSetBindingSource;
			// 
			// userSearchViewDataSetBindingSource
			// 
			this.userSearchViewDataSetBindingSource.DataSource = this.userSearchViewDataSet;
			this.userSearchViewDataSetBindingSource.Position = 0;
			// 
			// userSearchViewDataSet
			// 
			this.userSearchViewDataSet.DataSetName = "userSearchViewDataSet";
			this.userSearchViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// searchAuthorNameToolStrip
			// 
			this.searchAuthorNameToolStrip.AutoSize = false;
			this.searchAuthorNameToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchAuthorNameToolStrip.BackgroundImage")));
			this.searchAuthorNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchAuthorNameToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchAuthorNameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.searchAuthorNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.authorNameToolStripLabel,
			this.authorNameToolStripTextBox,
			this.searchAuthorNameToolStripButton});
			this.searchAuthorNameToolStrip.Location = new System.Drawing.Point(12, 91);
			this.searchAuthorNameToolStrip.Name = "searchAuthorNameToolStrip";
			this.searchAuthorNameToolStrip.Size = new System.Drawing.Size(364, 34);
			this.searchAuthorNameToolStrip.TabIndex = 15;
			this.searchAuthorNameToolStrip.Text = "searchAuthorNameToolStrip";
			// 
			// authorNameToolStripLabel
			// 
			this.authorNameToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.authorNameToolStripLabel.Name = "authorNameToolStripLabel";
			this.authorNameToolStripLabel.Size = new System.Drawing.Size(151, 31);
			this.authorNameToolStripLabel.Text = "Author Name: ";
			// 
			// authorNameToolStripTextBox
			// 
			this.authorNameToolStripTextBox.Margin = new System.Windows.Forms.Padding(29, 0, 1, 0);
			this.authorNameToolStripTextBox.Name = "authorNameToolStripTextBox";
			this.authorNameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
			// 
			// searchAuthorNameToolStripButton
			// 
			this.searchAuthorNameToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchAuthorNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchAuthorNameToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchAuthorNameToolStripButton.Name = "searchAuthorNameToolStripButton";
			this.searchAuthorNameToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchAuthorNameToolStripButton.Text = "Search";
			this.searchAuthorNameToolStripButton.Click += new System.EventHandler(this.SearchAuthorNameToolStripButton_Click);
			// 
			// searchAuthorSurnameToolStrip
			// 
			this.searchAuthorSurnameToolStrip.AutoSize = false;
			this.searchAuthorSurnameToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchAuthorSurnameToolStrip.BackgroundImage")));
			this.searchAuthorSurnameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchAuthorSurnameToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchAuthorSurnameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.searchAuthorSurnameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.authorSurnameToolStripLabel,
			this.authorSurnameToolStripTextBox,
			this.searchAuthorSurnameToolStripButton});
			this.searchAuthorSurnameToolStrip.Location = new System.Drawing.Point(12, 146);
			this.searchAuthorSurnameToolStrip.Name = "searchAuthorSurnameToolStrip";
			this.searchAuthorSurnameToolStrip.Size = new System.Drawing.Size(364, 34);
			this.searchAuthorSurnameToolStrip.TabIndex = 16;
			this.searchAuthorSurnameToolStrip.Text = "searchAuthorSurnameToolStrip";
			// 
			// authorSurnameToolStripLabel
			// 
			this.authorSurnameToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.authorSurnameToolStripLabel.Name = "authorSurnameToolStripLabel";
			this.authorSurnameToolStripLabel.Size = new System.Drawing.Size(178, 31);
			this.authorSurnameToolStripLabel.Text = "Author Surname: ";
			// 
			// authorSurnameToolStripTextBox
			// 
			this.authorSurnameToolStripTextBox.Name = "authorSurnameToolStripTextBox";
			this.authorSurnameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
			// 
			// searchAuthorSurnameToolStripButton
			// 
			this.searchAuthorSurnameToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchAuthorSurnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchAuthorSurnameToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchAuthorSurnameToolStripButton.Name = "searchAuthorSurnameToolStripButton";
			this.searchAuthorSurnameToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchAuthorSurnameToolStripButton.Text = "Search";
			this.searchAuthorSurnameToolStripButton.Click += new System.EventHandler(this.SearchAuthorSurnameToolStripButton_Click);
			// 
			// searchBookNameToolStrip
			// 
			this.searchBookNameToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBookNameToolStrip.BackgroundImage")));
			this.searchBookNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchBookNameToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchBookNameToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.searchBookNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.bookNameToolStripLabel,
			this.bookNameToolStripTextBox,
			this.searchBookNameToolStripButton});
			this.searchBookNameToolStrip.Location = new System.Drawing.Point(424, 91);
			this.searchBookNameToolStrip.Name = "searchBookNameToolStrip";
			this.searchBookNameToolStrip.Size = new System.Drawing.Size(316, 34);
			this.searchBookNameToolStrip.TabIndex = 17;
			this.searchBookNameToolStrip.Text = "searchBookNameToolStrip";
			// 
			// bookNameToolStripLabel
			// 
			this.bookNameToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.bookNameToolStripLabel.Name = "bookNameToolStripLabel";
			this.bookNameToolStripLabel.Size = new System.Drawing.Size(130, 31);
			this.bookNameToolStripLabel.Text = "Book Name: ";
			// 
			// bookNameToolStripTextBox
			// 
			this.bookNameToolStripTextBox.Name = "bookNameToolStripTextBox";
			this.bookNameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
			// 
			// searchBookNameToolStripButton
			// 
			this.searchBookNameToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchBookNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchBookNameToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchBookNameToolStripButton.Name = "searchBookNameToolStripButton";
			this.searchBookNameToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchBookNameToolStripButton.Text = "Search";
			this.searchBookNameToolStripButton.Click += new System.EventHandler(this.SearchBookNameToolStripButton_Click);
			// 
			// searchCategoryToolStrip
			// 
			this.searchCategoryToolStrip.AutoSize = false;
			this.searchCategoryToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchCategoryToolStrip.BackgroundImage")));
			this.searchCategoryToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchCategoryToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchCategoryToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.searchCategoryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.categoryToolStripLabel,
			this.categoryToolStripTextBox,
			this.searchCategoryToolStripButton});
			this.searchCategoryToolStrip.Location = new System.Drawing.Point(424, 146);
			this.searchCategoryToolStrip.Name = "searchCategoryToolStrip";
			this.searchCategoryToolStrip.Size = new System.Drawing.Size(316, 34);
			this.searchCategoryToolStrip.TabIndex = 18;
			this.searchCategoryToolStrip.Text = "searchCategoryToolStrip";
			// 
			// categoryToolStripLabel
			// 
			this.categoryToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.categoryToolStripLabel.Name = "categoryToolStripLabel";
			this.categoryToolStripLabel.Size = new System.Drawing.Size(111, 31);
			this.categoryToolStripLabel.Text = "Category: ";
			// 
			// categoryToolStripTextBox
			// 
			this.categoryToolStripTextBox.Margin = new System.Windows.Forms.Padding(20, 0, 1, 0);
			this.categoryToolStripTextBox.Name = "categoryToolStripTextBox";
			this.categoryToolStripTextBox.Size = new System.Drawing.Size(100, 34);
			// 
			// searchCategoryToolStripButton
			// 
			this.searchCategoryToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchCategoryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchCategoryToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchCategoryToolStripButton.Name = "searchCategoryToolStripButton";
			this.searchCategoryToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchCategoryToolStripButton.Text = "Search";
			this.searchCategoryToolStripButton.Click += new System.EventHandler(this.SearchCategoryToolStripButton_Click);
			// 
			// userSearchViewTableAdapter
			// 
			this.userSearchViewTableAdapter.ClearBeforeFill = true;
			// 
			// resetFilterToolStrip
			// 
			this.resetFilterToolStrip.AutoSize = false;
			this.resetFilterToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetFilterToolStrip.BackgroundImage")));
			this.resetFilterToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.resetFilterToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.resetFilterToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.resetFilterToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.resetFilterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.resetFilterToolStripButton});
			this.resetFilterToolStrip.Location = new System.Drawing.Point(164, 33);
			this.resetFilterToolStrip.Name = "resetFilterToolStrip";
			this.resetFilterToolStrip.Size = new System.Drawing.Size(212, 43);
			this.resetFilterToolStrip.TabIndex = 19;
			this.resetFilterToolStrip.Text = "resetFilterToolStrip";
			// 
			// resetFilterToolStripButton
			// 
			this.resetFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.resetFilterToolStripButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.resetFilterToolStripButton.Name = "resetFilterToolStripButton";
			this.resetFilterToolStripButton.Size = new System.Drawing.Size(136, 40);
			this.resetFilterToolStripButton.Text = "Reset Filters";
			this.resetFilterToolStripButton.Click += new System.EventHandler(this.ResetFilterToolStripButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(311, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.ResetFilterToolStripButton_Click);
			// 
			// btnBorrow
			// 
			this.btnBorrow.BackColor = System.Drawing.Color.Transparent;
			this.btnBorrow.BGColor = "#89f91e";
			this.btnBorrow.FontColor = "#ff0000";
			this.btnBorrow.Location = new System.Drawing.Point(424, 33);
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(143, 41);
			this.btnBorrow.TabIndex = 21;
			this.btnBorrow.Text = "BORROW";
			this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(601, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "label1";
			// 
			// dgvBookForBorrow
			// 
			this.dgvBookForBorrow.AutoGenerateColumns = false;
			this.dgvBookForBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBookForBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.bookIdDataGridViewTextBoxColumn,
			this.nameDataGridViewTextBoxColumn,
			this.pagecountDataGridViewTextBoxColumn,
			this.pointDataGridViewTextBoxColumn,
			this.authorIdDataGridViewTextBoxColumn,
			this.typeIdDataGridViewTextBoxColumn});
			this.dgvBookForBorrow.DataSource = this.booksForBorrowBindingSource;
			this.dgvBookForBorrow.Location = new System.Drawing.Point(111, 220);
			this.dgvBookForBorrow.Name = "dgvBookForBorrow";
			this.dgvBookForBorrow.Size = new System.Drawing.Size(657, 215);
			this.dgvBookForBorrow.TabIndex = 23;
			this.dgvBookForBorrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookForBorrow_CellClick);
			// 
			// bookIdDataGridViewTextBoxColumn
			// 
			this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
			this.bookIdDataGridViewTextBoxColumn.HeaderText = "bookId";
			this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
			this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// pagecountDataGridViewTextBoxColumn
			// 
			this.pagecountDataGridViewTextBoxColumn.DataPropertyName = "pagecount";
			this.pagecountDataGridViewTextBoxColumn.HeaderText = "pagecount";
			this.pagecountDataGridViewTextBoxColumn.Name = "pagecountDataGridViewTextBoxColumn";
			// 
			// pointDataGridViewTextBoxColumn
			// 
			this.pointDataGridViewTextBoxColumn.DataPropertyName = "point";
			this.pointDataGridViewTextBoxColumn.HeaderText = "point";
			this.pointDataGridViewTextBoxColumn.Name = "pointDataGridViewTextBoxColumn";
			// 
			// authorIdDataGridViewTextBoxColumn
			// 
			this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "authorId";
			this.authorIdDataGridViewTextBoxColumn.HeaderText = "authorId";
			this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
			// 
			// typeIdDataGridViewTextBoxColumn
			// 
			this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "typeId";
			this.typeIdDataGridViewTextBoxColumn.HeaderText = "typeId";
			this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
			// 
			// booksForBorrowBindingSource
			// 
			this.booksForBorrowBindingSource.DataMember = "booksForBorrow";
			this.booksForBorrowBindingSource.DataSource = this.bookForBorrowView;
			// 
			// bookForBorrowView
			// 
			this.bookForBorrowView.DataSetName = "bookForBorrowView";
			this.bookForBorrowView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bookForBorrow
			// 
			this.bookForBorrow.DataSetName = "bookForBorrow";
			this.bookForBorrow.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// booksBindingSource
			// 
			this.booksBindingSource.DataMember = "books";
			this.booksBindingSource.DataSource = this.bookForBorrow;
			// 
			// libraryDataSet3
			// 
			this.libraryDataSet3.DataSetName = "libraryDataSet3";
			this.libraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// booksForBorrowTableAdapter
			// 
			this.booksForBorrowTableAdapter.ClearBeforeFill = true;
			// 
			// searchBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(780, 500);
			this.Controls.Add(this.dgvSearch);
			this.Controls.Add(this.dgvBookForBorrow);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBorrow);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.resetFilterToolStrip);
			this.Controls.Add(this.searchCategoryToolStrip);
			this.Controls.Add(this.searchBookNameToolStrip);
			this.Controls.Add(this.searchAuthorSurnameToolStrip);
			this.Controls.Add(this.searchAuthorNameToolStrip);
			this.Controls.Add(this.btnBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(780, 500);
			this.MinimumSize = new System.Drawing.Size(780, 500);
			this.Name = "searchBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "searchBook";
			this.Load += new System.EventHandler(this.SearchBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userSearchViewDataSet)).EndInit();
			this.searchAuthorNameToolStrip.ResumeLayout(false);
			this.searchAuthorNameToolStrip.PerformLayout();
			this.searchAuthorSurnameToolStrip.ResumeLayout(false);
			this.searchAuthorSurnameToolStrip.PerformLayout();
			this.searchBookNameToolStrip.ResumeLayout(false);
			this.searchBookNameToolStrip.PerformLayout();
			this.searchCategoryToolStrip.ResumeLayout(false);
			this.searchCategoryToolStrip.PerformLayout();
			this.resetFilterToolStrip.ResumeLayout(false);
			this.resetFilterToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBookForBorrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksForBorrowBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookForBorrowView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookForBorrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.libraryDataSet3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.DataGridView dgvSearch;
		private System.Windows.Forms.BindingSource userSearchViewDataSetBindingSource;
		private userSearchViewDataSet userSearchViewDataSet;
		private System.Windows.Forms.BindingSource userSearchViewBindingSource;
		private Data.Views.userSearchViewDataSetTableAdapters.userSearchViewTableAdapter userSearchViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStrip searchAuthorNameToolStrip;
		private System.Windows.Forms.ToolStripLabel authorNameToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox authorNameToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchAuthorNameToolStripButton;
		private System.Windows.Forms.ToolStrip searchAuthorSurnameToolStrip;
		private System.Windows.Forms.ToolStripLabel authorSurnameToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox authorSurnameToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchAuthorSurnameToolStripButton;
		private System.Windows.Forms.ToolStrip searchBookNameToolStrip;
		private System.Windows.Forms.ToolStripLabel bookNameToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox bookNameToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchBookNameToolStripButton;
		private System.Windows.Forms.ToolStrip searchCategoryToolStrip;
		private System.Windows.Forms.ToolStripLabel categoryToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox categoryToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchCategoryToolStripButton;
		private System.Windows.Forms.ToolStrip resetFilterToolStrip;
		private System.Windows.Forms.ToolStripButton resetFilterToolStripButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private LollipopButton btnBorrow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvBookForBorrow;
		private System.Windows.Forms.BindingSource booksBindingSource;
		private Data.Datasets.bookForBorrow bookForBorrow;
		private Data.Datasets.libraryDataSet3 libraryDataSet3;
		private bookForBorrowView bookForBorrowView;
		private System.Windows.Forms.BindingSource booksForBorrowBindingSource;
		private Data.Views.bookForBorrowViewTableAdapters.booksForBorrowTableAdapter booksForBorrowTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pagecountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
	}
}