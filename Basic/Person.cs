using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }


        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetInitials()
        {
            string firstname = FirstName.Substring(0, 2);
            string lastname = LastName.Substring(0, 2);

            return $"{firstname}{lastname}";
        }
        public int GetAgeToday()
        {
            int ageToday = GetAgeAt(DateTime.Now);

            return ageToday;
        }
        public bool IsOlderThan(int age)
        {
            if (age > GetAgeToday())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetAgeAt(DateTime date)
        {
            int age = date.Year - BirthDate.Year;
            if (BirthDate > date.AddYears(-age)) age--;

            return age;

        }
        public double GetBmiNumber()
        {
            double height = Height / 100;
            double bmi = Weight / (height * height);
            return bmi;
        }

        #region BmiDecription
        public string BmiDecription(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Under Weight";
            }
            if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal Weight";
            }
            if (bmi >= 25.0 && bmi <= 29.9)
            {
                return "Pre-obesity";
            }
            if (bmi >= 30.0 && bmi <= 34.9)
            {
                return "Obesity class 1";
            }
            if (bmi >= 35.0 && bmi <= 39.9)
            {
                return "Obesity class 2";
            }
            else
            {
                return "Obesity class 3";
            }
        }
        #endregion

        public string NarrativeDecription(DateTime date)
        {
            return $"lille {GetFullName()} blev født den {BirthDate.ToString("dd MMMM yyyy")} " +
                 $"og er i dag den {DateTime.Now.ToString("dd MMMM yyyy")} {GetAgeToday()} år gammel lille jesper var {GetAgeAt(date)}" +
                 $" år i {date.ToString("yyyy")} og har et bmi på {GetBmiNumber()} og han er {BmiDecription(GetBmiNumber())}";
        }
    }
}