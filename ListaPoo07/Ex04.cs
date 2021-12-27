using System;

class Program {
  public static void Main() {
    Compromisso c1 = new Compromisso {
      Assunto = "Apresentação do Modelo",
      Local = "Meet",
      Data = DateTime.Parse("2022-01-03")
    };
    Compromisso c2 = new Compromisso {
      Assunto = "Apresentação do Aplicativo",
      Local = "Meet",
      Data = DateTime.Parse("2022-01-10")
    };
    Console.WriteLine(c1);
    Console.WriteLine(c2);
    Agenda x = new Agenda();
    x.Inserir(c1);
    x.Inserir(c2);
    foreach (Compromisso c in x.Listar())
      Console.WriteLine(c);
    Console.WriteLine(x.Qtd);
  }
}

class Agenda {
  private Compromisso[] comps = new Compromisso[10];
  private int k;
  public int Qtd { get { return k; } }
  public void Inserir(Compromisso c) {
    comps[k++] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] vet = new Compromisso[k];
    Array.Copy(comps, vet, k);
    return vet;
  }  
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Assunto} - {Local} - {Data:dd/MM/yyyy}";
  }
}