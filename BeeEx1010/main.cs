using System;

class Program {
  public static void Main (string[] args) {
    int cod1, cod2, qtd1, qtd2;
    double preco1, preco2, total;
    string[] produto = Console.ReadLine().Split(' ');
    cod1 = int.Parse(produto[0]);
    qtd1 = int.Parse(produto[1]);
    preco1 = double.Parse(produto[2]);
    produto = Console.ReadLine().Split(' ');
    cod2 = int.Parse(produto[0]);
    qtd2 = int.Parse(produto[1]);
    preco2 = double.Parse(produto[2]);
    total = (double) (qtd1*preco1) + (qtd2*preco2);
    Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("F2"));
    
    
  }
}