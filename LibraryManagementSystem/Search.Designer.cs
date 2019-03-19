namespace dbForLMS
{
	partial class Search
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
			this.txtSaerchUC = new LollipopTextBox();
			this.SuspendLayout();
			// 
			// txtSaerchUC
			// 
			this.txtSaerchUC.FocusedColor = "#508ef5";
			this.txtSaerchUC.FontColor = "#999999";
			this.txtSaerchUC.IsEnabled = true;
			this.txtSaerchUC.Location = new System.Drawing.Point(21, 25);
			this.txtSaerchUC.MaxLength = 32767;
			this.txtSaerchUC.Multiline = false;
			this.txtSaerchUC.Name = "txtSaerchUC";
			this.txtSaerchUC.ReadOnly = false;
			this.txtSaerchUC.Size = new System.Drawing.Size(742, 24);
			this.txtSaerchUC.TabIndex = 1;
			this.txtSaerchUC.Text = "Search for a book with its name, author or category";
			this.txtSaerchUC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSaerchUC.UseSystemPasswordChar = false;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(784, 361);
			this.Controls.Add(this.txtSaerchUC);
			this.Name = "Search";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.ResumeLayout(false);

		}

		#endregion

		private LollipopTextBox txtSaerchUC;
	}
}