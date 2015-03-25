using System;

using Xamarin.Forms;

namespace TabbedPageXamarinForms
{
	public class ThirdPage : ContentPage
	{
		public ThirdPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Third Page" }
				}
			};
		}
	}
}


