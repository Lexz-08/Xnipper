namespace Xnipper
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlCaptionBar = new System.Windows.Forms.Panel();
			this.lblMinimize = new System.Windows.Forms.Label();
			this.lblMaximize = new System.Windows.Forms.Label();
			this.lblClose = new System.Windows.Forms.Label();
			this.picRight1 = new System.Windows.Forms.PictureBox();
			this.picLeft1 = new System.Windows.Forms.PictureBox();
			this.picTop = new System.Windows.Forms.PictureBox();
			this.picTopRight = new System.Windows.Forms.PictureBox();
			this.picTopLeft = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.picBottomLeft = new System.Windows.Forms.PictureBox();
			this.picBottomRight = new System.Windows.Forms.PictureBox();
			this.picLeft2 = new System.Windows.Forms.PictureBox();
			this.picRight2 = new System.Windows.Forms.PictureBox();
			this.picBottom = new System.Windows.Forms.PictureBox();
			this.mnOptions = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.editRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.takeScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.picLeft3 = new System.Windows.Forms.PictureBox();
			this.picRight3 = new System.Windows.Forms.PictureBox();
			this.picScreenshot = new System.Windows.Forms.PictureBox();
			this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlCaptionBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRight1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeft1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomLeft)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomRight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeft2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
			this.mnOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLeft3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCaptionBar
			// 
			this.pnlCaptionBar.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlCaptionBar.Controls.Add(this.lblMinimize);
			this.pnlCaptionBar.Controls.Add(this.lblMaximize);
			this.pnlCaptionBar.Controls.Add(this.lblClose);
			this.pnlCaptionBar.Controls.Add(this.picRight1);
			this.pnlCaptionBar.Controls.Add(this.picLeft1);
			this.pnlCaptionBar.Controls.Add(this.picTop);
			this.pnlCaptionBar.Controls.Add(this.picTopRight);
			this.pnlCaptionBar.Controls.Add(this.picTopLeft);
			this.pnlCaptionBar.Controls.Add(this.lblTitle);
			this.pnlCaptionBar.Controls.Add(this.picIcon);
			this.pnlCaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCaptionBar.Location = new System.Drawing.Point(0, 0);
			this.pnlCaptionBar.Name = "pnlCaptionBar";
			this.pnlCaptionBar.Size = new System.Drawing.Size(548, 34);
			this.pnlCaptionBar.TabIndex = 0;
			this.pnlCaptionBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// lblMinimize
			// 
			this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMinimize.AutoSize = true;
			this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMinimize.Font = new System.Drawing.Font("Webdings", 9F);
			this.lblMinimize.Location = new System.Drawing.Point(467, 8);
			this.lblMinimize.Name = "lblMinimize";
			this.lblMinimize.Size = new System.Drawing.Size(21, 19);
			this.lblMinimize.TabIndex = 12;
			this.lblMinimize.Text = "0";
			this.lblMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeForm);
			this.lblMinimize.MouseEnter += new System.EventHandler(this.MinimizeForm_Enter);
			this.lblMinimize.MouseLeave += new System.EventHandler(this.MinimizeForm_Leave);
			// 
			// lblMaximize
			// 
			this.lblMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMaximize.AutoSize = true;
			this.lblMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMaximize.Font = new System.Drawing.Font("Webdings", 9F);
			this.lblMaximize.Location = new System.Drawing.Point(493, 8);
			this.lblMaximize.Name = "lblMaximize";
			this.lblMaximize.Size = new System.Drawing.Size(21, 19);
			this.lblMaximize.TabIndex = 11;
			this.lblMaximize.Text = "1";
			this.lblMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaximizeForm);
			this.lblMaximize.MouseEnter += new System.EventHandler(this.MaximizeForm_Enter);
			this.lblMaximize.MouseLeave += new System.EventHandler(this.MaximizeForm_Leave);
			// 
			// lblClose
			// 
			this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblClose.AutoSize = true;
			this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblClose.Font = new System.Drawing.Font("Webdings", 9F);
			this.lblClose.Location = new System.Drawing.Point(519, 8);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(21, 19);
			this.lblClose.TabIndex = 10;
			this.lblClose.Text = "r";
			this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseForm);
			this.lblClose.MouseEnter += new System.EventHandler(this.CloseForm_Enter);
			this.lblClose.MouseLeave += new System.EventHandler(this.CloseForm_Leave);
			// 
			// picRight1
			// 
			this.picRight1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picRight1.BackColor = System.Drawing.Color.Gainsboro;
			this.picRight1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picRight1.Location = new System.Drawing.Point(542, 6);
			this.picRight1.Name = "picRight1";
			this.picRight1.Size = new System.Drawing.Size(6, 28);
			this.picRight1.TabIndex = 9;
			this.picRight1.TabStop = false;
			this.picRight1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picLeft1
			// 
			this.picLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.picLeft1.BackColor = System.Drawing.Color.Gainsboro;
			this.picLeft1.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picLeft1.Location = new System.Drawing.Point(0, 6);
			this.picLeft1.Name = "picLeft1";
			this.picLeft1.Size = new System.Drawing.Size(6, 28);
			this.picLeft1.TabIndex = 8;
			this.picLeft1.TabStop = false;
			this.picLeft1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picTop
			// 
			this.picTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picTop.BackColor = System.Drawing.Color.Gainsboro;
			this.picTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.picTop.Location = new System.Drawing.Point(6, 0);
			this.picTop.Name = "picTop";
			this.picTop.Size = new System.Drawing.Size(536, 6);
			this.picTop.TabIndex = 8;
			this.picTop.TabStop = false;
			this.picTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picTopRight
			// 
			this.picTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picTopRight.BackColor = System.Drawing.Color.Gainsboro;
			this.picTopRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.picTopRight.Location = new System.Drawing.Point(542, 0);
			this.picTopRight.Name = "picTopRight";
			this.picTopRight.Size = new System.Drawing.Size(6, 6);
			this.picTopRight.TabIndex = 2;
			this.picTopRight.TabStop = false;
			this.picTopRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picTopLeft
			// 
			this.picTopLeft.BackColor = System.Drawing.Color.Gainsboro;
			this.picTopLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.picTopLeft.Location = new System.Drawing.Point(0, 0);
			this.picTopLeft.Name = "picTopLeft";
			this.picTopLeft.Size = new System.Drawing.Size(6, 6);
			this.picTopLeft.TabIndex = 1;
			this.picTopLeft.TabStop = false;
			this.picTopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Gainsboro;
			this.lblTitle.Location = new System.Drawing.Point(30, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(48, 15);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Xnipper";
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// picIcon
			// 
			this.picIcon.BackColor = System.Drawing.Color.Gainsboro;
			this.picIcon.Location = new System.Drawing.Point(6, 6);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(22, 22);
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// picBottomLeft
			// 
			this.picBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picBottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.picBottomLeft.Location = new System.Drawing.Point(0, 420);
			this.picBottomLeft.Name = "picBottomLeft";
			this.picBottomLeft.Size = new System.Drawing.Size(6, 6);
			this.picBottomLeft.TabIndex = 3;
			this.picBottomLeft.TabStop = false;
			this.picBottomLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picBottomRight
			// 
			this.picBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picBottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.picBottomRight.Location = new System.Drawing.Point(542, 420);
			this.picBottomRight.Name = "picBottomRight";
			this.picBottomRight.Size = new System.Drawing.Size(6, 6);
			this.picBottomRight.TabIndex = 4;
			this.picBottomRight.TabStop = false;
			this.picBottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picLeft2
			// 
			this.picLeft2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.picLeft2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picLeft2.Location = new System.Drawing.Point(0, 58);
			this.picLeft2.Name = "picLeft2";
			this.picLeft2.Size = new System.Drawing.Size(6, 362);
			this.picLeft2.TabIndex = 5;
			this.picLeft2.TabStop = false;
			this.picLeft2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picRight2
			// 
			this.picRight2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picRight2.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picRight2.Location = new System.Drawing.Point(542, 58);
			this.picRight2.Name = "picRight2";
			this.picRight2.Size = new System.Drawing.Size(6, 362);
			this.picRight2.TabIndex = 6;
			this.picRight2.TabStop = false;
			this.picRight2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picBottom
			// 
			this.picBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.picBottom.Location = new System.Drawing.Point(6, 420);
			this.picBottom.Name = "picBottom";
			this.picBottom.Size = new System.Drawing.Size(536, 6);
			this.picBottom.TabIndex = 7;
			this.picBottom.TabStop = false;
			this.picBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// mnOptions
			// 
			this.mnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mnOptions.AutoSize = false;
			this.mnOptions.BackColor = System.Drawing.Color.Gainsboro;
			this.mnOptions.Dock = System.Windows.Forms.DockStyle.None;
			this.mnOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.shortcutsToolStripMenuItem});
			this.mnOptions.Location = new System.Drawing.Point(6, 34);
			this.mnOptions.Name = "mnOptions";
			this.mnOptions.Size = new System.Drawing.Size(536, 24);
			this.mnOptions.TabIndex = 8;
			this.mnOptions.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.resetToolStripMenuItem.Text = "Reset";
			this.resetToolStripMenuItem.ToolTipText = "Resets the currently taken screenshot to a blank image";
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetScreenshot_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.ToolTipText = "Saves the current screenshot to any selected file";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveScreenshot_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editRegionToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// editRegionToolStripMenuItem
			// 
			this.editRegionToolStripMenuItem.Name = "editRegionToolStripMenuItem";
			this.editRegionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editRegionToolStripMenuItem.Text = "Edit Region";
			this.editRegionToolStripMenuItem.ToolTipText = "Edit the screen selection region settings";
			this.editRegionToolStripMenuItem.Click += new System.EventHandler(this.EditRegion_Click);
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeScreenshotToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.manageToolStripMenuItem.Text = "Manage";
			// 
			// takeScreenshotToolStripMenuItem
			// 
			this.takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
			this.takeScreenshotToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
			this.takeScreenshotToolStripMenuItem.Text = "Take Screenshot (Alt+Shift+S)";
			this.takeScreenshotToolStripMenuItem.ToolTipText = "Takes a screenshot of the screen using the current image region";
			this.takeScreenshotToolStripMenuItem.Click += new System.EventHandler(this.TakeScreenshot_Click);
			// 
			// picLeft3
			// 
			this.picLeft3.BackColor = System.Drawing.Color.Gainsboro;
			this.picLeft3.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picLeft3.Location = new System.Drawing.Point(0, 34);
			this.picLeft3.Name = "picLeft3";
			this.picLeft3.Size = new System.Drawing.Size(6, 24);
			this.picLeft3.TabIndex = 9;
			this.picLeft3.TabStop = false;
			this.picLeft3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picRight3
			// 
			this.picRight3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picRight3.BackColor = System.Drawing.Color.Gainsboro;
			this.picRight3.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.picRight3.Location = new System.Drawing.Point(542, 34);
			this.picRight3.Name = "picRight3";
			this.picRight3.Size = new System.Drawing.Size(6, 24);
			this.picRight3.TabIndex = 10;
			this.picRight3.TabStop = false;
			this.picRight3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeForm);
			// 
			// picScreenshot
			// 
			this.picScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picScreenshot.Location = new System.Drawing.Point(6, 58);
			this.picScreenshot.Name = "picScreenshot";
			this.picScreenshot.Size = new System.Drawing.Size(536, 362);
			this.picScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picScreenshot.TabIndex = 11;
			this.picScreenshot.TabStop = false;
			// 
			// shortcutsToolStripMenuItem
			// 
			this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
			this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.shortcutsToolStripMenuItem.Text = "Shortcuts (?)";
			this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.DisplayShortcuts_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(548, 426);
			this.Controls.Add(this.picScreenshot);
			this.Controls.Add(this.picRight3);
			this.Controls.Add(this.picLeft3);
			this.Controls.Add(this.picBottom);
			this.Controls.Add(this.picRight2);
			this.Controls.Add(this.picLeft2);
			this.Controls.Add(this.picBottomRight);
			this.Controls.Add(this.picBottomLeft);
			this.Controls.Add(this.pnlCaptionBar);
			this.Controls.Add(this.mnOptions);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnOptions;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(387, 354);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Xnipper";
			this.pnlCaptionBar.ResumeLayout(false);
			this.pnlCaptionBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picRight1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeft1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomLeft)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottomRight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeft2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
			this.mnOptions.ResumeLayout(false);
			this.mnOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLeft3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picScreenshot)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCaptionBar;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox picTopLeft;
		private System.Windows.Forms.PictureBox picTopRight;
		private System.Windows.Forms.PictureBox picBottomLeft;
		private System.Windows.Forms.PictureBox picBottomRight;
		private System.Windows.Forms.PictureBox picLeft2;
		private System.Windows.Forms.PictureBox picRight2;
		private System.Windows.Forms.PictureBox picBottom;
		private System.Windows.Forms.PictureBox picTop;
		private System.Windows.Forms.PictureBox picRight1;
		private System.Windows.Forms.PictureBox picLeft1;
		private System.Windows.Forms.MenuStrip mnOptions;
		private System.Windows.Forms.PictureBox picLeft3;
		private System.Windows.Forms.PictureBox picRight3;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editRegionToolStripMenuItem;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblMinimize;
		private System.Windows.Forms.Label lblMaximize;
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.PictureBox picScreenshot;
		private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem takeScreenshotToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
	}
}

