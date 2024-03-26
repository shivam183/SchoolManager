namespace SSOOD_300856860_A1
{
	using System;

	[Serializable]
	public struct Address
	{
		public string StreetAddress { get; set; }

		public string City { get; set; }
		
		public string PostalCode { get; set; }

		public Address(string streetAddress, string city, string postalCode)
		{
			StreetAddress = streetAddress;
			City = city;
			PostalCode = postalCode;
		}
		public override string ToString()
		{
			return string.Format("Street Address:{0} City:{1} PostalCode:{2}", StreetAddress, City, PostalCode);
		}
	}
}
