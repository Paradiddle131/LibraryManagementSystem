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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserControl));
			this.btnSearchByAuthor = new LollipopButton();
			this.lollipopLabel1 = new LollipopLabel();
			this.SuspendLayout();
			// 
			// btnSearchByAuthor
			// 
			this.btnSearchByAuthor.BackColor = System.Drawing.Color.Transparent;
			this.btnSearchByAuthor.BGColor = "#508ef5";
			this.btnSearchByAuthor.FontColor = "#ffffff";
			this.btnSearchByAuthor.Location = new System.Drawing.Point(31, 122);
			this.btnSearchByAuthor.Name = "btnSearchByAuthor";
			this.btnSearchByAuthor.Size = new System.Drawing.Size(143, 41);
			this.btnSearchByAuthor.TabIndex = 0;
			this.btnSearchByAuthor.Text = "lollipopButton1";
			this.btnSearchByAuthor.Click += new System.EventHandler(this.btnSearchByAuthor_Click);
			// 
			// lollipopLabel1
			// 
			this.lollipopLabel1.AutoSize = true;
			this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
			this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
			this.lollipopLabel1.Location = new System.Drawing.Point(27, 87);
			this.lollipopLabel1.Name = "lollipopLabel1";
			this.lollipopLabel1.Size = new System.Drawing.Size(119, 17);
			this.lollipopLabel1.TabIndex = 1;
			this.lollipopLabel1.Text = "Search By Author";
			// 
			// SearchUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.lollipopLabel1);
			this.Controls.Add(this.btnSearchByAuthor);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SearchUserControl";
			this.Size = new System.Drawing.Size(800, 325);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource booksBindingSource;
		private System.Windows.Forms.BindingSource searchDataSetBindingSource;
		private SearchDataSet searchDataSet;
		private LollipopButton btnSearchByAuthor;
		private LollipopLabel lollipopLabel1;
	}
}
