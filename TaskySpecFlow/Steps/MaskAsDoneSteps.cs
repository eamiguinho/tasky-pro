using System;
using Should;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	[Binding]
	public class MaskAsDoneSteps
	{
		IApp app;
		IHomeScreen homeScreen;
		IAddTaskScreen addTaskScreen;

		public MaskAsDoneSteps()
		{
			app = FeatureContext.Current.Get<IApp>("App");
			homeScreen = FeatureContext.Current.Get<IHomeScreen>(ScreenNames.Home);
			addTaskScreen = FeatureContext.Current.Get<IAddTaskScreen>(ScreenNames.AddTask);
		}

		[Then(@"I tap the task ""(.*)""")]
		public void ITapTheTask(string taskName)
		{
			app.Tap(c => c.Marked(taskName));
		}


		[When(@"I check it as done")]
		public void CheckItAsDone()
		{
			app.Tap(addTaskScreen.doneCheck);
		}

		[Then(@"I should see the ""(.*)"" task marked as done in the list")]
		public void CheckIfIsMarkedAsDone(string taskName)
		{
			app.Query(c => c.Marked(taskName)).Length.ShouldBeGreaterThan(0);
			app.Query(c => c.Marked("Image")).Length.ShouldBeGreaterThan(0);
		}
	}
}
