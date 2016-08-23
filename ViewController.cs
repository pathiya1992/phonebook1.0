using System;
using System.IO;
using UIKit;
using System.Threading;
namespace Phonebook1
{
	public partial class ViewController : UIViewController
	{
		

		protected ViewController(IntPtr handle) : base(handle)
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

		partial void UIButton67_TouchUpInside(UIButton sender)
		{
			string name;
			name = nameBox.Text;
			string phone = phoneBox.Text;
			string line = string.Format("{0},{1}", name, phone);

			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var filename = Path.Combine(documents, "MyContacts.txt");
			File.WriteAllText(filename, line);

			var alert = UIAlertController.Create("Confirm", " Contact Added", UIAlertControllerStyle.Alert);
			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
			PresentViewController(alert, true, null);

			nameBox.Text = "";
			phoneBox.Text = "";
		}


	}
}

