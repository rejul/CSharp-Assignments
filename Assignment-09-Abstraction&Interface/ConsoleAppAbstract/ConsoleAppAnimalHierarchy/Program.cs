using System;

namespace ConsoleAppAnimalHierarchy
{
    // Abstract base class
    public abstract class Animal
    {
        public int NoOfLegs { get; set; }
        public string Color { get; set; }

        // Abstract methods (must be overridden in derived classes)
        public abstract string Cry();
        public abstract void Fly();
        public abstract void Walk();
    }

    // Cat class
    public class Cat : Animal
    {
        public Cat(int legs, string color)
        {
            NoOfLegs = legs;
            Color = color;
        }

        public override string Cry()
        {
            return "Meow";
        }

        public override void Fly()
        {
            Console.WriteLine("Cat cannot fly.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Cat is walking with {NoOfLegs} legs.");
        }
    }

    // Dog class
    public class Dog : Animal
    {
        public Dog(int legs, string color)
        {
            NoOfLegs = legs;
            Color = color;
        }

        public override string Cry()
        {
            return "Woof";
        }

        public override void Fly()
        {
            Console.WriteLine("Dog cannot fly.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Dog is walking with {NoOfLegs} legs.");
        }
    }

    // Goat class
    public class Goat : Animal
    {
        public Goat(int legs, string color)
        {
            NoOfLegs = legs;
            Color = color;
        }

        public override string Cry()
        {
            return "Baa";
        }

        public override void Fly()
        {
            Console.WriteLine("Goat cannot fly.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Goat is walking with {NoOfLegs} legs.");
        }
    }

    // Crow class
    public class Crow : Animal
    {
        public Crow(int legs, string color)
        {
            NoOfLegs = legs;
            Color = color;
        }

        public override string Cry()
        {
            return "Caw";
        }

        public override void Fly()
        {
            Console.WriteLine("Crow can fly up to 500 meters.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Crow is hopping with {NoOfLegs} legs.");
        }
    }

    // Chicken class
    public class Chicken : Animal
    {
        public Chicken(int legs, string color)
        {
            NoOfLegs = legs;
            Color = color;
        }

        public override string Cry()
        {
            return "Cluck";
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken can fly only up to 2 meters.");
        }

        public override void Walk()
        {
            Console.WriteLine($"Chicken is walking with {NoOfLegs} legs.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat(4, "White");
            Animal dog = new Dog(4, "Brown");
            Animal goat = new Goat(4, "Black");
            Animal crow = new Crow(2, "Black");
            Animal chicken = new Chicken(2, "Red");

            Console.WriteLine($"Cat Cry: {cat.Cry()}");
            cat.Fly();
            cat.Walk();

            Console.WriteLine($"Dog Cry: {dog.Cry()}");
            dog.Fly();
            dog.Walk();

            Console.WriteLine($"Goat Cry: {goat.Cry()}");
            goat.Fly();
            goat.Walk();

            Console.WriteLine($"Crow Cry: {crow.Cry()}");
            crow.Fly();
            crow.Walk();

            Console.WriteLine($"Chicken Cry: {chicken.Cry()}");
            chicken.Fly();
            chicken.Walk();
        }
    }
}
