using System;
using System.Diagnostics.Metrics;

namespace prjConCsRepetition
{
    public static class LoopAssignment
    {
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

        public static void RevenuQuebec()
        {
            string name, title;
            char gender, mar;
            double sal, ded, ben, rev;
            Int16 child;

            Console.WriteLine("\tREVENU-QUEBEC");
            Console.WriteLine("\t- - - - - - -");

            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            } while (name == "");

            do {
                Console.Write("Select your gender (m/f): ");
                gender = Convert.ToChar(Console.ReadLine()); }
            while (!(gender == 'M' || gender == 'm' || gender == 'F' || gender == 'f'));

            do
            {
                Console.Write("Enter your annual salary: ");
                sal = Convert.ToDouble(Console.ReadLine());
            } while (sal < 0 || sal == Convert.ToDouble(""));

            do
            {
                Console.Write("Are you married (y/n): ");
                mar = Convert.ToChar(Console.ReadLine());
            } while (!(mar == Convert.ToChar('y') || mar == Convert.ToChar('Y') || mar == Convert.ToChar('n') || mar == Convert.ToChar('N')));

            do
            {
                Console.Write("How many children you have: ");
                child = Convert.ToInt16(Console.ReadLine());
            } while (child < 0 || child == Convert.ToInt16(""));

            //conditional
            title = (gender == 'M' || gender == 'm') ? "Sir " : "Miss ";
            ded = (mar == 'y' && gender == 'm') ? -(0.40 * sal) : (mar == 'y' && gender == 'f') ? -(0.30 * sal) : (mar == 'n' && gender == 'm') ? -(0.50 * sal) : -(0.40 * sal);
            ben = (gender == 'F' || gender == 'f' && child <= 10) ? 5000 * child : ben = 0;
            //if (mar == 'y' && gender == 'm')
            //{
            //    ded = -(0.40 * sal);
            //}
            //else if (mar == 'y' && gender == 'f')
            //{
            //    ded = -(0.30 * sal);
            //}
            //else if (mar == 'n' && gender == 'm')
            //{
            //    ded = -(0.50 * sal);
            //}
            //else
            //{
            //    ded = -(0.40 * sal);
            //}


            //if (gender == 'F' || gender == 'f' && child <= 10)
            //{
            //    ben = 5000 * child;
            //}
            //else
            //{
            //    ben = 0;
            //}

            rev = sal + ded + ben;

            Console.WriteLine("Thanks,");
            Console.WriteLine(title + name + ",");
            Console.WriteLine("This is the calculation of your deductions");
            Console.WriteLine("Salary\t\t" + sal);
            Console.WriteLine("Deductions\t" + ded);
            Console.WriteLine("Benefits\t" + ben);
            Console.WriteLine("----------------------");
            Console.WriteLine("Revenue\t\t" + rev);
        }

        public static void ClassCalculator()
        {
            string title;
            Int16 studentnum, gradenum;
            Single grade, avg, best = 0, worst = 101, sum;


            Console.WriteLine("\tREVENU-QUEBEC");
            Console.WriteLine("\t- - - - - - -");

            do
            {
                Console.Write("Enter the course title: ");
                title = Console.ReadLine();
            } while (title == "");

            Console.Write("Enter the number of students: ");
            studentnum = Convert.ToInt16(Console.ReadLine());
            while (!(studentnum >= 2 && studentnum <= 25))
            {
                Console.Write("Please, a number (2 to 25): ");
                studentnum = Convert.ToInt16(Console.ReadLine());
            }

            sum = 0;
            for (gradenum = 1; gradenum <= studentnum; gradenum++) 
            {
                do
                {
                    Console.Write("\tEnter grade " + gradenum + ": ");
                    grade = Convert.ToSingle(Console.ReadLine());
                } while (!(grade >= 0 && grade <= 100));
                sum = sum + grade;
                if (gradenum == 1)
                    worst = grade;
                else if (grade < worst)
                    worst = grade;

                if (gradenum == 1)
                    best = grade;
                else if (grade > best)
                    best = grade;

                //if (grade > best)
                //{
                //    best = grade;
                //}

                //if (grade < worst)
                //{
                //    worst = grade;
                //}
            }
            avg = sum / studentnum;
            Console.WriteLine("For the course " + title + ":");
            Console.WriteLine("\t- the class average is " + avg);
            Console.WriteLine("\t- the best grade is " + best);
            Console.WriteLine("\t- the worst grade is " + worst);
        }
    }
}

