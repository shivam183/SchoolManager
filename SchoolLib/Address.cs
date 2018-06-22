using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public struct Address
    {
        string streetAddress;
        string city;
        string postalCode;

        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }

            set
            {
                streetAddress = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public Address(string streetAddress,string city,string postalCode)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.postalCode = postalCode;

        }

        public override string ToString()
      
        {
            return string.Format("Street Address:{0} City:{1} PostalCode:{2}", StreetAddress, City, PostalCode);
        }


    }
}
