using System;
using NUnit.Framework;
using FluentAssertions;

namespace Moments.Tests.ViewModels
{
	[TestFixture]
	public class BaseViewModelTests
	{
		BaseViewModel vm;

		[TestFixtureSetUp]
		public void SetupBase ()
		{
			vm = new BaseViewModel ();
		}

		[TestFixtureTearDown]
		public void TearDownBase() 
		{
			vm = null;
		}

		[Test]
		public void Structure_HasCorrectStaticPropertyValues()
		{
			BaseViewModel.IconPropertyName.Should ().Be ("Icon");
			BaseViewModel.TitlePropertyName.Should ().Be ("Title");
			BaseViewModel.SubtitlePropertyName.Should ().Be ("Subtitle");
			BaseViewModel.IsBusyPropertyName.Should ().Be ("IsBusy");
		}

		[Test]
		public void Structure_IsINotifyPropertyChanged()
		{
			Assert.IsInstanceOf (typeof(System.ComponentModel.INotifyPropertyChanged), vm);
		}

		[Test]
		public void Structure_IsINotifyPropertyChanging()
		{
			Assert.IsInstanceOf (typeof(System.ComponentModel.INotifyPropertyChanging), vm);
		}

		[Test]
		public void Defaults_HasCorrectDefaults()
		{
			vm.Icon.Should ().BeNull ();
			vm.IsBusy.Should ().BeFalse ();
			vm.Subtitle.Should ().Be (string.Empty);
			vm.Title.Should ().Be (string.Empty);
		}

		[Test]
		public void Icon_FiresPropertyChangedEvent()
		{
			vm.MonitorEvents ();
			vm.Icon = "TestIcon";
			vm.ShouldRaisePropertyChangeFor (a => a.Icon);
		}

		[Test]
		public void Icon_ValueChanges()
		{
			vm.Icon = "TestIcon";
			vm.Icon.Should ().Be ("TestIcon");
		}

		[Test]
		public void Title_FiresPropertyChangedEvent()
		{
			vm.MonitorEvents ();
			vm.Title = "TestTitle";
			vm.ShouldRaisePropertyChangeFor (a => a.Title);
		}

		[Test]
		public void Title_ValueChanges()
		{
			vm.Title = "TestTitle";
			vm.Title.Should ().Be ("TestTitle");
		}

		[Test]
		public void Subtitle_FiresPropertyChangedEvent()
		{
			vm.MonitorEvents ();
			vm.Subtitle = "TestSubtitle";
			vm.ShouldRaisePropertyChangeFor (a => a.Subtitle);
		}

		[Test]
		public void Subtitle_ValueChanges()
		{
			vm.Subtitle = "TestSubtitle";
			vm.Subtitle.Should ().Be ("TestSubtitle");
		}

		[Test]
		public void IsBusy_FiresPropertyChangedEvent()
		{
			vm.MonitorEvents ();
			vm.IsBusy = true;
			vm.ShouldRaisePropertyChangeFor (a => a.IsBusy);
		}

		[Test]
		public void IsBusy_ValueChanges()
		{
			vm.IsBusy = true;
			vm.IsBusy.Should ().BeTrue();
		}
	}
}

