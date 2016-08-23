using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;
using System.Diagnostics;
namespace Phonebook1
{
	public class contactList : UITableViewSource
	{
		protected Contact[] tableData;
		protected string cellIdentifier = "TableCell";
		ListController owner1;

		public contactList(Contact[] items, ListController owner)
		{
			tableData = items;
			owner1 = owner;
		
		}
		public override nint RowsInSection(UITableView tableview, nint section)
		{
	
			return tableData.Length;
		}
				            

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

			cell.TextLabel.Text = tableData[indexPath.Row].ToString();
			Debug.WriteLine(tableData[indexPath.Row].ToString());
			return cell;
		}
	}
}

