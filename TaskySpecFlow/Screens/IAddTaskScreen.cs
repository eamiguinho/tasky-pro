using System;
using Xamarin.UITest.Queries;

namespace TaskySpecFlow
{
	public interface IAddTaskScreen
	{
		Func<AppQuery, AppQuery> nameEntry { get; }
		Func<AppQuery, AppQuery> saveButton { get; }
		Func<AppQuery, AppQuery> doneCheck { get; }
		Func<AppQuery, AppQuery> deleteButton { get; }
	}

	public class AddTaskScreenAndroid : IAddTaskScreen
	{
		public Func<AppQuery, AppQuery> nameEntry { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("NameText"));
		public Func<AppQuery, AppQuery> saveButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("SaveButton"));
		public Func<AppQuery, AppQuery> doneCheck { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("chkDone"));
		public Func<AppQuery, AppQuery> deleteButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("CancelDeleteButton"));
	}

	public class AddTaskScreenIos : IAddTaskScreen
	{
		public Func<AppQuery, AppQuery> nameEntry { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Name"));
		public Func<AppQuery, AppQuery> saveButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Save"));
		public Func<AppQuery, AppQuery> doneCheck { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Done"));
		public Func<AppQuery, AppQuery> deleteButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Delete"));
	}
}
