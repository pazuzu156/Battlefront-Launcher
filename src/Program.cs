using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Globalization;

namespace Star_Wars_Battlefront_Launcher
{
	class Program
	{
		private Mutex _mutex;

		public Program()
		{
			// Just some fun code for making the application a single instance app
			var a = Assembly.GetExecutingAssembly();
			bool mutexCreated;
			var mutexName = string.Format(CultureInfo.InvariantCulture, "Local\\{{{0}}}{{{1}}}",
				a.GetType().GUID, a.GetName().Name);

			_mutex = new Mutex(true, mutexName, out mutexCreated);

			if (!mutexCreated)
			{
				_mutex = null;
				MessageBox.Show("You can only have one instance of the application open at a time!", "Multi-Instance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
				return;
			}

			Application.Run(new MainWindow());
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Program p = new Program();
		}
	}
}
