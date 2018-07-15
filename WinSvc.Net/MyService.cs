using System;
using System.ServiceProcess;

namespace RuslanSh.WinSvc.Net
{
	public partial class MyService : ServiceBase
	{
		public MyService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			throw new NotImplementedException($"{ServiceName} starts!");
		}

		protected override void OnStop()
		{
			throw new NotImplementedException($"{ServiceName} stops!");
		}

		public void OnDebug()
		{
			OnStart(null);
		}
	}
}
