namespace Ex1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, media;
            notaA= double.Parse(Console.ReadLine());
            notaB= double.Parse(Console.ReadLine());
            media = (notaA + notaB) / 2.0;
            Console.WriteLine("MEDIA = {0}", media);


        }
    }
}