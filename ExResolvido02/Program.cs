
namespace ExResolvido02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, alt, area, per, diag;
            b = double.Parse(Console.ReadLine());
            alt = double.Parse(Console.ReadLine());
            area = b * alt;
            per = (b + alt) * 2;
            diag = Math.Sqrt(Math.Pow(b,2) + Math.Pow(alt,2));
            Console.WriteLine("AREA = {0}", area.ToString("F4"));
            Console.WriteLine("PERÍMETRO = {0}", per.ToString("F4"));
            Console.WriteLine("DIAGONAL = {0}", diag.ToString("F4"));


        }
    }
}