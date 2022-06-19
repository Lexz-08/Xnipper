using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Xnipper
{
	public partial class RegionEditForm : Form
	{
		public RegionEditForm(Form ParentForm, Rectangle CurrentSelectionRegion)
		{
			InitializeComponent();

			Icon = ParentForm.Icon;

			Bitmap iconBmp = new Bitmap(picIcon.Width, picIcon.Height);

			using (Graphics g = Graphics.FromImage(iconBmp))
				g.DrawIcon(Icon, new Rectangle(0, 0, picIcon.Width, picIcon.Height));

			picIcon.Image = iconBmp;

			Rectangle total = new Rectangle(0, 0, 0, 0);

			foreach (Screen screen in Screen.AllScreens)
			{
				total.Width += screen.Bounds.Width;

				if (screen.Bounds.Y > 0)
					total.Height += screen.Bounds.Height;
			}

			numX.Minimum = total.X;
			numY.Minimum = total.Y;
			numX.Maximum = total.Width;
			numY.Maximum = total.Height;

			numW.Minimum = 1;
			numH.Minimum = 1;
			numW.Maximum = total.Width;
			numH.Maximum = total.Height;

			numX.Value = CurrentSelectionRegion.X;
			numY.Value = CurrentSelectionRegion.Y;
			numW.Value = CurrentSelectionRegion.Width;
			numH.Value = CurrentSelectionRegion.Height;
		}

		public bool Confirmed { get; private set; } = false;
		public Rectangle ImageRegion { get; private set; }

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private void ConfirmRegion(object sender, EventArgs e)
		{
			Confirmed = true;
			ImageRegion = new Rectangle((int)numX.Value, (int)numY.Value, (int)numW.Value, (int)numH.Value);

			CancelRegion(sender, e);
		}

		private void CancelRegion(object sender, EventArgs e)
		{
			Close();
		}

		private void Button_MouseEnter(object sender, EventArgs e) => ((Label)sender).BackColor = Color.Gainsboro;
		private void Button_MouseLeave(object sender, EventArgs e) => ((Label)sender).BackColor = Color.White;

		[DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		protected override void WndProc(ref Message m)
		{

			if (m_aeroEnabled)
			{
				int v = 2;
				DwmSetWindowAttribute(Handle, 2, ref v, 4);
				MARGINS margins = new MARGINS
				{
					bottomHeight = 0,
					topHeight = 1,
					leftWidth = 0,
					rightWidth = 0,
				};
				DwmExtendFrameIntoClientArea(Handle, ref margins);
			}

			base.WndProc(ref m);
		}

		private bool m_aeroEnabled;

		private struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				m_aeroEnabled = CheckAeroEnabled();

				if (!m_aeroEnabled)
				{
					const int CS_DROPSHADOW = 0x20000;
					cp = base.CreateParams;
					cp.ClassStyle |= CS_DROPSHADOW;
				}

				return cp;
			}
		}

		private bool CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int enabled = 0;
				DwmIsCompositionEnabled(ref enabled);

				return (enabled == 1) ? true : false;
			}

			return false;
		}
	}
}
