using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
	class Router : Device
	{
		private string wifi;

		public Router(string name, string manufacturer, string wifi)
			: base(name, manufacturer)
		{
			this.wifi = wifi;
		}

		public override void Connect()
		{
			base.Connect();
			Console.WriteLine("Роутер " + Name + " раздает " + wifi);
		}

		public override void Disconnect()
		{
			base.Disconnect();
			Console.WriteLine("Роутер выключен");
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("Роутер: " + Name + ", " + _manufacturer + ", Wi-Fi: " + wifi);
		}
	}
}
