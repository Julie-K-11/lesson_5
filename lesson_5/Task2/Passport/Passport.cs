using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task2
{
    public class Passport
    {
        protected string FullName;
        protected string Country;
        protected string PassportNumber;
        protected string IssueDate;
        protected string ExpirationDate;

        public Passport(string fullName, string country, string issueDate, string expirationDate, string passportNumber)
        {
            FullName = fullName;
            Country = country;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            PassportNumber = passportNumber;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
            Console.WriteLine($"Issue Date: {IssueDate}");
            Console.WriteLine($"Expiration Date: {ExpirationDate}");
        }
    }
}
