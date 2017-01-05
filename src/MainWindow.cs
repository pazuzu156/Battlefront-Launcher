using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Wars_Battlefront_Launcher
{
	public partial class MainWindow : Form
	{
		Settings s;
		Resolution res;
		Options opt;

		uint x;
		uint y;
		bool skip;
		bool windowed;
		bool closeOnLaunch;

		private Process _gameProcess;

		Thread t;

		public MainWindow()
		{
			InitializeComponent();

			// initialize UI with loaded settings
			s = new Settings();
			res = s.data.resolution;
			opt = s.data.options;

			x = (uint)res.x;
			y = (uint)res.y;
			skip = opt.skipIntro;
			windowed = opt.windowed;
			closeOnLaunch = opt.closeOnLaunch;

			tbWidth.Text = x.ToString();
			tbHeight.Text = y.ToString();

			cbSkip.Checked = skip;
			cbWindowed.Checked = windowed;
			cbClose.Checked = closeOnLaunch;
		}

		private void bLaunch_Click(object sender, EventArgs e)
		{
			// Assemble process start info
			ProcessStartInfo psi = new ProcessStartInfo();
			psi.FileName = "BattlefrontGame.exe";

			// windowed mode and skipping intro are cmd arguments
			List<string> argList = new List<string>();

			if (cbSkip.Checked)
				argList.Add("/nointro");
			if (cbWindowed.Checked)
				argList.Add("/win");

			string args = string.Join(" ", argList);

			if (!args.Equals(string.Empty))
				psi.Arguments = args;

			// Check to make sure the game file exists!
			if (File.Exists("BattlefrontGame.exe"))
			{
				// Start process, get process info, and begin thread!
				_gameProcess = Process.Start(psi);

				// Make sure the new process has an ID, we need that!
				if (_gameProcess.Id > 0)
				{
					t = new Thread(T_Apply);
					t.Start();
				}
				else
					MessageBox.Show(@"Error getting the game's process ID. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show(@"""BattlefrontGame.exe"" could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void T_Apply()
		{
			while (!_gameProcess.HasExited)
			{
				PMemReader pmr = new PMemReader();
				pmr.ReadProcessID = (uint)_gameProcess.Id;
				pmr.OpenProcess();

				int bytesRead, bytesWritten;
				byte[] baseBuffer; // Base memory buffer

				uint rPointer = 0x006F3418; // resolution address pointer
				uint xOffset = 0x372; // X offset value
				uint yOffset = 0x374; // Y offset value

				// add memory address of res pointer
				baseBuffer = pmr.ReadProcessMemory((IntPtr)rPointer, 4, out bytesRead);

				// get X address from baseAddress and xOffset
				uint xAddress = BitConverter.ToUInt32(baseBuffer, 0) + xOffset;
				// Get X data from address
				byte[] xData = pmr.ReadProcessMemory((IntPtr)xAddress, 4, out bytesRead);
				// Process X data into the X resolution value
				uint xx = BitConverter.ToUInt16(xData, 0); // Result is USHORT instead of UINT32

				// get Y address from baseAddress and yOffset
				uint yAddress = BitConverter.ToUInt32(baseBuffer, 0) + yOffset;
				// Get Y data from address
				byte[] yData = pmr.ReadProcessMemory((IntPtr)yAddress, 4, out bytesRead);
				// Process Y data into the X resolution value
				uint yy = BitConverter.ToUInt16(yData, 0); // Result is USHORT instead of UINT32

				// The new X and Y are given in the text boxes of the UI
				UInt16 newX = UInt16.Parse(tbWidth.Text);
				UInt16 newY = UInt16.Parse(tbHeight.Text);

				// write X
				pmr.WriteProcessMemory((IntPtr)xAddress, BitConverter.GetBytes(newX), out bytesWritten);

				// write Y
				pmr.WriteProcessMemory((IntPtr)yAddress, BitConverter.GetBytes(newY), out bytesWritten);

				Thread.Sleep(250);
			}

			// prepare to close app if the user has opted to close on launch (after game closes ;))
			if (cbClose.Checked)
				this.Close();

			// Destroy thread
			t.Abort();
			t.Join();
			t = null;
		}

		private void bClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Make changes to settings and save before closing the window
			res.x = int.Parse(tbWidth.Text);
			res.y = int.Parse(tbHeight.Text);
			opt.skipIntro = cbSkip.Checked;
			opt.windowed = cbWindowed.Checked;
			opt.closeOnLaunch = cbClose.Checked;

			s.Save();
		}

		private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://kalebklein.com");
		}

		private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/pazuzu156/Battlefront-Launcher");
		}
	}
}
