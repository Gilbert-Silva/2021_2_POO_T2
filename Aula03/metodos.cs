using System;

public class Program {

  public static void Main() {
    int i = 1;
    // 0000.0001
    // 0000.0100
    Console.WriteLine(i << 2);
    Console.WriteLine("Digite a média da disciplina");
    // int m = int.Parse(Console.ReadLine());
    int m;
    if (int.TryParse(Console.ReadLine(), out m))
    {
      if (Testes.VerificarMedia(m))
        Console.WriteLine("Nota válida");
      else  
        Console.WriteLine("Nota inválida");

      switch(m) {
        case 100: Console.WriteLine("Parabéns"); break;
        case 99: Console.WriteLine("Muito bom"); break;
      }

    }
    else 
      Console.WriteLine("Valor informado não é um número");
  }
  public static bool VerificarMedia(int x) {
    if (x >= 0 && x <= 100) return true;
    else return false;
  }
}

public class Testes {
  public static bool VerificarMedia(int x) {
    if (x >= 0 && x <= 200) return true;
    else return false;
  }
}
