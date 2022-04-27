using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp
{
    public class BookList
    {
        private List<Subject> _subjects { get; set; } = new List<Subject>();
        public void AddBook(Subject subject)
        
            {
                _subjects.Add(subject);
            }
          
        public void isValid(Subject subject)
        {

            
            

            if (subject._sCode.Length == 7)
            {
                var firstThree = (Regex.IsMatch(subject._sCode.Substring(0, 3), @"^[a-zA-Z]+$"));
                if (!firstThree)
                {
                    Console.WriteLine($"First three Character must be Alphabet");
                }
                var lastFour = (Regex.IsMatch(subject._sCode[^4..], @"^[0-9]+$"));
                if (!lastFour)
                {
                    Console.WriteLine($"Last Four Character must be Numeric");
                }
                AddBook(subject);

            }
                
            else
                Console.WriteLine($"Length of the subject code must be 7 charater. You have entered subject code: {subject._sCode}  ");

        }
        public void DisplayBook()
        {
            Console.WriteLine($"| Book Name | | Book Code |");
            foreach (var subject in _subjects)
            {
                Console.WriteLine($" {subject._sName} | | {subject._sCode} ");
            }
        }
    }
}
