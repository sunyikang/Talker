﻿using System;

using Xamarin.Forms;

namespace Talker
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			// YIKANG P1: Init the Constants.gMaxObjectID
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
			// YIKANG P1: Init the Constants.gMaxObjectID
		}
	}
}
