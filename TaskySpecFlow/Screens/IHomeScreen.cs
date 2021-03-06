﻿using System;
using Xamarin.UITest.Queries;

namespace TaskySpecFlow
{
	public interface IHomeScreen
	{
		Func<AppQuery, AppQuery> addButton { get; }
		Func<AppQuery, AppQuery> Image { get; }
	}


	public class HomeScreenAndroid : IHomeScreen
	{
		public Func<AppQuery, AppQuery> addButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Add Task"));
		public Func<AppQuery, AppQuery> Image { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Image"));
	}

	public class HomeScreenIos : IHomeScreen
	{
		public Func<AppQuery, AppQuery> addButton { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Add"));
		public Func<AppQuery, AppQuery> Image { get; } = new Func<AppQuery, AppQuery>(c => c.Marked("Image"));

	}
}
