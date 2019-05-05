namespace LibraryManagementSystem.User
{
	partial class UserProfile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
			this.dgvBorrowDisplay = new System.Windows.Forms.DataGridView();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.takenDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.broughtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBorrowViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userBorrowDataSet = new LibraryManagementSystem.userBorrowDataSet();
			this.btnBack = new System.Windows.Forms.Button();
			this.userBorrowViewTableAdapter = new LibraryManagementSystem.userBorrowDataSetTableAdapters.userBorrowViewTableAdapter();
			this.btnReturn = new LollipopButton();
			this.lblDue = new System.Windows.Forms.Label();
			this.lblRemaining = new System.Windows.Forms.Label();
			this.lblCharge = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrowDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBorrowDisplay
			// 
			this.dgvBorrowDisplay.AutoGenerateColumns = false;
			this.dgvBorrowDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBorrowDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(237)))));
			this.dgvBorrowDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBorrowDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.authorSurnameDataGridViewTextBoxColumn,
            this.takenDateDataGridViewTextBoxColumn,
            this.broughtDateDataGridViewTextBoxColumn});
			this.dgvBorrowDisplay.DataSource = this.userBorrowViewBindingSource;
			this.dgvBorrowDisplay.Location = new System.Drawing.Point(12, 96);
			this.dgvBorrowDisplay.Name = "dgvBorrowDisplay";
			this.dgvBorrowDisplay.Size = new System.Drawing.Size(756, 292);
			this.dgvBorrowDisplay.TabIndex = 1;
			this.dgvBorrowDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBorrowDisplay_CellClick);
			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "studentName";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			// 
			// studentSurnameDataGridViewTextBoxColumn
			// 
			this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "studentSurname";
			this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "studentSurname";
			this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "bookName";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			// 
			// authorNameDataGridViewTextBoxColumn
			// 
			this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName";
			this.authorNameDataGridViewTextBoxColumn.HeaderText = "authorName";
			this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
			// 
			// authorSurnameDataGridViewTextBoxColumn
			// 
			this.authorSurnameDataGridViewTextBoxColumn.DataPropertyName = "authorSurname";
			this.authorSurnameDataGridViewTextBoxColumn.HeaderText = "authorSurname";
			this.authorSurnameDataGridViewTextBoxColumn.Name = "authorSurnameDataGridViewTextBoxColumn";
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
			// userBorrowViewBindingSource
			// 
			this.userBorrowViewBindingSource.DataMember = "userBorrowView";
			this.userBorrowViewBindingSource.DataSource = this.userBorrowDataSet;
			// 
			// userBorrowDataSet
			// 
			this.userBorrowDataSet.DataSetName = "userBorrowDataSet";
			this.userBorrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(12, 12);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(39, 38);
			this.btnBack.TabIndex = 14;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// userBorrowViewTableAdapter
			// 
			this.userBorrowViewTableAdapter.ClearBeforeFill = true;
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.Transparent;
			this.btnReturn.BGColor = "#89f91e";
			this.btnReturn.FontColor = "#ff0000";
			this.btnReturn.Location = new System.Drawing.Point(612, 21);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(156, 48);
			this.btnReturn.TabIndex = 22;
			this.btnReturn.Text = "RETURN";
			this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
			// 
			// lblDue
			// 
			this.lblDue.AutoSize = true;
			this.lblDue.BackColor = System.Drawing.Color.Transparent;
			this.lblDue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(225)))));
			this.lblDue.Location = new System.Drawing.Point(139, 15);
			this.lblDue.Name = "lblDue";
			this.lblDue.Size = new System.Drawing.Size(44, 27);
			this.lblDue.TabIndex = 16;
			this.lblDue.Text = "due";
			// 
			// lblRemaining
			// 
			this.lblRemaining.AutoSize = true;
			this.lblRemaining.BackColor = System.Drawing.Color.Transparent;
			this.lblRemaining.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(225)))));
			this.lblRemaining.Location = new System.Drawing.Point(139, 56);
			this.lblRemaining.Name = "lblRemaining";
			this.lblRemaining.Size = new System.Drawing.Size(145, 27);
			this.lblRemaining.TabIndex = 16;
			this.lblRemaining.Text = "Remaining Day";
			// 
			// lblCharge
			// 
			this.lblCharge.AutoSize = true;
			this.lblCharge.BackColor = System.Drawing.Color.Transparent;
			this.lblCharge.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(102)))), ((int)(((byte)(225)))));
			this.lblCharge.Location = new System.Drawing.Point(463, 33);
			this.lblCharge.Name = "lblCharge";
			this.lblCharge.Size = new System.Drawing.Size(107, 27);
			this.lblCharge.TabIndex = 16;
			this.lblCharge.Text = "No charge";
			// 
			// UserProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(780, 400);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.lblRemaining);
			this.Controls.Add(this.lblCharge);
			this.Controls.Add(this.lblDue);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.dgvBorrowDisplay);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(780, 400);
			this.MinimumSize = new System.Drawing.Size(780, 400);
			this.Name = "UserProfile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserProfile";
			this.Load += new System.EventHandler(this.UserProfile_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBorrowDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnBack;
		public System.Windows.Forms.DataGridView dgvBorrowDisplay;
		private userBorrowDataSet userBorrowDataSet;
		private System.Windows.Forms.BindingSource userBorrowViewBindingSource;
		private userBorrowDataSetTableAdapters.userBorrowViewTableAdapter userBorrowViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn takenDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn broughtDateDataGridViewTextBoxColumn;
		public LollipopButton btnReturn;
		public System.Windows.Forms.Label lblDue;
		public System.Windows.Forms.Label lblRemaining;
		public System.Windows.Forms.Label lblCharge;
	}
}