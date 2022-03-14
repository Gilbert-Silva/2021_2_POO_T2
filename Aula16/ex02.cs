using System;
using System.Collections.Generic;
using System.Linq;

public delegate void Metodo(string s);

class Program {
  public static void Mensagem(string s) {
    Console.WriteLine(s);
  }
  
  public static void Main() {
    Mensagem("Olá");

    Metodo r = Mensagem;
    r("Blz?");

    Metodo r2 = w => Console.WriteLine(w + w);
    r2("Ok");
    
    Figura3D x = new Esfera("Azul", 10);
    Console.WriteLine(x.GetVolume());
    Console.WriteLine(x); // ToString

    Figura3D y = new Cubo("Amarelo", 10);
    Console.WriteLine(y.GetVolume());
    Console.WriteLine(y); // ToString

    Cliente a = new Cliente { Id=1, Nome="B"};
    Cliente b = new Cliente { Id=2, Nome="X"};
    Cliente c = new Cliente { Id=3, Nome="A"};
    List<Cliente> lc = new List<Cliente>();
    lc.Add(a);
    lc.Add(b);
    lc.Add(c);
    var z = lc.OrderBy(v => v.Nome);
    Console.WriteLine(z.GetType());
    foreach(Cliente obj in z) 
      Console.WriteLine(obj.Nome);
    
  }
}

abstract class Figura3D {
  private string cor;
  public Figura3D(string cor) {
    this.cor = cor;
  }
  public abstract double GetVolume();
  public override string ToString() {
    return base.ToString() + " " + cor;
  }
}

interface IFigura3D {
  double GetVolume();
}

class Esfera : Figura3D {
  private double raio;
  public Esfera(string c, double r) : base(c) {
    raio = r;
  }
  public override double GetVolume() {
    return 4.0/3 * Math.PI * raio*raio*raio;
  }
}

class Cubo : Figura3D {
  private double lado;
  public Cubo(string c, double l) : base(c) {
    lado = l;
  }
  public override double GetVolume() {
    return Math.Pow(lado, 3);
  }
}

public class Cliente {
  // Propriedade do Cliente
  public int Id { get; set; }
  public string Nome { get; set; }
  public DateTime Nascimento { get; set; }
}