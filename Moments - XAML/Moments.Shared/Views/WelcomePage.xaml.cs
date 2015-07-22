using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Moments
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();

			SetupUserInterface ();
			SetupEventHandlers ();
		}

		private void SetupUserInterface ()
		{
			NavigationPage.SetHasNavigationBar (this, false);
		}

		private void SetupEventHandlers ()
		{

		}
	}
}

