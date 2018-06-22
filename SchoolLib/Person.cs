using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public class Person
    {
        int registrationNumber;
        static int regCount = 0;
        string name;
        long telephoneNumber;
        Address address;
        DateTime dOB;
        Section studentName;
        List<Section> sections;

        public int RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dOB;
            }

            set
            {
                dOB = value;
            }
        }

        public long TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }

            set
            {
                telephoneNumber = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public Section StudentName
        {
            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }
        }

        public virtual List<Section> Sections { get { return sections; } set { sections = value; } }

        public Person()
        {
            regCount++;
            registrationNumber = regCount;
            Sections = new List<Section>();
           
        }

        public Person(string name, DateTime dOB) : this()
        {

            this.name = name;
            this.dOB = dOB;

        }

     


        public override string ToString()
        {
           
            return string.Format("Reg No: {0} ,Name: {1} ,Date Of Birth: {2} \nAddress: Street: {3} City: {4} State: {5} ,Tel:{6}", RegistrationNumber, Name, DOB, Address.StreetAddress, Address.City, Address.PostalCode, TelephoneNumber);
        }
    }
}
