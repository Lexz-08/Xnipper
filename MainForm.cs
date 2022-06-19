using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Xnipper
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			m_aeroEnabled = false;

			Bitmap iconBmp = new Bitmap(picIcon.Width, picIcon.Height);

			using (Graphics g = Graphics.FromImage(iconBmp))
				g.DrawIcon(Icon, new Rectangle(0, 0, picIcon.Width, picIcon.Height));

			picIcon.Image = iconBmp;

			RegisterHotKey(Handle, 0, Modifiers.Alt | Modifiers.Shift, Keys.D1);
			RegisterHotKey(Handle, 1, Modifiers.Alt | Modifiers.Shift, Keys.D2);
			RegisterHotKey(Handle, 2, Modifiers.Alt | Modifiers.Shift, Keys.S);

			regionPoint1 = new Point(imageRegion.X, imageRegion.Y);
			regionPoint2 = new Point(imageRegion.X + imageRegion.Width, imageRegion.Y + imageRegion.Height);

			int index = 0;
			foreach (Screen screen in Screen.AllScreens)
			{
				ToolStripMenuItem displayMenuItem = new ToolStripMenuItem();
				displayMenuItem.Name = $"display{index + 1}ToolStripMenuItem";
				displayMenuItem.Text = $"Display {index + 1}";
				displayMenuItem.Click += (s, e) =>
				{
					imageRegion = screen.Bounds;
				};
				viewToolStripMenuItem.DropDownItems.Insert(viewToolStripMenuItem.DropDownItems.Count - 2, displayMenuItem);

				index++;
			}
		}

		[Flags]
		private enum Modifiers
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
		}

		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int Id, Modifiers fsModifiers, Keys vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int Id);

		private Rectangle imageRegion = Screen.PrimaryScreen.Bounds;
		private Point regionPoint1, regionPoint2;
		private Image screenshot;

		private Dictionary<string, int> resizeBorders = new Dictionary<string, int>
		{
			{ "Left1", 10 },
			{ "Left2", 10 },
			{ "Left3", 10 },
			{ "Right1", 11 },
			{ "Right2", 11 },
			{ "Right3", 11 },
			{ "Top", 12 },
			{ "TopLeft", 13 },
			{ "TopRight", 14 },
			{ "Bottom", 15 },
			{ "BottomLeft", 16 },
			{ "BottomRight", 17 },
		};

		private void CalculateImageRegion()
		{
			// taken from:
			// https://stackoverflow.com/questions/4103943/how-to-create-a-rectanglef-using-two-pointf

			imageRegion = new Rectangle(
				Math.Min(regionPoint1.X, regionPoint2.X),
				Math.Min(regionPoint1.Y, regionPoint2.Y),
				Math.Abs(regionPoint1.X - regionPoint2.X),
				Math.Abs(regionPoint1.Y - regionPoint2.Y)
				);
		}

		private void TakeScreenshot()
		{
			screenshot = new Bitmap(imageRegion.Width, imageRegion.Height);

			using (Graphics g = Graphics.FromImage(screenshot))
				g.CopyFromScreen(imageRegion.Location, new Point(0, 0), imageRegion.Size, CopyPixelOperation.SourceCopy);

			picScreenshot.Image = screenshot;

			GC.Collect();
		}

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private void ResizeForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, resizeBorders[((PictureBox)sender).Name.Substring(3)], 0);
			}
		}

		private void CloseForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				Application.Exit();
		}

		private void MaximizeForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (WindowState == FormWindowState.Maximized)
				{
					WindowState = FormWindowState.Normal;
					lblMaximize.Text = "1";
				}
				else if (WindowState == FormWindowState.Normal)
				{
					WindowState = FormWindowState.Maximized;
					lblMaximize.Text = "2";
				}
			}
		}

		private void MinimizeForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				WindowState = FormWindowState.Minimized;
		}

		private void CloseForm_Enter(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.Silver;
		}
		private void CloseForm_Leave(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.Gainsboro;
		}

		private void MaximizeForm_Enter(object sender, EventArgs e)
		{
			lblMaximize.BackColor = Color.Silver;
		}
		private void MaximizeForm_Leave(object sender, EventArgs e)
		{
			lblMaximize.BackColor = Color.Gainsboro;
		}

		private void MinimizeForm_Enter(object sender, EventArgs e)
		{
			lblMinimize.BackColor = Color.Silver;
		}
		private void MinimizeForm_Leave(object sender, EventArgs e)
		{
			lblMinimize.BackColor = Color.Gainsboro;
		}

		private void TakeScreenshot_Click(object sender, EventArgs e)
		{
			TakeScreenshot();
		}

		private void EditRegion_Click(object sender, EventArgs e)
		{
			using (RegionEditForm regionEdit = new RegionEditForm(this, imageRegion))
			{
				regionEdit.ShowDialog();

				if (regionEdit.Confirmed)
					imageRegion = regionEdit.ImageRegion;
			}
		}

		private void DisplayShortcuts_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Take Screenshot: Alt + Shift + S\n" +
				"Set Region Point #1: Alt + Shift + 1\n" +
				"Set Region Point #2: Alt + Shift + 2", "Xnipper Shortcuts",
				MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void ResetScreenshot_Click(object sender, EventArgs e)
		{
			screenshot = null;
			picScreenshot.Image = null;
		}

		private void SaveScreenshot_Click(object sender, EventArgs e)
		{
			if (screenshot != null)
			{
				using (SaveFileDialog sfd = new SaveFileDialog
				{
					Title = "Please choose where to save the screenshot...",
					Filter = "Image|*.jpeg; *.jpg",
				}) if (sfd.ShowDialog() == DialogResult.OK)
						screenshot.Save(sfd.FileName, ImageFormat.Jpeg);
			}
			else MessageBox.Show("No screenshot was taken.", "No Screenshot To Save",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			UnregisterHotKey(Handle, 0);
			UnregisterHotKey(Handle, 1);
			UnregisterHotKey(Handle, 2);
		}

		[DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hWnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		private bool m_aeroEnabled;

		private struct MARGINS
		{
			public int leftWidth;
			public int rightWidth;
			public int topHeight;
			public int bottomHeight;
		}

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

			if (m.Msg == 0x0312)
			{
				switch ((int)m.WParam)
				{
					case 0:
						regionPoint1 = MousePosition;
						CalculateImageRegion();
						break;
					case 1:
						regionPoint2 = MousePosition;
						CalculateImageRegion();
						break;
					case 2:
						TakeScreenshot();

						picScreenshot.Image = screenshot;
						break;
				}
			}

			base.WndProc(ref m);
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
