using System;
using System.Reflection;
using System.ServiceProcess;

namespace RuslanSh.WinSvc.Net
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				if (args.Length > 0)
				{
					switch (args[0])
					{
						case "/i":
							System.Configuration.Install.ManagedInstallerClass.InstallHelper(new[]
								{Assembly.GetExecutingAssembly().Location});
							return;
						case "/u":
							System.Configuration.Install.ManagedInstallerClass.InstallHelper(new[]
								{"/u", Assembly.GetExecutingAssembly().Location});
							return;
						case "/d":
							var myService = new MyService();
							myService.OnDebug();
							System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
							return;
						default:
							throw new ArgumentException("Unexpected command line argument '" + args[0] + "'");
					}
				}
				var servicesToRun = new ServiceBase[] { new MyService() };
				ServiceBase.Run(servicesToRun);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}
