using System;
using System.Collections;

class Program {
  public static void Main() {
    int x = 5;
    int y = 10;
    Console.WriteLine(x.CompareTo(y));
    Console.WriteLine(y.CompareTo(x));
    Console.WriteLine(x.CompareTo(5));

    if (x.CompareTo(y) < 0)  {

    }
    if (x < y) {

    }

    string s = "Java";
    string r = "C#";
    //if (s > r) {

    //}
    if (s.CompareTo(r) > 0) {
      Console.WriteLine("Ok");
    }

    string[] vs = { "Java", "Python", "C++", "Visual Basic", "Assembly"};
    Array.Sort(vs);
    foreach (string z in vs)
      Console.WriteLine(z);

    Aluno a1 = new Aluno { Nome="Gilbert", Idade = 30 };
    Aluno a2 = new Aluno { Nome="Eduardo", Idade = 35 };
    Aluno[] va = { a1, a2 };
    Array.Sort(va); // IComparable - Nome
    foreach (Aluno z in va)
      Console.WriteLine(z);

    CompIdade c = new CompIdade();
    Array.Sort(va, c); // IComparer - Idade
    foreach (Aluno z in va)
      Console.WriteLine(z);

    //a1.CompareTo(a2);

    IEnumerator it = va.GetEnumerator();
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    
    object t1 = new Turma();
    IEnumerable t2 = new Turma();
    Turma t3 = new Turma();

    IComparable ss = "Java";
    Console.WriteLine(ss.CompareTo("C#"));
    Console.WriteLine(ss.Substring(2, 2));

  }
}

class Aluno : IComparable {
  public string Nome {get;set;}
  public int Idade {get;set;}
  public override string ToString() {
    return $"{Nome} {Idade}";
  }
  public int CompareTo(object obj) {
    Aluno aux = (Aluno) obj; // Type cast
    //if (this.Idade < aux.Idade) return -1;
    //if (this.Idade > aux.Idade) return 1;
    //return 0;
    //return this.Idade.CompareTo(aux.Idade);
    return this.Nome.CompareTo(aux.Nome);
  }
}

class CompIdade : IComparer {
  public int Compare(object obj1, object obj2) {
    Aluno aux1 = (Aluno) obj1; // Type cast
    Aluno aux2 = (Aluno) obj2; // Type cast
    return aux1.Idade.CompareTo(aux2.Idade);
  }
}

class Turma : IEnumerable {
  public Aluno[] alunos = new Aluno[100];
  public IEnumerator GetEnumerator() {
    return null;
  }
}


