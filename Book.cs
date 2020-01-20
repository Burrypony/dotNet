using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet 
{
    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name ;
        }
        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }


        public void ShowStatistics() 
        {
            var lowesGrade = double.MaxValue;
            var highGrade = double.MinValue;
            
            foreach(var number in grades)
            {
                lowesGrade = Math.Min(number , lowesGrade);
                highGrade = Math.Max(number, highGrade);
            }

            var averageGrade = (highGrade + lowesGrade) / 2;

            Console.WriteLine($"{lowesGrade}: lowes Grade");    
            Console.WriteLine($"{highGrade} : hight Grade");
            Console.WriteLine($"{averageGrade} : average Grade");        
        }

        private List<double> grades;
        private string name ;
    }
}