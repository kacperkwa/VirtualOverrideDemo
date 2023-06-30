namespace VirtualOverrideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Mella",10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Eat();
            dog.Play();
            dog.MakeSound();

            Console.ReadKey();
        }
    }
}