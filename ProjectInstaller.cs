using System.ComponentModel;
using System.ServiceProcess;

namespace RuslanSh.WinSvc
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		public ProjectInstaller()
		{
			InitializeComponent();
			var serviceName = ServiceConfiguration.ServiceName;
			serviceInstaller.ServiceName = serviceName;
			serviceInstaller.DisplayName = serviceName;
			AfterInstall += (sender, args) =>
			{
				using (var sc = new ServiceController(serviceInstaller.ServiceName))
				{
					sc.Start();
				}
			};
		}
	}
}
