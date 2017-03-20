using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace TaskySpecFlow
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public partial class AddingATaskFeature : FeatureBase
	{
		public AddingATaskFeature(Platform platform) : base(platform)
		{
		}
	}
}
