namespace Multilevel_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            Pets pets = new Pets();
            pets.Eat();
            pets.Sound();
            Dog dog1 = new Pets();
            dog1.Eat();

        }
    }
}
