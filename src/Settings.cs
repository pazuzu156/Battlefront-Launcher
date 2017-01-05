using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Star_Wars_Battlefront_Launcher
{
	public class Settings
	{
		private string SettingsFile;

		public JsonData data;

		public Settings()
		{
			SettingsFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				+ "\\bflauncher.json";

			if (Exists())
				Load();
			else
				Create();
		}

		public void Save()
		{
			if (Exists()) File.Delete(SettingsFile);

			FileStream fs = File.Open(SettingsFile, FileMode.OpenOrCreate, FileAccess.Write);
			using (var writer = new StreamWriter(fs))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					Resolution = new
					{
						x = data.resolution.x,
						y = data.resolution.y
					},
					Options = new
					{
						skipIntro = data.options.skipIntro,
						windowed = data.options.windowed,
						closeOnLaunch = data.options.closeOnLaunch
					}
				});

				writer.Write(json);
			}
		}

		#region Private Methods
		private void Create()
		{
			this.data = new JsonData();
			this.data.resolution = new Resolution();
			this.data.options = new Options();

			// Setting application defaults
			this.data.resolution.x = 800;
			this.data.resolution.y = 600;
			this.data.options.skipIntro = false;
			this.data.options.windowed = false;
			this.data.options.closeOnLaunch = false;

			this.Save();
		}

		private void Load()
		{
			FileStream fs = File.Open(SettingsFile, FileMode.Open, FileAccess.Read);
			using (var reader = new StreamReader(fs))
			{
				data = new JavaScriptSerializer().Deserialize<JsonData>(reader.ReadToEnd());
			}
		}

		private bool Exists()
		{
			return File.Exists(SettingsFile);
		}
		#endregion
	}

	public class Resolution
	{
		public int x { get; set; }
		public int y { get; set; }
	}

	public class Options
	{
		public bool skipIntro { get; set; }
		public bool windowed { get; set; }
		public bool closeOnLaunch { get; set; }
	}

	public class JsonData
	{
		public Resolution resolution { get; set; }
		public Options options { get; set; }
	}
}
