using System;
using NUnit.Framework;
using FluentAssertions;

namespace Moments.Tests.ViewModels
{
	[TestFixture]
	public class ViewMomentViewModelTests
	{
		[Test]
		public void Inheritance_IsBaseViewModel ()
		{
			var vm = new ViewMomentViewModel ("http://uri.com", new TimeSpan());
			Assert.IsInstanceOf (typeof(BaseViewModel), vm);
		}

		[Test]
		[ExpectedException(typeof(UriFormatException))]
		public void Constructor_FailsForEmptyURI()
		{
			new ViewMomentViewModel (string.Empty, new TimeSpan());
		}

		[Test]
		[ExpectedException(typeof(UriFormatException))]
		public void Constructor_FailsForBadURI()
		{
			new ViewMomentViewModel ("Test@test&j.com", new TimeSpan());
		}

		[Test]
		public void InitialValues_HasCorrectURI()
		{
			var vm = new ViewMomentViewModel ("http://test.com", new TimeSpan(10, 20, 30));
			vm.Image.Should ().Be (new Uri ("http://test.com"));
		}

		[Test]
		public void InitialValues_HasCorrectViewTime()
		{
			var vm = new ViewMomentViewModel ("http://test.com", new TimeSpan(10, 20, 30));
			vm.MomentViewTime.Should ().Be (new TimeSpan(10, 20, 30));
		}
	}
}

