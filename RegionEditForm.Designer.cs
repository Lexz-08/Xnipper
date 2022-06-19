namespace Xnipper
{
	partial class RegionEditForm
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
			this.pnlCaptionBar = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.lblConfirmRegion = new System.Windows.Forms.Label();
			this.lblCancel = new System.Windows.Forms.Label();
			this.lblX = new System.Windows.Forms.Label();
			this.numX = new System.Windows.Forms.NumericUpDown();
			this.numY = new System.Windows.Forms.NumericUpDown();
			this.lblY = new System.Windows.Forms.Label();
			this.numH = new System.Windows.Forms.NumericUpDown();
			this.lblHeight = new System.Windows.Forms.Label();
			this.numW = new System.Windows.Forms.NumericUpDown();
			this.lblWidth = new System.Windows.Forms.Label();
			this.pnlCaptionBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numW)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlCaptionBar
			// 
			this.pnlCaptionBar.BackColor = System.Drawing.Color.Gainsboro;
			this.pnlCaptionBar.Controls.Add(this.lblTitle);
			this.pnlCaptionBar.Controls.Add(this.picIcon);
			this.pnlCaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCaptionBar.Location = new System.Drawing.Point(0, 0);
			this.pnlCaptionBar.Name = "pnlCaptionBar";
			this.pnlCaptionBar.Size = new System.Drawing.Size(274, 34);
			this.pnlCaptionBar.TabIndex = 0;
			this.pnlCaptionBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(30, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(118, 15);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Edit Selection Region";
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// picIcon
			// 
			this.picIcon.Location = new System.Drawing.Point(6, 6);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(22, 22);
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			this.picIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// lblConfirmRegion
			// 
			this.lblConfirmRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblConfirmRegion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblConfirmRegion.Location = new System.Drawing.Point(173, 138);
			this.lblConfirmRegion.Name = "lblConfirmRegion";
			this.lblConfirmRegion.Size = new System.Drawing.Size(89, 26);
			this.lblConfirmRegion.TabIndex = 1;
			this.lblConfirmRegion.Text = "Confirm";
			this.lblConfirmRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblConfirmRegion.Click += new System.EventHandler(this.ConfirmRegion);
			this.lblConfirmRegion.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
			this.lblConfirmRegion.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
			// 
			// lblCancel
			// 
			this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCancel.Location = new System.Drawing.Point(78, 138);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(89, 26);
			this.lblCancel.TabIndex = 2;
			this.lblCancel.Text = "Cancel";
			this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCancel.Click += new System.EventHandler(this.CancelRegion);
			this.lblCancel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
			this.lblCancel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(12, 60);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(17, 15);
			this.lblX.TabIndex = 3;
			this.lblX.Text = "X:";
			// 
			// numX
			// 
			this.numX.Location = new System.Drawing.Point(35, 58);
			this.numX.Name = "numX";
			this.numX.Size = new System.Drawing.Size(87, 23);
			this.numX.TabIndex = 4;
			// 
			// numY
			// 
			this.numY.Location = new System.Drawing.Point(172, 58);
			this.numY.Name = "numY";
			this.numY.Size = new System.Drawing.Size(87, 23);
			this.numY.TabIndex = 6;
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Location = new System.Drawing.Point(149, 60);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(17, 15);
			this.lblY.TabIndex = 5;
			this.lblY.Text = "Y:";
			// 
			// numH
			// 
			this.numH.Location = new System.Drawing.Point(172, 99);
			this.numH.Name = "numH";
			this.numH.Size = new System.Drawing.Size(87, 23);
			this.numH.TabIndex = 10;
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(149, 101);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(19, 15);
			this.lblHeight.TabIndex = 9;
			this.lblHeight.Text = "H:";
			// 
			// numW
			// 
			this.numW.Location = new System.Drawing.Point(35, 99);
			this.numW.Name = "numW";
			this.numW.Size = new System.Drawing.Size(87, 23);
			this.numW.TabIndex = 8;
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(12, 101);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(21, 15);
			this.lblWidth.TabIndex = 7;
			this.lblWidth.Text = "W:";
			// 
			// RegionEditForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(274, 173);
			this.Controls.Add(this.numH);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.numW);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.numY);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.numX);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.lblCancel);
			this.Controls.Add(this.lblConfirmRegion);
			this.Controls.Add(this.pnlCaptionBar);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegionEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Selection Region";
			this.pnlCaptionBar.ResumeLayout(false);
			this.pnlCaptionBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numW)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlCaptionBar;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblConfirmRegion;
		private System.Windows.Forms.Label lblCancel;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.NumericUpDown numH;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.NumericUpDown numW;
		private System.Windows.Forms.Label lblWidth;
	}
}