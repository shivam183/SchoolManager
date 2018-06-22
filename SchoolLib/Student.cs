using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace SSOOD_300856860_A1
{
    [Serializable]
    public class Student:Person
    {
        
        public string PrintTranscript()
        {
            string result="";

            for(int i=0; i<Sections.Count; i++)
            {
                result += String.Format("\n" + Sections[i].Course.CourseCode);
                foreach(var item in Sections[i].Students)
                {
                    if(item.Student.Name==Name)
                    {
                        result += String.Format(":"+ item.FinalGrade);
                    }
                }
            }

            return result;
        }

       
    }

}
