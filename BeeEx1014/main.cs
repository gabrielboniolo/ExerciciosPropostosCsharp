using System;

class Program {
  public static void Main (string[] args) {
    int distanciaPercorrida;
    double combustivelGasto, media;
    distanciaPercorrida = int.Parse(Console.ReadLine());
    combustivelGasto = double.Parse(Console.ReadLine());
    media = (double) distanciaPercorrida / combustivelGasto;
    Console.WriteLine("{0} km/l", media.ToString("F3"));
  
  }
}