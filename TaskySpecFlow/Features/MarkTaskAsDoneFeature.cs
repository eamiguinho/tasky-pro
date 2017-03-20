using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	[TestFixture(Platform.Android)]
	public partial class MarkTaskAsDoneFeature : FeatureBase
	{
		public MarkTaskAsDoneFeature(Platform platform) : base(platform)
		{
		}
	}
}
