namespace project.x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your full name, age and your profession.");
            Console.WriteLine("Your full name ");
            string name = Console.ReadLine();
            Console.WriteLine("Your age");
            string age = Console.ReadLine();
            Console.WriteLine("Your profession");
            string pro = Console.ReadLine();

            Console.WriteLine($"Your full name is {name}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your profession is {pro}");

        }
    }
}
