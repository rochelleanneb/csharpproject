using System;

namespace MyProject
{
    class Task5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Total Students : ");
            int totalStudents = Convert.ToInt32(Console.ReadLine());

            // Multi-dimensional array: [row = student][columns = name, eng, math, comp, total]
            string[,] students = new string[totalStudents, 5];

            // Ask the user for the input
            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter Student Name : ");
                students[i, 0] = Console.ReadLine();

                Console.Write("Enter English Marks (Out Of 100) : ");
                int eng = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Math Marks (Out Of 100) : ");
                int math = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Computer Marks (Out Of 100) : ");
                int comp = Convert.ToInt32(Console.ReadLine());

                int total = eng + math + comp;

                students[i, 1] = eng.ToString();
                students[i, 2] = math.ToString();
                students[i, 3] = comp.ToString();
                students[i, 4] = total.ToString();

                Console.WriteLine("*********************************************");
            }

            // Sort students in descending order based on their total marks
            for (int i = 0; i < totalStudents - 1; i++)
            {
                for (int j = i + 1; j < totalStudents; j++)
                {
                    int total1 = Convert.ToInt32(students[i, 4]);
                    int total2 = Convert.ToInt32(students[j, 4]);

                    if (total2 > total1) // Swap for descending order
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            string temp = students[i, k];
                            students[i, k] = students[j, k];
                            students[j, k] = temp;
                        }
                    }
                }
            }

            // ===== PRINT REPORT CARD =====
            Console.WriteLine("****************Report Card*******************");

            for (int i = 0; i < totalStudents; i++)
            {
                string name = students[i, 0];
                int total = Convert.ToInt32(students[i, 4]);
                int position = i + 1;

                Console.WriteLine("****************************************");
                Console.WriteLine($"Student Name: {name}, Position: {position}, Total:");
                Console.WriteLine($"{total}/300");
                Console.WriteLine("****************************************");
            }
        }
    }
}
