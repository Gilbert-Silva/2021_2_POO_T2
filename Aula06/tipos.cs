using System;
using System.Globalization;
using System.Threading;

class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");    

    // Valores locais
    int x = 5;       // struct - valor
    string s = "C#"; // class  - referencia
    Produto d = new Produto();  
    DiadaSemana dia = DiadaSemana.Domingo;
    object obj = d;
    obj = 10;
    int y = (int) obj;

    DateTime z = DateTime.Now; // Propriedade Estática
    //z = DateTime.Parse("2021-12-31");

    TimeSpan t = new TimeSpan(1, 2, 0, 0);

    Console.WriteLine(x.ToString() + x.ToString());
    Console.WriteLine(s);
    Console.WriteLine(d);
    Console.WriteLine(dia);
    Console.WriteLine((int)dia);
    Console.WriteLine(obj);
    Console.WriteLine(z);
    Console.WriteLine(z.Day); // Propriedade da Instância
    Console.WriteLine(z.Month);
    Console.WriteLine(z.Year);
    Console.WriteLine(z.DayOfWeek);
    Console.WriteLine($"{z:dd/MM/yyyy hh:mm}");
    Console.WriteLine($"{z:ddd/MMM/yyyy hh:mm}");
    Console.WriteLine($"{z:dddd}");
    Console.WriteLine($"{z:MMMM}");
    Console.WriteLine(t);
    Console.WriteLine(t.Days);
    Console.WriteLine(t.Hours);
    Console.WriteLine(z + t);

    Aluno aluno; // = new Aluno();
    aluno.nome= "Gilbert";
    aluno.matricula = "1234";
    aluno.idade = 30;
    Console.WriteLine(aluno.nome);
    Console.WriteLine(aluno.matricula);
    Console.WriteLine(aluno.idade);
    
    /*
    DiadaSemana x = DiadaSemana.Domingo;
    Console.WriteLine(x);
    Console.WriteLine((int)x);
    DiadaSemana y = DiadaSemana.Segunda;
    Console.WriteLine(y);
    Console.WriteLine((int)y);
    DiadaSemana z = DiadaSemana.Domingo | DiadaSemana.Segunda;
    Console.WriteLine(z);
    Console.WriteLine((int)z);

    dynamic v = 10;
    Console.WriteLine(v + v);
    //Console.WriteLine(v.Substring(0, 1));
    v = "10";
    Console.WriteLine(v + v);
    Console.WriteLine(v.Substring(0, 1));
    */
  }

}

enum EstadoCivil { Solteiro, Casado, Viuvo, Divorciado }

[Flags] // Conjunto
enum DiadaSemana { Nenhum, Domingo = 1, Segunda = 2, Terça = 4, Quarta = 8, Quinta = 16, Sexta = 32, Sábado = 64 }

class Produto {

}

struct Aluno {
  public string nome;
  public string matricula;
  public int idade;
}