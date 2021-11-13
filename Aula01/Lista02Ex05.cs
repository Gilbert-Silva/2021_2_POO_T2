using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite o intervalo de tempo no formato HH:MM:SS");
    string t = Console.ReadLine();
    int h = int.Parse(t.Substring(0, 2));
    int m = int.Parse(t.Substring(3, 2));
    int s = int.Parse(t.Substring(6, 2));
    long dist = (long)300000 * (s + m * 60 + h * 3600);
    double distR = 300000.0 * (s + m * 60 + h * 3600);
    Console.WriteLine($"A luz percorreu {dist} km nesse intervalo");
    Console.WriteLine($"A luz percorreu {distR} km nesse intervalo");
  }
}



    