using System;
namespace prjConCsRepetition
{
	public static class loopsExercises
	{
		public static void GradeEvaluation()
		{
			string name, title, result;
			char gender;
			Single grade;

			Console.WriteLine("\tLASALLE COLLEGE");
			Console.WriteLine("\t- - - - - - - -");
			do
			{
				Console.Write("Enter your name: ");
				name = Console.ReadLine();
			} while (name == "");
			Console.Write("Select your gender: ");
			gender = Convert.ToChar(Console.ReadLine());
			while (!(gender == 'M' || gender == 'm' || gender == 'F' || gender == 'f'));
			{
				Console.Write("Enter m or f: ");
				gender = Convert.ToChar(Console.ReadLine());
			}
			Console.Write("Enter your grade: ");
			grade = Convert.ToSingle(Console.ReadLine());
			while (grade < 0 || grade > 100)
			{
				Console.Write("Please, a grade (0...100): ");
				grade = Convert.ToSingle(Console.ReadLine());
			}
			title = (gender == 'M' || gender == 'm') ? "Sir " : "Miss ";
			result = (grade < 60) ? "Fail." : "Pass.";
			Console.WriteLine(title + name + ",");
			Console.WriteLine("With " + grade + ", you " + result);

		}

		public static void TheCounter()
		{
			Int32 start, end, inter, num;
            Console.WriteLine("\tTHE COUNTER");
            Console.WriteLine("\t- - - - - -");
			Console.Write("Enter the starting value: ");
			start = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the end value: ");
			end = Convert.ToInt32(Console.ReadLine());
			while (end <= start)
			{
				Console.Write("Please, a value greater than " + start + ": ");
				end = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("Enter the step value: ");
			inter = Convert.ToInt32(Console.ReadLine());

			for (num = start; num <= end; num = num + inter)
			{
				Console.WriteLine("Number " + num);
			}
        }

		public static void AverageCalculator()
		{
			string name;
			Single grade, sum, avg, counter;

            Console.WriteLine("\tLASALLE COLLEGE");
            Console.WriteLine("\t- - - - - - - -");
			Console.Write("Enter your name: ");
			name = Console.ReadLine();
			while (name == "")
			{
				Console.Write("Sorry, name required: ");
				name = Console.ReadLine();
			}
			Console.WriteLine("We are going to read your 4 grades");
			sum = 0;
			for (counter = 1; counter <= 4; counter = counter + 1)
			{
				Console.Write("\tgrade " + counter + ": ");
				grade = Convert.ToSingle(Console.ReadLine());
				sum = Convert.ToInt16(sum + grade);
			}
			avg = sum / 4;
			Console.WriteLine("Thanks, " + name);
			Console.WriteLine("Your average is " + avg + "/100");
        }
	}
}