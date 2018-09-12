using Solid;
using System;
using Xunit;

namespace SolidTest
{
    public class SolidTests
    {
        [Fact]
        public void SingleResponsabilityTest()
        {
            var company = new Company();
            company.AddEmployee("Vittoria Zago");
            company.AddEmployee("John Doe");
            Console.WriteLine(company);

            Console.WriteLine("Day of work is valid: " + Work.IsValidDayOfWork(DateTime.Today));
        }

        [Fact]
        public void OpenClosedTest()
        {
        }

        [Fact]
        public void LiskovSubstitutionTest()
        {
            Animal animal = new Animal(2);
            Console.WriteLine($"{animal} has born in {animal.DateOfBirth()}");

            // should be able to substitute a base type for a subtype
            /*Human*/
            Animal human = new Human();
            human.Age = 4;
            Console.WriteLine($"{human} has born in {human.DateOfBirth()}");
        }

        [Fact]
        public void InterfaceSegregationTest()
        {
        }
    }
}
