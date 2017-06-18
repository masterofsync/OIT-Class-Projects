using System;

namespace OOPTesting
{
    /// <summary>
    /// Simple program to Test inheritance and Polymorphism
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Dogs*************");
            Animals dog=new Dog();
            dog.Feed();
            dog.Move();
            dog.Sound();
            Console.WriteLine("*************Cats*************");
            Animals cat = new Cat();
            cat.Feed();
            cat.Move();
            cat.Sound();
        }
    }

    /// <summary>
    /// abstract Animal base class for testing inheritance and Polymorphism
    /// </summary>
    public abstract class Animals
    {
        /// <summary>
        /// Different Sounds that Animals make
        /// </summary>
        public virtual void Sound()
        {
            Console.WriteLine("Animals make different sound. My derived class will override me to make those sounds!");
        }

        /// <summary>
        /// I will keep this Move the same for all animals to test inheritance
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Walk Walk");
        }

        /// <summary>
        /// Animals feed on different food. Lets test Polymorphism.
        /// </summary>
        public virtual void Feed()
        {
            Console.WriteLine("Animals feed on different foods. My derived class will override me to feed on specific food!");
        }
    }

    /// <summary>
    /// A type of animal : Dog Class that inherits Animals
    /// </summary>
    public class Dog : Animals
    {
        public Dog()
        {
            
        }

        /// <summary>
        /// Dogs bark. lets override it
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Dog:: Bow Bow!");
        }

        /// <summary>
        /// Dogs feed on different foods. Lets feed them dog biscuits
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine("Dog: I like dog biscuits!!");
        }
    }

    public class Cat : Animals
    {
        public Cat()
        {

        }

        /// <summary>
        /// Cats Meow. Lets override the base method.
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Cat:: Meow Meow!");
        }

        /// <summary>
        /// Cats like fish. Lets override the food as well
        /// </summary>
        public override void Feed()
        {
            Console.WriteLine("Cat: I like fish!!");
        }
    }
}
