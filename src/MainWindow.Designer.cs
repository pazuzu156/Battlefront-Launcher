namespace Star_Wars_Battlefront_Launcher
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.bLaunch = new System.Windows.Forms.Button();
			this.cbSkip = new System.Windows.Forms.CheckBox();
			this.bClose = new System.Windows.Forms.Button();
			this.cbClose = new System.Windows.Forms.CheckBox();
			this.cbWindowed = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.linkWebsite = new System.Windows.Forms.LinkLabel();
			this.linkGithub = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "This little applet launches Star Wars Battlefront in\r\nyour chosen resolution";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Width:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Height:";
			// 
			// tbWidth
			// 
			this.tbWidth.Location = new System.Drawing.Point(60, 47);
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(50, 20);
			this.tbWidth.TabIndex = 1;
			// 
			// tbHeight
			// 
			this.tbHeight.Location = new System.Drawing.Point(60, 85);
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(50, 20);
			this.tbHeight.TabIndex = 2;
			// 
			// bLaunch
			// 
			this.bLaunch.Location = new System.Drawing.Point(12, 119);
			this.bLaunch.Name = "bLaunch";
			this.bLaunch.Size = new System.Drawing.Size(100, 25);
			this.bLaunch.TabIndex = 6;
			this.bLaunch.Text = "Launch";
			this.bLaunch.UseVisualStyleBackColor = true;
			this.bLaunch.Click += new System.EventHandler(this.bLaunch_Click);
			// 
			// cbSkip
			// 
			this.cbSkip.AutoSize = true;
			this.cbSkip.Location = new System.Drawing.Point(155, 49);
			this.cbSkip.Name = "cbSkip";
			this.cbSkip.Size = new System.Drawing.Size(70, 17);
			this.cbSkip.TabIndex = 3;
			this.cbSkip.Text = "Skip intro";
			this.cbSkip.UseVisualStyleBackColor = true;
			// 
			// bClose
			// 
			this.bClose.Location = new System.Drawing.Point(155, 119);
			this.bClose.Name = "bClose";
			this.bClose.Size = new System.Drawing.Size(100, 25);
			this.bClose.TabIndex = 7;
			this.bClose.Text = "Quit";
			this.bClose.UseVisualStyleBackColor = true;
			this.bClose.Click += new System.EventHandler(this.bClose_Click);
			// 
			// cbClose
			// 
			this.cbClose.AutoSize = true;
			this.cbClose.Location = new System.Drawing.Point(155, 95);
			this.cbClose.Name = "cbClose";
			this.cbClose.Size = new System.Drawing.Size(95, 17);
			this.cbClose.TabIndex = 5;
			this.cbClose.Text = "Quit on launch";
			this.cbClose.UseVisualStyleBackColor = true;
			// 
			// cbWindowed
			// 
			this.cbWindowed.AutoSize = true;
			this.cbWindowed.Location = new System.Drawing.Point(155, 72);
			this.cbWindowed.Name = "cbWindowed";
			this.cbWindowed.Size = new System.Drawing.Size(107, 17);
			this.cbWindowed.TabIndex = 4;
			this.cbWindowed.Text = "Windowed Mode";
			this.cbWindowed.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "© 2017";
			// 
			// linkWebsite
			// 
			this.linkWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkWebsite.AutoSize = true;
			this.linkWebsite.Location = new System.Drawing.Point(48, 169);
			this.linkWebsite.Name = "linkWebsite";
			this.linkWebsite.Size = new System.Drawing.Size(60, 13);
			this.linkWebsite.TabIndex = 9;
			this.linkWebsite.TabStop = true;
			this.linkWebsite.Text = "Kaleb Klein";
			this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
			// 
			// linkGithub
			// 
			this.linkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkGithub.AutoSize = true;
			this.linkGithub.Location = new System.Drawing.Point(174, 169);
			this.linkGithub.Name = "linkGithub";
			this.linkGithub.Size = new System.Drawing.Size(81, 13);
			this.linkGithub.TabIndex = 10;
			this.linkGithub.TabStop = true;
			this.linkGithub.Text = "View on GitHub";
			this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 191);
			this.Controls.Add(this.linkGithub);
			this.Controls.Add(this.linkWebsite);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbWindowed);
			this.Controls.Add(this.cbClose);
			this.Controls.Add(this.bClose);
			this.Controls.Add(this.cbSkip);
			this.Controls.Add(this.bLaunch);
			this.Controls.Add(this.tbHeight);
			this.Controls.Add(this.tbWidth);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Launcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbWidth;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.Button bLaunch;
		private System.Windows.Forms.CheckBox cbSkip;
		private System.Windows.Forms.Button bClose;
		private System.Windows.Forms.CheckBox cbClose;
		private System.Windows.Forms.CheckBox cbWindowed;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkWebsite;
		private System.Windows.Forms.LinkLabel linkGithub;
	}
}