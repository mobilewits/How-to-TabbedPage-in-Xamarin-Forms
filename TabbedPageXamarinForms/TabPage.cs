using System;

using Xamarin.Forms;

namespace TabbedPageXamarinForms
{
	public class TabPage : TabbedPage
	{
		public TabPage ()
		{
			this.Children.Add (new FirstPage (){ Title = "First"});
			this.Children.Add (new SecondPage (){ Title = "Second"});
			this.Children.Add (new ThirdPage (){ Title = "Third"});
			this.Title="TabbedPage";
		}

	}
}


