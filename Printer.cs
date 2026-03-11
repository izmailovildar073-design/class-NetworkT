using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
	class Printer : Device
	{
		private string printType;

		public Printer(string name, string manufacturer, string printType)
			: base(name, manufacturer)
		{
			this.printType = printType;
		}

		public override void Connect()
		{
			base.Connect();
			Console.WriteLine("Принтер " + Name + " готов к печати (" + printType + ")");
		}

		public override void DisplayInfo()
		{
			Console.WriteLine("Принтер: " + Name + ", " + _manufacturer + ", тип: " + printType);
		}

		public void Print(string document)
		{
			if (_isConnected)
				Console.WriteLine("Печатаю: " + document);
			else
				Console.WriteLine("Принтер не подключен!");
		}
	}
}
