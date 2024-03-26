using System;
using System.Collections.Generic;
namespace SSOOD_300856860_A1
{
	[Serializable]
	public class Person
	{
		public int RegistrationNumber { get; }

		public string Name { get; set; }

		public DateTime DOB { get; set; }

		public long TelephoneNumber { get; set; }

		public Address Address { get; set; }

		public Section StudentName { get; set; }

		public List<Section> Sections { get; set; }
		public Person()
		{
			RegistrationNumber++;
			Sections = new List<Section>();
		}
		public Person(string name, DateTime dOB) : this()
		{
			Name = name;
			DOB = dOB;
		}
		public override string ToString()
		{
			return string.Format("Reg No: {0} ,Name: {1} ,Date Of Birth: {2} \nAddress: Street: {3} City: {4} State: {5} ,Tel:{6}", RegistrationNumber, Name, DOB, Address.StreetAddress, Address.City, Address.PostalCode, TelephoneNumber);
		}
	}
}
