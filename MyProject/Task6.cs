using System;

namespace Task6
{
    // Step 1 & 2: Define the Student class
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
        }

        // Method to check if the student passed
        public bool IsPassed()
        {
            return Grade >= 75;
        }
    }

    class Program
    {
        // Step 3: Main entry point
        static void Main(string[] args)
        {
            // Step 4: Create an object and assign values
            Student student = new Student();
            student.Name = "Marco";
            student.Age = 20;
            student.Grade = 85.5;

            // Step 5: Call methods
            student.DisplayInfo();

            // Display pass/fail status
            if (student.IsPassed())
            {
                Console.WriteLine("Status: Passed");
            }
            else
            {
                Console.WriteLine("Status: Failed");
            }
        }
    }
}
