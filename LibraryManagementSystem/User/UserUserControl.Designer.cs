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
			this.userBorrowViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userBorrowsView = new LibraryManagementSystem.userBorrowsView();
			this.userBorrowViewTableAdapter = new LibraryManagementSystem.userBorrowsViewTableAdapters.userBorrowViewTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowsView)).BeginInit();
			this.SuspendLayout();
			// 
			// userBorrowViewBindingSource
			// 
			this.userBorrowViewBindingSource.DataMember = "userBorrowView";
			this.userBorrowViewBindingSource.DataSource = this.userBorrowsView;
			// 
			// userBorrowsView
			// 
			this.userBorrowsView.DataSetName = "userBorrowsView";
			this.userBorrowsView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userBorrowViewTableAdapter
			// 
			this.userBorrowViewTableAdapter.ClearBeforeFill = true;
			// 
			// UserUserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Name = "UserUserControl1";
			this.Size = new System.Drawing.Size(600, 325);
			((System.ComponentModel.ISupportInitialize)(this.userBorrowViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBorrowsView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource userBorrowViewBindingSource;
		private userBorrowsView userBorrowsView;
		private userBorrowsViewTableAdapters.userBorrowViewTableAdapter userBorrowViewTableAdapter;
	}
}
