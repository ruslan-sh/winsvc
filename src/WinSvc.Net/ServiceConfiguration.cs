using System;
using System.Configuration;
using System.Reflection;

namespace RuslanSh.WinSvc.Net
{
	public static class ServiceConfiguration
	{
		public static string ServiceName => GetConfigurationValue("ServiceName", "MyService");

		private static string GetConfigurationValue(string key, string defaultValue = null)
		{
			var service = Assembly.GetAssembly(typeof(ProjectInstaller));
			var config = ConfigurationManager.OpenExeConfiguration(service.Location);
			if (config.AppSettings.Settings[key] != null) 
				return config.AppSettings.Settings[key].Value;
			
			if (defaultValue == null)
				throw new IndexOutOfRangeException("Settings collection does not contain the requested key: " + key);
			
			config.AppSettings.Settings.Add(key, defaultValue);
			return defaultValue;
		}
	}
}
