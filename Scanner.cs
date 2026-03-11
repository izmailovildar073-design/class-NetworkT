using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
	class Scanner : Device
	{
		private int resolution;

		public Scanner(string name, string manufacturer, int resolution)
			: base(name, manufacturer)
		{
			this.resolution = resolution;
		}

		public override void Connect()
		{
			base.Connect();
			Console.WriteLine("Сканер " + Name + " готов (разрешение: " + resolution + " DPI)");
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("Сканер: " + Name + ", " + _manufacturer + ", разрешение: " + resolution + " DPI");
		}

		public void Scan(string docName)
		{
			if (_isConnected)
				Console.WriteLine("Сканирую: " + docName);
			else
				Console.WriteLine("Сканер не подключен!");
		}
	}
}
