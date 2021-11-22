using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite a média da disciplina");
    int m = int.Parse(Console.ReadLine());

    if (m < 0)
      Console.WriteLine("Valor menor que o permitido");
    if (m >= 0 && m <= 100)  // 0 <= m <= 100
      Console.WriteLine("Valor Ok");
    if (m > 100)
      Console.WriteLine("Valor maior que o permitido");

    if (m < 0) {
      Console.WriteLine("Valor menor que o permitido");
    }
    else {
      if (m <= 100)  // 0 <= m <= 100
        Console.WriteLine("Valor Ok");
      else 
        Console.WriteLine("Valor maior que o permitido");
    }    

  }
}