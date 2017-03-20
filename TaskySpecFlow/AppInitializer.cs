using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	public static class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
					.Android
					.EnableLocalScreenshots()
					.StartApp();
			}
			else if (platform == Platform.iOS)
			{
				return ConfigureApp
					.iOS
					.EnableLocalScreenshots()
					.StartApp();
			}
			throw new ArgumentException("Unsupported platform");
		}

		public static void InitializeScreens(Platform platform)
		{
			if (platform == Platform.iOS)
			{
				FeatureContext.Current[ScreenNames.Home] = new HomeScreenIos();
				FeatureContext.Current[ScreenNames.AddTask] = new AddTaskScreenIos();
			}
			else if (platform == Platform.Android)
			{
				FeatureContext.Current[ScreenNames.Home] = new HomeScreenAndroid();
				FeatureContext.Current[ScreenNames.AddTask] = new AddTaskScreenAndroid();
			}
		}
	}
}
