using System;

class Program {
  public static void Main() {
    double x;   // Valor indefinido - Stack
    x = 1.5;
    Console.WriteLine(x.ToString());
    Console.WriteLine(x.ToString("0.00"));
    
    Aluno y; // y - stack
    y = new Aluno(); // Objeto aluno - heap 
    Console.WriteLine(y.ToString());
    //y = null;

    Aluno z = new Aluno("Gilbert", 20);
    Console.WriteLine(z.ToString());
  }
}

class Object {
  public virtual string ToString() {
  }
}

class Aluno {
  private string nome;
  private int idade;
  public Aluno() { }
  public Aluno(string nome, int idade) { 
    this.nome = nome;
    this.idade = idade;
    // self
  }
  public void SetIdade(int x) {
    this.idade = x;
    //idade = x;
  }
  public override string ToString() {
    return $"Nome={nome} Idade={idade}";
  }
}
