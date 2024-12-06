using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task2
{
    public class ForeignPassport : Passport
    {
        protected string CountryCode;
        protected string Citizenship;

        public ForeignPassport(string fullName, string country, string issueDate, string expirationDate, string passportNumber, string countryCode, string citizenship) : base( fullName,  country,  issueDate,  expirationDate,  passportNumber)
        {
            CountryCode = countryCode;
            Citizenship = citizenship;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Country Code: {CountryCode}");
            Console.WriteLine($"Citizenship: {Citizenship}");
        }
    }
}
