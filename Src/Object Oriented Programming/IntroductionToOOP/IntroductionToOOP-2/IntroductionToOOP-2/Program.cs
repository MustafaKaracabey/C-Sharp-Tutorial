using System;

namespace IntroductionToOOP_2
{
    class Program
    {  // Find Average and decide failed or passed the exam                 
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Mustafa";
            student1.Surname = "Karacabey";
            student1.MidtermNote = 80;
            student1.FinalNote = 36;

            student1.CalculateAverage();

            Student student2 = new Student();
            student2.Name = "Zeynep";
            student2.Surname = "Karacabey";
            student2.MidtermNote = 45;
            student2.FinalNote = 30;

            student2.CalculateAverage();

            Student student3 = new Student();
            student3.Name = "Kadir";
            student3.Surname = "Karacabey";
            student3.MidtermNote = 100;
            student3.FinalNote = 38;

            student3.CalculateAverage();

            Student[] students = new Student[3] { student1 , student2, student3 };

            for (int i=0; i< students.Length ;i++)
            {
                if (students[i].Average >= 50)
                {
                    Console.WriteLine($"{students[i].Name} {students[i].Surname} average is {students[i].Average} and Congrats Passed");
                }
                else
                {
                    Console.WriteLine($"{students[i].Name} {students[i].Surname} average is {students[i].Average} and Oh Shit Failed!!");
                }
            }
        }

    }
}



