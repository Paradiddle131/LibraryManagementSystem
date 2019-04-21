namespace LibraryManagementSystem
{
	partial class searchStudent
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchStudent));
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.borrowDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adminSearchViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.adminSearchViewDataSet = new LibraryManagementSystem.adminSearchViewDataSet();
			this.btnBack = new System.Windows.Forms.Button();
			this.adminSearchViewTableAdapter = new LibraryManagementSystem.adminSearchViewDataSetTableAdapters.adminSearchViewTableAdapter();
			this.searchStudentNameToolStrip = new System.Windows.Forms.ToolStrip();
			this.studentNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.studentNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchStudentNameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.searchStudentSurnameToolStrip = new System.Windows.Forms.ToolStrip();
			this.surnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this.surnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
			this.searchStudentSurnameToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.resetFiltersToolStrip = new System.Windows.Forms.ToolStrip();
			this.resetFiltersToolStripButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adminSearchViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adminSearchViewDataSet)).BeginInit();
			this.searchStudentNameToolStrip.SuspendLayout();
			this.searchStudentSurnameToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.resetFiltersToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToOrderColumns = true;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSearch.AutoGenerateColumns = false;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.borrowDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn});
			this.dgvSearch.DataSource = this.adminSearchViewBindingSource;
			this.dgvSearch.Location = new System.Drawing.Point(12, 148);
			this.dgvSearch.Margin = new System.Windows.Forms.Padding(0);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.Size = new System.Drawing.Size(679, 293);
			this.dgvSearch.TabIndex = 11;
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
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author Name";
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book Name";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
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
			// adminSearchViewBindingSource
			// 
			this.adminSearchViewBindingSource.DataMember = "adminSearchView";
			this.adminSearchViewBindingSource.DataSource = this.adminSearchViewDataSet;
			// 
			// adminSearchViewDataSet
			// 
			this.adminSearchViewDataSet.DataSetName = "adminSearchViewDataSet";
			this.adminSearchViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(12, 3);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 12;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// adminSearchViewTableAdapter
			// 
			this.adminSearchViewTableAdapter.ClearBeforeFill = true;
			// 
			// searchStudentNameToolStrip
			// 
			this.searchStudentNameToolStrip.AutoSize = false;
			this.searchStudentNameToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchStudentNameToolStrip.BackgroundImage")));
			this.searchStudentNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchStudentNameToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchStudentNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentNameToolStripLabel,
            this.studentNameToolStripTextBox,
            this.searchStudentNameToolStripButton});
			this.searchStudentNameToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.searchStudentNameToolStrip.Location = new System.Drawing.Point(12, 60);
			this.searchStudentNameToolStrip.Name = "searchStudentNameToolStrip";
			this.searchStudentNameToolStrip.Size = new System.Drawing.Size(291, 34);
			this.searchStudentNameToolStrip.TabIndex = 15;
			this.searchStudentNameToolStrip.Text = "searchStudentNameToolStrip";
			// 
			// studentNameToolStripLabel
			// 
			this.studentNameToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.studentNameToolStripLabel.Name = "studentNameToolStripLabel";
			this.studentNameToolStripLabel.Size = new System.Drawing.Size(80, 27);
			this.studentNameToolStripLabel.Text = "Name: ";
			// 
			// studentNameToolStripTextBox
			// 
			this.studentNameToolStripTextBox.Margin = new System.Windows.Forms.Padding(27, 5, 1, 0);
			this.studentNameToolStripTextBox.Name = "studentNameToolStripTextBox";
			this.studentNameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
			// 
			// searchStudentNameToolStripButton
			// 
			this.searchStudentNameToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.searchStudentNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchStudentNameToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchStudentNameToolStripButton.Margin = new System.Windows.Forms.Padding(27, 1, 0, 2);
			this.searchStudentNameToolStripButton.Name = "searchStudentNameToolStripButton";
			this.searchStudentNameToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchStudentNameToolStripButton.Text = "Search";
			this.searchStudentNameToolStripButton.Click += new System.EventHandler(this.SearchStudentNameToolStripButton_Click);
			// 
			// searchStudentSurnameToolStrip
			// 
			this.searchStudentSurnameToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchStudentSurnameToolStrip.BackgroundImage")));
			this.searchStudentSurnameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.searchStudentSurnameToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.searchStudentSurnameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surnameToolStripLabel,
            this.surnameToolStripTextBox,
            this.searchStudentSurnameToolStripButton});
			this.searchStudentSurnameToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.searchStudentSurnameToolStrip.Location = new System.Drawing.Point(12, 103);
			this.searchStudentSurnameToolStrip.Name = "searchStudentSurnameToolStrip";
			this.searchStudentSurnameToolStrip.Size = new System.Drawing.Size(291, 34);
			this.searchStudentSurnameToolStrip.TabIndex = 16;
			this.searchStudentSurnameToolStrip.Text = "searchStudentSurnameToolStrip";
			// 
			// surnameToolStripLabel
			// 
			this.surnameToolStripLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.surnameToolStripLabel.Name = "surnameToolStripLabel";
			this.surnameToolStripLabel.Size = new System.Drawing.Size(107, 27);
			this.surnameToolStripLabel.Text = "Surname: ";
			// 
			// surnameToolStripTextBox
			// 
			this.surnameToolStripTextBox.Margin = new System.Windows.Forms.Padding(1, 5, 1, 0);
			this.surnameToolStripTextBox.Name = "surnameToolStripTextBox";
			this.surnameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
			// 
			// searchStudentSurnameToolStripButton
			// 
			this.searchStudentSurnameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.searchStudentSurnameToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(45)))));
			this.searchStudentSurnameToolStripButton.Name = "searchStudentSurnameToolStripButton";
			this.searchStudentSurnameToolStripButton.Size = new System.Drawing.Size(81, 31);
			this.searchStudentSurnameToolStripButton.Text = "Search";
			this.searchStudentSurnameToolStripButton.Click += new System.EventHandler(this.SearchStudentSurnameToolStripButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(491, 94);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.ResetFiltersToolStripButton_Click);
			// 
			// resetFiltersToolStrip
			// 
			this.resetFiltersToolStrip.AutoSize = false;
			this.resetFiltersToolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetFiltersToolStrip.BackgroundImage")));
			this.resetFiltersToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.resetFiltersToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.resetFiltersToolStrip.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.resetFiltersToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.resetFiltersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetFiltersToolStripButton});
			this.resetFiltersToolStrip.Location = new System.Drawing.Point(344, 94);
			this.resetFiltersToolStrip.Name = "resetFiltersToolStrip";
			this.resetFiltersToolStrip.Size = new System.Drawing.Size(212, 43);
			this.resetFiltersToolStrip.TabIndex = 22;
			this.resetFiltersToolStrip.Text = "resetFiltersToolStrip";
			// 
			// resetFiltersToolStripButton
			// 
			this.resetFiltersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.resetFiltersToolStripButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.resetFiltersToolStripButton.Name = "resetFiltersToolStripButton";
			this.resetFiltersToolStripButton.Size = new System.Drawing.Size(136, 40);
			this.resetFiltersToolStripButton.Text = "Reset Filters";
			this.resetFiltersToolStripButton.Click += new System.EventHandler(this.ResetFiltersToolStripButton_Click);
			// 
			// searchStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(700, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.searchStudentSurnameToolStrip);
			this.Controls.Add(this.searchStudentNameToolStrip);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dgvSearch);
			this.Controls.Add(this.resetFiltersToolStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(700, 450);
			this.MinimumSize = new System.Drawing.Size(700, 450);
			this.Name = "searchStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "searchStudent";
			this.Load += new System.EventHandler(this.SearchStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adminSearchViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adminSearchViewDataSet)).EndInit();
			this.searchStudentNameToolStrip.ResumeLayout(false);
			this.searchStudentNameToolStrip.PerformLayout();
			this.searchStudentSurnameToolStrip.ResumeLayout(false);
			this.searchStudentSurnameToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.resetFiltersToolStrip.ResumeLayout(false);
			this.resetFiltersToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSearch;
		private System.Windows.Forms.Button btnBack;
		private adminSearchViewDataSet adminSearchViewDataSet;
		private System.Windows.Forms.BindingSource adminSearchViewBindingSource;
		private adminSearchViewDataSetTableAdapters.adminSearchViewTableAdapter adminSearchViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStrip searchStudentNameToolStrip;
		private System.Windows.Forms.ToolStripLabel studentNameToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox studentNameToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchStudentNameToolStripButton;
		private System.Windows.Forms.ToolStrip searchStudentSurnameToolStrip;
		private System.Windows.Forms.ToolStripLabel surnameToolStripLabel;
		private System.Windows.Forms.ToolStripTextBox surnameToolStripTextBox;
		private System.Windows.Forms.ToolStripButton searchStudentSurnameToolStripButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip resetFiltersToolStrip;
		private System.Windows.Forms.ToolStripButton resetFiltersToolStripButton;
	}
}