using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    /*
    Produto p1 = new Produto("Refri", 4.5);
    Produto p2 = new Produto("Arroz", 3);
    //Carrinho c = new Carrinho();
    Colecao<Produto> c = new Colecao<Produto>();
    c.Inserir(p1);
    c.Inserir(p2);
    foreach(Produto p in c.Listar())
      Console.WriteLine(p);

    Aluno a1 = new Aluno("Arthur", "mat2");
    Aluno a2 = new Aluno("Alcides", "mat1");
    //Turma t = new Turma();
    Colecao2<Aluno> t = new Colecao2<Aluno>();
    t.Inserir(a1);
    t.Inserir(a2);
    foreach(Aluno a in t.Listar())
      Console.WriteLine(a);

    Lista<int> li = new Lista<int>();
    li.Add(10);
    li.Add(20);
    li.Add(30);
    li.Add(40);
    li.Add(50);
    li.Add(60);
    foreach(int i in li.ToArray())
      Console.WriteLine(i);
    Lista<string> ls = new Lista<string>();
    ls.Add("C#");  
    ls.Add("Java");  
    ls.Add("Python");  
    ls.Add("Ruby");  
    ls.Add("Assembly");  
    foreach(string i in ls.ToArray())
      Console.WriteLine(i);
    List<int> li2 = new List<int>();
    li2.Add(10);
    li2.Add(20);
    li2.Add(30);
    li2.Add(40);
    li2.Add(50);
    li2.Add(60);
    foreach(int i in li2.ToArray())
      Console.WriteLine(i);
    Console.WriteLine(li2[0]);  

    Mensagem<int>(10);
    Mensagem<string>("C#");
    Mensagem<Produto>(p1);
    //Pilha(1);
    */
    Colecao<int> col1 = new Colecao<int>();
    col1.Inserir(15);
    col1.Inserir(25);
    foreach(int i in col1.Listar())
      Console.WriteLine(i);
    Colecao<int> col2 = new Colecao<int>();
    col2.Inserir(35);
    col2.Inserir(45);
    foreach(int i in col2.Listar())
      Console.WriteLine(i);

    Colecao<Colecao<int>> cols = new Colecao<Colecao<int>>();
    cols.Inserir(col1);
    cols.Inserir(col2);
    foreach(Colecao<int> i in cols.Listar()) {
      Console.WriteLine(i);
      if (i != null) {
        foreach(int j in i.Listar()) Console.WriteLine(j);
      }
    }
    /*
    Pilha LIFO
    Fila  FIFO
    Vetor []
    Dicionário Ordenado chave-valor
    Dicionário não Ordenado
    */

  }

  public static void Pilha(int k) {
    Console.WriteLine(k);
    Pilha(k + 1);
  }

  public static void Mensagem<T>(T obj) {
    Console.WriteLine(obj);
  }
}

class Lista<T> {
  private T[] vetor = new T[2];
  private int k;
  /*
  public Lista<T>(int n) { 
    vetor = new T[n];
  }
  */
  public void Add(T obj) {
    if (k == vetor.Length) {
      Array.Resize(ref vetor, 2 * vetor.Length);
    }
    vetor[k++] = obj;
  }
  public T[] ToArray() {
    T[] aux = new T[k];
    Array.Copy(vetor, aux, k);
    return aux;
  }
}

class Colecao<T> {
  private T[] vetor = new T[10];
  private int k;
  public void Inserir(T p) {
    vetor[k] = p;
    k++;
  }
  public T[] Listar() {
    return vetor;
  }
}

class Colecao2<T> where T : IComparable, IComparable<T> {
  private T[] vetor = new T[10];
  private int k;
  public void Inserir(T p) {
    vetor[k] = p;
    k++;
  }
  public T[] Listar() {
    Array.Sort(vetor);
    return vetor;
  }
}

class Carrinho { // Array
  private Produto[] vetor = new Produto[10];
  private int k;
  public void Inserir(Produto p) {
    vetor[k] = p;
    k++;
  }
  public Produto[] Listar() {
    return vetor;
  }
}

class Carrinho2 { // List
  private List<Produto> vetor = new List<Produto>();
  public void Inserir(Produto p) {
    vetor.Add(p);
  }
  public List<Produto> Listar() {
    return vetor;
  }
  public void Excluir(Produto p) {
    vetor.Remove(p);
  }
}


class Turma {
  private Aluno[] vetor = new Aluno[10];
  private int k;
  public void Inserir(Aluno p) {
    vetor[k] = p;
    k++;
  }
  public Aluno[] Listar() {
    Array.Sort(vetor);
    return vetor;
  }
}

class Produto {
  private string nome;
  private double preco;
  public Produto(string n, double p) {
    nome = n;
    preco = p;
  }
  public override string ToString() {
    return $"{nome} {preco:0.00}";
  }
}

class Aluno : IComparable, IComparable<Aluno> {
  private string nome;
  private string matricula;
  public Aluno(string n, string m) {
    nome = n;
    matricula = m;
  }
  public override string ToString() {
    return $"{nome} {matricula}";
  }
  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj;
    return this.nome.CompareTo(x.nome);
  }
  public int CompareTo(Aluno obj) {
    return this.nome.CompareTo(obj.nome);
  }
}
