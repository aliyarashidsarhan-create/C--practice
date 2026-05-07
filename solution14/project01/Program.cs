namespace project01
{
    internal class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is Eating");
            }
            public virtual void sound()
            {
                Console.WriteLine("Animal make sound");
            }
            public virtual void sleep()
            {
                Console.WriteLine("Animal is sleep");
            }
        }
        class Dog : Animal
        {
            public override void sound()
            {
                Console.WriteLine("Dog barks");
            }
            public override void sleep()
            {
                Console.WriteLine("Dog id sleep");
            }
        }
        

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.sleep();
            dog.sound();
        }
    }
}
