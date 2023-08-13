using System;
using System.Collections.Generic;

namespace Object___Multiple_Choice_Tests
{
    class Program
    {
		public interface ITestpaper
		{
			string Subject { get; }
			string[] MarkScheme { get; }
			string PassMark { get; }
		}

		public interface IStudent
		{
			string[] TestsTaken { get; }
			void TakeTest(ITestpaper paper, string[] answers);
		}

		public class Testpaper : ITestpaper
		{

			public Testpaper(string subject, string[] markScheme, string passMark)
			{
				this.NameOfTest = subject;
				this.MarkSchemeClass = markScheme;
				this.ClassTestPassMark = passMark; 

			}

			public string NameOfTestGetter()
            {
				return NameOfTest;
			}

			public string PassMarkGetter()
			{
				return ClassTestPassMark;
			}

			public string[] MarkSchemeClassGetter()
            {
				return MarkSchemeClass;
			}

			private string NameOfTest;
			public string Subject
            {
				get => NameOfTest;
            }
			private string[] MarkSchemeClass;
			public string[] MarkScheme
            {
				get => MarkSchemeClass;

			}
			private string ClassTestPassMark;
			public string PassMark
            {
				get => ClassTestPassMark;

			}
		}

		public class Student
		{
			List<string> TestsTakenClassList = new List<string>();

			
			public void TakeTest(Testpaper paper, string[] TheirTestAnswers)
			{
				string nameOfTest = paper.NameOfTestGetter();
				

				string[] MarkScheme = paper.MarkSchemeClassGetter();
				int LengthOfTest = TheirTestAnswers.Length;
				int count = 0;
				for (int i = 0; i < LengthOfTest ; i++)
                {
					string theirAnswer = TheirTestAnswers[i].Substring(1);
					string cORRECTAnswer = MarkScheme[i].Substring(1);
					if (theirAnswer == cORRECTAnswer)
                    {
						count++;
                    }
				}
				count = count * 100;
				LengthOfTest = LengthOfTest * 100;
				double DecimalGradeRoundedTimesed = ((double)count / (double)LengthOfTest);
				double DecimalGradeRoundedTimesed1000 = DecimalGradeRoundedTimesed * 100;
				double DecimalGradeRoundedTimesed100 = Math.Round(DecimalGradeRoundedTimesed1000);
				//double DecimalGradeRoundedTimesed100 = DecimalGradeRounded * 100;

				string PassMark = paper.PassMarkGetter();
				string PassMarkNoPercentage = PassMark.Remove(2);
				int PassMarkInt = Convert.ToInt16(PassMarkNoPercentage);
				string TheirScore = DecimalGradeRoundedTimesed100.ToString();
				if (DecimalGradeRoundedTimesed100 >= PassMarkInt)
                {
					string Result = nameOfTest + ": Passed! (" + TheirScore + "%)";
					TestsTakenClassList.Add(Result);

				}
				else
                {
					string Result = nameOfTest + ": Failed! (" + TheirScore + "%)";
					TestsTakenClassList.Add(Result);
				}
			}

			public void TestsTaken()
            {
				string[] TestsTakenClassArray = TestsTakenClassList.ToArray();
				if (TestsTakenClassArray.Length == 0)
                {
					Console.WriteLine("No tests taken");
				}
                else
                {
					TestsTakenClassList.ForEach(Console.Write);
					//Console.WriteLine(TestsTakenClassArray);
				}
			}



		}
		static void Main(string[] args)
        {
			Testpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
			Testpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
			Testpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
			Student student1 = new Student();
			Student student2 = new Student();

			student1.TestsTaken();
			student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
			student1.TestsTaken();

			student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
			student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
			student2.TestsTaken();

		}
    }
}
