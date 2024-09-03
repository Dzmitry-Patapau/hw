namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dog dog = new Dog();
            dog.x = 1;
            dog.y = 1;
            Console.WriteLine($"x - {dog.x}, y - {dog.y}");
            Fun(dog);
            Console.WriteLine($"x - {dog.x}, y - {dog.y}");
            Console.ReadKey();
        }

        static void Fun(Dog dog)
        {
            dog.x = 2;
            dog.y = 2;
            Console.WriteLine($"x - {dog.x}, y - {dog.y}");
        }

        
    }

    struct Dog
    {
        public int x;
        public int y;
    }
}