using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotNet 
{
    class helloWord
    {
        static void Main(string[] args)
        {

            var book = new Book("test book 1");
            book.AddGrades(86.3);
            book.AddGrades(91.2);
            book.AddGrades(75.2);
            book.ShowStatistics();

           

        }
    } 
}