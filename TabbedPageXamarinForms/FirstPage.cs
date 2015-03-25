using System;

using Xamarin.Forms;

namespace TabbedPageXamarinForms
{
	public class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "First Page" }
				}
			};
		}
	}
}


