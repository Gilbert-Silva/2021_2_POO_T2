using System;

public class Program {
  public static void Main() {
    int m = 0;
    do {
      Console.WriteLine("Digite a média da disciplina");
      m = int.Parse(Console.ReadLine());
    }
    while (m < 0 || m > 100);  

  }
}