using System;
using NUnit.Framework;
using FluentAssertions;

namespace Moments.Tests.Services
{
	[TestFixture]
	public class HashServiceTests
	{
		[Test]
		public void ShouldHashCorrectly()
		{
			const string toHash = "This string should be made into a hash!";
			var hash = HashService.CalculateMD5Hash (toHash);
			hash.Should ().Be ("3ee54e3300b17692f6b4cceae8816615");
		}

		[Test]
		public void ShouldWorkForEmptyString()
		{
			const string toHash = "";
			var hash = HashService.CalculateMD5Hash (toHash);
			hash.Should ().Be ("d41d8cd98f00b204e9800998ecf8427e");
		}
	}
}

