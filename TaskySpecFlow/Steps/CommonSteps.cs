using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	[Binding]
	public class CommonSteps
	{
		readonly IApp app;
		IHomeScreen homeScreen;
		IAddTaskScreen addTaskScreen;

		public CommonSteps()
		{
			app = FeatureContext.Current.Get<IApp>("App");
			homeScreen = FeatureContext.Current.Get<IHomeScreen>(ScreenNames.Home);
			addTaskScreen = FeatureContext.Current.Get<IAddTaskScreen>(ScreenNames.AddTask);
		}

		[Given(@"I am on the Home screen")]
		public void GivenIAmOnTheHomeScreen()
		{
			app.WaitForElement(homeScreen.addButton);
			app.Screenshot("Given I am on the Home screen");
		}

		[When(@"I add a new task called ""(.*)""")]
		public void WhenIAddANewTaskCalled(string taskName)
		{
			app.WaitForElement(homeScreen.addButton);
			app.Tap(homeScreen.addButton);
			app.Screenshot("When I add a new task called '" + taskName + "'");
			app.WaitForElement(addTaskScreen.nameEntry);
			app.EnterText(addTaskScreen.nameEntry, taskName);
			app.Screenshot("When I add a new task called '" + taskName + "'");
		}
	}
}
