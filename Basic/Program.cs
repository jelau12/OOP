using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new();
            p.FirstName = "Jesper";
            p.LastName = "Lauridsen";
            p.BirthDate = new DateTime(2001, 04, 29);
            p.Height = 193.2;
            p.Weight = 76.8;

            string fullname = p.GetFullName();
            Console.WriteLine($"your fullname is {fullname}" + "\n");

            string initials = p.GetInitials().ToUpper();
            Console.WriteLine($"Your initials are: {initials}" + "\n");

            int age = p.GetAgeToday();
            Console.WriteLine($"You're {age} year(s) old" + "\n");

            bool older = p.IsOlderThan(25);
            Console.WriteLine(older + "\n");

            int ageAt = p.GetAgeAt(new DateTime(2002, 04, 29));
            Console.WriteLine($"You were {ageAt} year(s) old at the time" +
                "\n");

            double bmi = p.GetBmiNumber();
            Console.WriteLine($"Your BMI is {bmi}" + "\n");

            string decription = p.BmiDecription(p.GetBmiNumber());
            Console.WriteLine($"you are {decription}" + "\n");

            string narative = p.NarrativeDecription(new DateTime(2008, 08, 13));
            Console.WriteLine(narative);

            Console.ReadLine();
        }
    }
}