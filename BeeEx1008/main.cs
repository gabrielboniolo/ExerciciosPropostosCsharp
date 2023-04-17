using System;

class Program {
  public static void Main (string[] args) {
    int numeroFuncionario, horasTrabalhadas;
    double valorHora, salario;
    numeroFuncionario = int.Parse(Console.ReadLine());
    horasTrabalhadas = int.Parse(Console.ReadLine());
    valorHora = double.Parse(Console.ReadLine());
    salario = (double) horasTrabalhadas * valorHora;
    Console.WriteLine("NÚMERO = {0}", numeroFuncionario);
    Console.WriteLine("SALÁRIO = U$ {0}", salario.ToString("F2"));
  }
}