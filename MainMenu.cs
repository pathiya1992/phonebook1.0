using System;
using System.Threading;
using UIKit;

namespace Phonebook1
{
	public partial class MainMenu : UIViewController
	{
		protected MainMenu(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton1126_TouchUpInside(UIButton sender)
		{
			Thread.CurrentThread.Abort();
		}
	}
}


