namespace Ex1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, a, pi;
            r = double.Parse(Console.ReadLine());
            pi = 3.14159;
            a = pi * (r * r);
            Console.WriteLine("A = {0}", a.ToString("F4"));
        }
    }
}