using ConsoleApp2;
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Console.WriteLine("Устройства:\n");

		//Создание устройств
		Printer printer1 = new Printer("HP LaserJet", "HP", "лазерный");
		Printer printer2 = new Printer("Canon", "Canon", "струйный");
		Scanner scanner1 = new Scanner("Epson", "Epson", 1200);
		Router router1 = new Router("TP-Link", "TP-Link", "Wi-Fi 6");
		Router router2 = new Router("ASUS", "ASUS", "Wi-Fi 5");

		Network<Printer> printerNetwork = new Network<Printer>("Принтеры");
		Network<Scanner> scannerNetwork = new Network<Scanner>("Сканеры");
		Network<Router> routerNetwork = new Network<Router>("Роутеры");

		// Добавляю устройства в сети
		printerNetwork.AddDevice(printer1);
		printerNetwork.AddDevice(printer2);

		scannerNetwork.AddDevice(scanner1);

		routerNetwork.AddDevice(router1);
		routerNetwork.AddDevice(router2);

		// Показываю устройства
		printerNetwork.ShowAllDevices();
		scannerNetwork.ShowAllDevices();
		routerNetwork.ShowAllDevices();

		// Подключаю все устройства
		Console.WriteLine("\nПОДКЛЮЧЕНИЕ УСТРОЙСТВ");
		printerNetwork.ConnectAll();
		scannerNetwork.ConnectAll();
		routerNetwork.ConnectAll();

		// Проверяю работу устройств
		Console.WriteLine("\nТЕСТИРОВАНИЕ");
		printer1.Print("dokument.pdf");
		printer2.Print("foto.jpg");
		scanner1.Scan("skan1.png");

		// Получаю список подключенных
		Console.WriteLine("\nПОДКЛЮЧЕННЫЕ УСТРОЙСТВА");
		List<Printer> connectedPrinters = printerNetwork.GetConnectedDevices();
		Console.WriteLine("Принтеров подключено: " + connectedPrinters.Count);

		List<Scanner> connectedScanners = scannerNetwork.GetConnectedDevices();
		Console.WriteLine("Сканеров подключено: " + connectedScanners.Count);

		List<Router> connectedRouters = routerNetwork.GetConnectedDevices();
		Console.WriteLine("Роутеров подключено: " + connectedRouters.Count);

		// Отключаю все
		Console.WriteLine("\nОТКЛЮЧЕНИЕ ВСЕХ УСТРОЙСТВ");
		printerNetwork.DisconnectAll();
		scannerNetwork.DisconnectAll();
		routerNetwork.DisconnectAll();

		// Проверяю сколько подключено теперь
		List<Printer> afterDisconnect = printerNetwork.GetConnectedDevices();
		Console.WriteLine("\nПосле отключения принтеров: " + afterDisconnect.Count);

		// Показываю общее количество
		Network<Printer>.ShowTotalCount();

		Console.WriteLine("\nРАБОТА ЗАВЕРШЕНА");
		Console.ReadKey();
	}
}