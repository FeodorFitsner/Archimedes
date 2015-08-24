namespace Archimedes.Common.Tests
{
	using Xunit;
	using System.Configuration;

	public class BootTests
	{
		[Fact]
		public void Can_Read_App_Config()
		{
			// appSettings
			var someValue = ConfigurationManager.AppSettings["ApplicationName"];
			Console.WriteLine("SomeValue: " + someValue);
			Assert.Equal("Archimedes Testing Project", someValue);
		}
		
		[Fact]
		public void CanBoot()
		{
			Kernel.Boot(BootConfiguration.DefaultConfiguration);
		}
	}
}
