using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_ReportCard
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of Students: ");
            Int32.TryParse(Console.ReadLine(), out int numStudents);
            var students = new List<Students>();
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("******************************");
                Console.Write("Enter Student Name: ");
                var tempName = Console.ReadLine();
                Console.Write("Enter English Marks: ");
                Int32.TryParse(Console.ReadLine(), out int tempEnglish);
                Console.Write("Enter Math Marks: ");
                Int32.TryParse(Console.ReadLine(), out int tempMath);
                Console.Write("Enter Science Marks: ");
                Int32.TryParse(Console.ReadLine(), out int tempComputer);

                var tempStudent = new Students()
                {
                    Name = tempName,
                    English = tempEnglish,
                    Math = tempMath,
                    Computer = tempComputer
                };
                tempStudent.GradeAlert += onGradeAlert;

                students.Add(tempStudent);
                
                Console.WriteLine("**********Report Card **********");
            }  // End for loop

            foreach (var student in students)
            {
                Console.WriteLine("******************************");
                Console.Write($"Student Name: {student.Name}");
                Console.Write($" Student position: {students.IndexOf(student) + 1}");

                Console.WriteLine($" Total: {student.Marks} / 150");
                student.Scores = student.Marks;

                Console.WriteLine("******************************");

            }
        }

        private static void onGradeAlert(object o)
        {
            Students student = (Students)o;
            Console.WriteLine($"{student.ClassResult}");
        }
    }
}
