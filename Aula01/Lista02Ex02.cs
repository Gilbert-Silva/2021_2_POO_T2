using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome completo:");
    string s = Console.ReadLine();

    int x = s.IndexOf(' ');
    Console.WriteLine($"Bem-vindo ao C#, {s.Substring(0, x)}");

    string[] v = s.Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {v[0]}");
  }
}