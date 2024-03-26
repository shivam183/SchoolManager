namespace SSOOD_300856860_A1
{
	using System;

	[Serializable]
	public enum EvaluationType { TEST, QUIZ, ASSIGNMENT, LAB }

	[Serializable]
	public class Evaluation
	{
		public double EvaluationWeight { get; set; }
		public int MaxPoints { get; set; }
		public double Points { get; set; }
		public EvaluationType EvaluationType { get; set; }

		public Evaluation()
		{
		}
		public Evaluation(EvaluationType evaluationType, int maxPoints, double evaluationWeight)
		{
			MaxPoints = maxPoints;
			EvaluationWeight = evaluationWeight;
			EvaluationType = evaluationType;
		}
		public override string ToString()
		{
			return string.Format("Type of Evaluation: {0} \nMaximum Points: {1} \nEvaluation Weight: {2} \nPoints Scored: {3}", EvaluationType, MaxPoints, EvaluationWeight * 100, Points);
		}
	}
}
