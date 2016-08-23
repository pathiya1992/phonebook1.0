using System;
using UIKit;
using System.IO;
using System.Diagnostics;
namespace Phonebook1
{
	public partial class ListController:UIViewController
	{
		public ListController(IntPtr handle) : base(handle)
		{
			
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var filename = Path.Combine(documents, "MyContacts.txt");
			var text = File.ReadAllText(filename);
			string[] line = text.Split(',');



			Contact mycontact = new Contact(line[0], line[1]);
			Debug.WriteLine(mycontact);


			Contact[] contactLists = { mycontact };
			//Debug.WriteLine(contactList);

			listTable.Source = new contactList(contactLists, this);




		}





	}
}

