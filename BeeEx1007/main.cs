using System;

class Program {
  public static void Main (string[] args) {
    int a, b, c, d, calculo;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    calculo = (a*b) - (c*d);
    Console.WriteLine("DIFERENCA = {0}", calculo);
    
  }
}