namespace project2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write here your age");
            string year = Console.ReadLine();
            int age = Convert.ToInt32(year);
            Console.WriteLine($"You was born in {2024 - age}");
        }
    }
}
