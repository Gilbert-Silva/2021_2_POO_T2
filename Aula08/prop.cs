using System;
using System.Collections;

class Program {
  public static void Main() {
    int[] v = { 2, 4, 6 };
    IEnumerator x = v.GetEnumerator();
    x.MoveNext();
    Console.WriteLine(x.Current);
    x.MoveNext();
    Console.WriteLine(x.Current);


    Contato c1 = new Contato();
    c1.SetNome("Gilbert");
    c1.SetEmail("gilbert@email.com");
    Console.WriteLine(c1.GetNome());
    Console.WriteLine(c1.GetEmail());
    try {
      c1.SetNascimento(DateTime.Parse(Console.ReadLine()));
    }
    catch (Exception erro) {
      Console.WriteLine(erro.GetType());
      Console.WriteLine(erro.Message);
      Console.WriteLine("A data informada é inválida");
    }

    Contato2 c2 = new Contato2();
    c2.Nome = "Gilbert"; // Set - value
    c2.Email = "gilbert@email.com";
    string s = c2.Nome; // Get
    Console.WriteLine(c2.Nome);
    Console.WriteLine(c2.Email);

    Contato3 c3 = new Contato3();
    c3.Nome = "Gilbert";
    c3.Email = "gilbert@email.com";
    Console.WriteLine(c3.Nome);
    Console.WriteLine(c3.Email);
    //DateTime hoje = DateTime.Now;
    //DateTime dia = hoje.Date;
    //Console.WriteLine(hoje);
    //Console.WriteLine(dia);
    /*
    Contato3 c4 = new Contato3 {
      Nome = "Gilbert",
      Email = "gilbert@email.com"
    };

    Contato3 c5 = new Contato3 {
      Nome = "Gilbert"
    };

    Contato3 c6 = new Contato3 {
      Email = "gilbert@email.com"
    };
    */
  }
}
class Contato {
  enum EstadoCivil { Solteiro, Casado }
  private string nome;
  private string email;
  private DateTime nasc;

  public void SetNome(string nome) {
    this.nome = nome;
  } 
  public void SetEmail(string email) {
    this.email = email;
  } 
  public void SetNascimento(DateTime nasc) {
    DateTime hoje = DateTime.Today;
    DateTime dia = nasc.Date;
    if (hoje <= dia) 
      throw new ArgumentOutOfRangeException("Data inválida");
      // Gerar um erro
    else
      this.nasc = nasc;  
  } 
  public string GetNome() {
    return nome;
  }
  public string GetEmail() {
    return email;
  }
}

class Contato2 {
  private string nome;
  private string email;
  public string Nome {
    get { return nome; }
    set { nome = value; }
  }
  public string Email { get => email; set => email = value; }
//  {
//    get { return email; }
//    set { email = value; }
//  }
}

// POJO - POCO
// Plain Old Java Object
class Contato3 {
  public string Nome { get; set; }
  public string Email { get; set; }
}
