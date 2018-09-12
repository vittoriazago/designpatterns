using System;
using System.Collections.Generic;
using System.IO;

namespace Solid
{
    public class Company
    {
        private readonly List<string> employees = new List<string>();

        private static int count = 0;

        public int AddEmployee(string name)
        {
            employees.Add($"{++count}: {name}");
            return count; 
        }

        public void RemoveEmploye(int index)
        {
            employees.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, employees);
        }

        // breaks single responsibility principle
        public bool IsValidDayOfWork(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }        
    }

    // handles the responsibility of validate day of work
    public static class Work
    {
        public static bool IsValidDayOfWork(DateTime date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
    
}
