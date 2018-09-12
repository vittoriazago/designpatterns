using static System.Console;

namespace Solid
{
    public class Animal
    {
        public virtual int Age { get; set; }

        public int DateOfBirth() => System.DateTime.Today.Year - Age;

        public Animal()
        {

        }

        public Animal(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"{nameof(Age)}: {Age}";
        }
    }

    public class Human : Animal
    {
        public override int Age // nasty side effects
        {
            set { base.Age = base.Age = value; }
        }
    }
    
}
