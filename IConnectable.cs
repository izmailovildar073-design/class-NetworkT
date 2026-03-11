using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	interface IConnectable
	{
		void Connect();
		void Disconnect();
		bool IsConnected { get; }
	}
}
