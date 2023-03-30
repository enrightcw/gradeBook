using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;


            foreach(var number in grades)
            {
                highGrade = Math.Max (highGrade, number);
                lowGrade = Math.Min (lowGrade, number);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}.");
            Console.WriteLine($"The highest grade is {highGrade:N1}.");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}.");

        }

        private List <double> grades;
        private string name;
    }
}