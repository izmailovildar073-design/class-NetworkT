using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	abstract class Device : IConnectable
	{
		private string _name;
		protected string _manufacturer;
		protected bool _isConnected;

		public string Name { get; set; }

		public bool IsConnected { get; set; }

		public Device(string name, string manufacturer)
		{
			_name = name;
			_manufacturer = manufacturer;
			_isConnected = false;
		}

		public virtual void Connect()
		{
			_isConnected = true;
			Console.WriteLine(_name + " подключается...");
		}

		public virtual void Disconnect()
		{
			_isConnected = false;
			Console.WriteLine(_name + " отключается...");
		}

		public abstract void DisplayInfo();

		public virtual string GetStatus()
		{
			if (_isConnected)
				return _name + " подключено";
			else
				return _name + " отключено";
		}
	}
}
