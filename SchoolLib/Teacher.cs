using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSOOD_300856860_A1
{
    [Serializable]
    public class Teacher:Person
    {
        
        public Teacher(string name,DateTime DOB):base(name,DOB)
        {

        }
        
        public string SectionsInfo()
        {
            string result = "";
            
            for(int i=0;i<Sections.Count;i++)
            {
                result += ("\n\t"+Sections[i].Name);
            }


            return result;
        }

    }
}
