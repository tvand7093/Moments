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
		public void InitialValues_HasCorrectURI()
		{
			var vm = new ViewMomentViewModel ("http://test.com", new TimeSpan(10, 20, 30));
			vm.Image.Should ().Be ("http://test.com");
		}

		[Test]
		public void InitialValues_HasCorrectViewTime()
		{
			var vm = new ViewMomentViewModel ("http://test.com", new TimeSpan(10, 20, 30));
			vm.MomentViewTime.Should ().Be (new TimeSpan(10, 20, 30));
		}
	}
}

