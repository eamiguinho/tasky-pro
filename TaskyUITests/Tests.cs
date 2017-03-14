using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TaskyUITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void TestAddTask()
		{
			app.WaitForElement(c => c.Id("AddButton"));
			app.Tap(c => c.Id("AddButton"));
			app.Screenshot("When I add a new task called '" + "Get Milk" + "'");
			app.WaitForElement(c => c.Id("NameText"));
			app.EnterText(c => c.Id("NameText"), "Get Milk");
			app.Screenshot("When I add a new task called '" + "Get Milk" + "'");
			app.Tap(c => c.Id("SaveButton"));
		}
	}
}
