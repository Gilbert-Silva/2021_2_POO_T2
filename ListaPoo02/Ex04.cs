using System;

class ContaBancaria {
  private string titular, numero;
  private double saldo; // decimal
  public ContaBancaria(string titular, string numero) {
    this.titular = titular;
    this.numero = numero;
    //this.saldo = 0;
  }
  public void SetTitular(string titular) {
    this.titular = titular;
  }
  public void SetNumero(string numero) {
    this.numero = numero;
  }
  public string GetTitular() {
    return titular;
  }
  public string GetNumero() {
    return numero;
  }
  public double GetSaldo() {
    return saldo;
  }
  public void Depositar(double valor) {
    saldo += valor;
  }
  public bool Sacar(double valor) {
    if (saldo >= valor) {
      saldo -= valor;
      return true;
    }
    return false;
  }
  public override string ToString() {
    return $"Titular = {titular}, Numero = {numero}, Saldo = {saldo:0.00}";
  }
}

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria("Jose", "1234-x");
    ContaBancaria y = new ContaBancaria("Maria", "4321-x");

    Console.WriteLine(x);
    x.Depositar(1000);
    Console.WriteLine(x);
    Console.WriteLine(x.Sacar(300));
    Console.WriteLine(x);
    Console.WriteLine(x.Sacar(1000));
    Console.WriteLine(x);

    Console.WriteLine(y);

    x = y;

    Console.WriteLine(x);
    y.Depositar(1500);
    Console.WriteLine(x);
    x.Sacar(1000);
    Console.WriteLine(y);

    x = null;
    y = null;

  }
}

