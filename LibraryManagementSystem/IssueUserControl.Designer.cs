namespace LibraryManagementSystem
{
	partial class IssueUserControl
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
            this.pnlIssue = new System.Windows.Forms.Panel();
            this.btnAddBook = new LollipopButton();
            this.btnAddAuthor = new LollipopButton();
            this.bookIssueTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet7 = new LibraryManagementSystem.libraryDBDataSet7();
            this.bookIssueTableTableAdapter1 = new LibraryManagementSystem.libraryDBDataSet7TableAdapters.BookIssueTableTableAdapter();
            this.btnAddBorrow = new LollipopButton();
            this.bnAddStudent = new LollipopButton();
            this.btnAddType = new LollipopButton();
            this.pnlIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIssue
            // 
            this.pnlIssue.Controls.Add(this.btnAddType);
            this.pnlIssue.Controls.Add(this.bnAddStudent);
            this.pnlIssue.Controls.Add(this.btnAddBorrow);
            this.pnlIssue.Controls.Add(this.btnAddBook);
            this.pnlIssue.Controls.Add(this.btnAddAuthor);
            this.pnlIssue.Location = new System.Drawing.Point(0, 0);
            this.pnlIssue.Name = "pnlIssue";
            this.pnlIssue.Size = new System.Drawing.Size(793, 317);
            this.pnlIssue.TabIndex = 5;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.BGColor = "#508ef5";
            this.btnAddBook.FontColor = "#ffffff";
            this.btnAddBook.Location = new System.Drawing.Point(206, 31);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(143, 41);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.BGColor = "#508ef5";
            this.btnAddAuthor.FontColor = "#ffffff";
            this.btnAddAuthor.Location = new System.Drawing.Point(42, 31);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(143, 41);
            this.btnAddAuthor.TabIndex = 0;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // bookIssueTableBindingSource1
            // 
            this.bookIssueTableBindingSource1.DataMember = "BookIssueTable";
            this.bookIssueTableBindingSource1.DataSource = this.libraryDBDataSet7;
            // 
            // libraryDBDataSet7
            // 
            this.libraryDBDataSet7.DataSetName = "libraryDBDataSet7";
            this.libraryDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookIssueTableTableAdapter1
            // 
            this.bookIssueTableTableAdapter1.ClearBeforeFill = true;
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBorrow.BGColor = "#508ef5";
            this.btnAddBorrow.FontColor = "#ffffff";
            this.btnAddBorrow.Location = new System.Drawing.Point(374, 31);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(143, 41);
            this.btnAddBorrow.TabIndex = 0;
            this.btnAddBorrow.Text = "Add Borrow";
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // bnAddStudent
            // 
            this.bnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.bnAddStudent.BGColor = "#508ef5";
            this.bnAddStudent.FontColor = "#ffffff";
            this.bnAddStudent.Location = new System.Drawing.Point(542, 31);
            this.bnAddStudent.Name = "bnAddStudent";
            this.bnAddStudent.Size = new System.Drawing.Size(143, 41);
            this.bnAddStudent.TabIndex = 0;
            this.bnAddStudent.Text = "Add Student";
            this.bnAddStudent.Click += new System.EventHandler(this.bnAddStudent_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.BGColor = "#508ef5";
            this.btnAddType.FontColor = "#ffffff";
            this.btnAddType.Location = new System.Drawing.Point(542, 117);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(143, 41);
            this.btnAddType.TabIndex = 0;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // IssueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlIssue);
            this.Name = "IssueUserControl";
            this.Size = new System.Drawing.Size(792, 315);
            this.pnlIssue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet7)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlIssue;
		private System.Windows.Forms.BindingSource bookIssueTableBindingSource1;
		private libraryDBDataSet7 libraryDBDataSet7;
		private libraryDBDataSet7TableAdapters.BookIssueTableTableAdapter bookIssueTableTableAdapter1;
		private LollipopButton btnAddAuthor;
		private LollipopButton btnAddBook;
        private LollipopButton btnAddType;
        private LollipopButton bnAddStudent;
        private LollipopButton btnAddBorrow;
    }
}
