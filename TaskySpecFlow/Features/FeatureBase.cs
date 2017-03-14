using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	public class FeatureBase
	{
		protected static IApp app;
		protected Platform platform;

		public FeatureBase(Platform platform)
		{
			this.platform = platform;
		}

		public FeatureBase()
		{

		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			FeatureContext.Current.Add("App", app);
			AppInitializer.InitializeScreens(platform);
		}
	}
}
