using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public enum _Enrolment { F, D, D_plus, C, C_plus, B, B_plus, A, A_plus }
    [Serializable]
    public class Enrolment
    {
        Person student;
        Section section;
        _Enrolment finalGrade;
        string sectionId;
        readonly int noOfEvaluations;
        List<Evaluation> evaluations;

        public Person Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        public Section Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public string SectionId
        {
            get
            {
                return sectionId;
            }


        }

        public List<Evaluation> Evaluations
        {
            get
            {
                return evaluations;
            }


        }

        public int NoOfEvaluations
        {
            get
            {
                return noOfEvaluations;
            }
        }


        public _Enrolment FinalGrade
        {
            get
            {
                CalculateFinalGrade();
                return finalGrade;
            }

            set
            {
                finalGrade = value;
            }
        }


        public void CalculateFinalGrade()
        {
            double grade = 0;
            int[] gradeRange = { 100, 90, 80, 75, 70, 65, 60, 55, 50 };
            int level = -1;

            for (int i = 0; i < NoOfEvaluations; i++)
            {
                grade += (evaluations[i].Points / evaluations[i].MaxPoints) * 100 * evaluations[i].EvaluationWeight;
            }
            for (int x = 1; x < gradeRange.Length; x++)
            {

                if (grade >= gradeRange[x] && grade <= gradeRange[x - 1])
                {
                    level = x;
                    break;
                }

            }
            switch (level)
            {

                case 1:
                    finalGrade = _Enrolment.A_plus;
                    break;
                case 2:
                    finalGrade = _Enrolment.A;
                    break;
                case 3:
                    finalGrade = _Enrolment.B_plus;
                    break;
                case 4:
                    finalGrade = _Enrolment.B;
                    break;
                case 5:
                    finalGrade = _Enrolment.C_plus;
                    break;
                case 6:
                    finalGrade = _Enrolment.C_plus;
                    break;
                case 7:
                    finalGrade = _Enrolment.C;
                    break;
                case 8:
                    finalGrade = _Enrolment.D_plus;
                    break;
                case 9:
                    finalGrade = _Enrolment.D;
                    break;
                default:
                    finalGrade = _Enrolment.F;
                    break;
            }
        }

        public Enrolment(Person student, Section sectionId, int noOfEvaluations)
        {

            this.student = student;
            this.sectionId = SectionId;
            this.noOfEvaluations = noOfEvaluations;
            evaluations = new List<Evaluation>();

        }

        //public override string ToString()
        //{
        //    return string.Format("Name of Student: {0} \nSection ID: {1} \nNo. of Evaluations: {2} ", Student.Name, Section.SectionId, NoOfEvaluations);
        //}
    }
}



