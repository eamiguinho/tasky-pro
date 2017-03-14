using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using System.Linq;
using Should;

namespace TaskySpecFlow
{
	[Binding]
	public class AddATaskSteps
	{
		readonly IApp app;
		IHomeScreen homeScreen;
		IAddTaskScreen addTaskScreen;

		public AddATaskSteps()
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

		[When(@"I save the task")]
		public void WhenISaveTheTask()
		{
			app.Tap(addTaskScreen.saveButton);
			app.Screenshot("When I save the task");
		}

		[Then(@"I should see the ""(.*)"" task in the list")]
		public void ThenIShouldSeeTheTaskInTheList(string taskName)
		{
			app.WaitForElement(c => c.Marked(taskName));
			app.Query(c => c.Marked(taskName)).Length.ShouldBeGreaterThan(0);
			app.Screenshot("Then I should see the '" + taskName + "' task in the list");
		}

	}
}
