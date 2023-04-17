using System;

class Program {
  public static void Main (string[] args) {
    double a, b, c, media;
    a = double.Parse(Console.ReadLine())*2.0;
    b = double.Parse(Console.ReadLine())*3.0;
    c = double.Parse(Console.ReadLine())*5.0;
    media = (a + b + c) / 10.0;
    Console.WriteLine("MEDIA = {0}", media);
  }
}