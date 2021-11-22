using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a média da disciplina");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a frequência");
    int f = int.Parse(Console.ReadLine());
    //bool teste = m >= 60 && f >= 75;
    if (m >= 60 && f >= 75) {
      Console.WriteLine("Parabéns");
      Console.WriteLine("Aprovado");
    }
    else {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }
/*
    if (m < 60 || f < 75) {
      Console.WriteLine("Se dedique mais");
      Console.WriteLine("Reprovado");
    }
*/    
  }
}
