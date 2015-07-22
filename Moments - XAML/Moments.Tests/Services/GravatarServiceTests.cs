using System;
using NUnit.Framework;
using Moments;
using FluentAssertions;

namespace Moments.Tests.Services
{
	[TestFixture]
	public class GravatarServiceTests
	{
		[Test]
		public void ShouldCalculateCorrectly()
		{
			var url = GravatarService.CalculateUrl ("test@test.com");
			url.Should ().Be ("http://www.gravatar.com/avatar.php?gravatar_id=b642b4217b34b1e8d3bd915fc65c4452");
		}
	}
}

