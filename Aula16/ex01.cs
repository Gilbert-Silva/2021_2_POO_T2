using System;

class Program {
  public static void Main() {
    Funcionario x = new Funcionario("Nome1", 3000);
    Console.WriteLine(x.GetNome());
    Console.WriteLine(x.GetSalario());
    Console.WriteLine(x);

    object y = new Funcionario("Nome2", 5000);
    //Console.WriteLine(y.GetNome());
    //Console.WriteLine(y.GetSalario());
    Console.WriteLine(y);

    object z = new Gerente("Nome3", 3000, 1000);
    //Console.WriteLine(z.GetNome());
    //z.Premiar(1000);
    //Console.WriteLine(z.GetSalario());
    Console.WriteLine(z);

  }
}

class Funcionario : object {
  private string nome;
  private double salarioBase;
  public Funcionario(string n, double s) {
    nome = n;
    salarioBase = s;
  }
  public string GetNome() {
    return nome;
  }
  public virtual double GetSalario() {
    return salarioBase;
  }
  public override string ToString() {
    return $"{nome} - {GetSalario()}";
  }
}

class Gerente : Funcionario {
  private double gratificacao;
  public Gerente(string n, double s, double g) : base(n, s) {
    gratificacao = g;
  }
  public override double GetSalario() {
    return base.GetSalario() + gratificacao;
  }
  public void Premiar(double reajuste) {
    gratificacao += reajuste;
  }
}