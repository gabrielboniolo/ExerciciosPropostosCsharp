namespace ExResolvido03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            string[] vetor = Console.ReadLine().Split(' ');
            nome1= vetor[0];
            idade1 = int.Parse(vetor[1]);
            nome2= vetor[2];
            idade2 = int.Parse(vetor[3]);
            double media = (idade1 + idade2) / 2;
            Console.WriteLine("As pessoas {0} e {1} possuem uma média de idade de {2} anos", nome1, nome2, media);
        }
    }
}