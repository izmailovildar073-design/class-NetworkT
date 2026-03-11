using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Network<T> where T : IConnectable
	{
		// Статическое поле для подсчета всех устройств
		private static int totalDevicesCount = 0;

		private List<T> devices;
		private string networkName;

		public Network(string name)
		{
			this.networkName = name;
			devices = new List<T>();
			Console.WriteLine("Создана сеть: " + networkName);
		}

		// Добавить устройство
		public void AddDevice(T device)
		{
			devices.Add(device);
			totalDevicesCount++;
			Console.WriteLine("Устройство добавлено. Всего в сети: " + totalDevicesCount);
		}

		// Подключить все устройства
		public void ConnectAll()
		{
			Console.WriteLine("\n--- Подключаю все устройства в " + networkName + " ---");
			for (int i = 0; i < devices.Count; i++)
			{
				devices[i].Connect();
			}
		}

		// Отключить все устройства
		public void DisconnectAll()
		{
			Console.WriteLine("\n--- Отключаю все устройства в " + networkName + " ---");
			for (int i = 0; i < devices.Count; i++)
			{
				devices[i].Disconnect();
			}
		}

		// Получить список подключенных устройств
		public List<T> GetConnectedDevices()
		{
			List<T> connectedList = new List<T>();
			for (int i = 0; i < devices.Count; i++)
			{
				if (devices[i].IsConnected)
				{
					connectedList.Add(devices[i]);
				}
			}
			return connectedList;
		}

		// Показать информацию о всех устройствах
		public void ShowAllDevices()
		{
			Console.WriteLine("\nУстройства в сети:" + networkName + "");
			for (int i = 0; i < devices.Count; i++)
			{
				if (devices[i] is Device)
				{
					Device d = (Device)(object)devices[i];
					d.DisplayInfo();
				}
			}
			Console.WriteLine("Всего устройств: " + devices.Count);
		}

		// Статический метод для показа общего количества
		public static void ShowTotalCount()
		{
			Console.WriteLine("\nВСЕГО УСТРОЙСТВ ВО ВСЕХ СЕТЯХ:" + totalDevicesCount + "");
		}
	}
}