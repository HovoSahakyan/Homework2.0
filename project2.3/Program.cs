namespace project2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write here your year of birth ");
            string age = Console.ReadLine();
            int year = Convert.ToInt32(age);
            Console.WriteLine($"You are {2024 - year} years old ");
        }
    }
}
