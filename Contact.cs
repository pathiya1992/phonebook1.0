using System;
namespace Phonebook1
{
	public class Contact
	{
		public string  Name { get; set;}
		public string[] dataitems;
		public string PhoneNumber { get; set; }

		public Contact(string name, string phone)
		{

			Name = name;
			PhoneNumber = phone;
	
		}

		public int lengthOfArray()
		{
			int i;
			for (i = 0; i < 5; i++)
				dataitems[i] = Name + "  " + PhoneNumber;
			return dataitems.Length;

		}

		public override string ToString()
		{
			return Name + "  " + PhoneNumber;
		}
	}
}

