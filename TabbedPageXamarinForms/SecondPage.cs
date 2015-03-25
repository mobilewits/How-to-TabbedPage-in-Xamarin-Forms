using System;

using Xamarin.Forms;

namespace TabbedPageXamarinForms
{
	public class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Second Page" }
				}
			};
		}
	}
}


