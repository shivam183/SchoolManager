using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public enum EvaluationType { TEST, QUIZ, ASSIGNMENT, LAB }

    [Serializable]
    public class Evaluation
    {
        private EvaluationType typeOfEvaluation;
        double evaluationWeight;
        int maxPoints;
        double points;

        public double EvaluationWeight
        {
            get
            {
                return evaluationWeight;
            }

            set
            {
                evaluationWeight = value;
            }
        }

        public int MaxPoints
        {
            get
            {
                return maxPoints;
            }

            set
            {
                maxPoints = value;
            }
        }

        public double Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public EvaluationType TypeOfEvaluation
        {
            get
            {
                return typeOfEvaluation;
            }

            set
            {
                typeOfEvaluation = value;
            }
        }

        public Evaluation()
        {

        }

        public Evaluation(EvaluationType TypeOfEvaluation, int maxPoints, double evaluationWeight)
        {
            this.MaxPoints = maxPoints;
            this.EvaluationWeight = evaluationWeight;
            this.TypeOfEvaluation = TypeOfEvaluation;
        }


        public override string ToString()
        
        {
            return string.Format("Type of Evaluation: {0} \nMaximum Points: {1} \nEvaluation Weight: {2} \nPoints Scored: {3}", TypeOfEvaluation, MaxPoints, EvaluationWeight * 100, points);
        }
    }
}
