using System;

class Program {
  public static void Main() {
    int[] v = new int[10] { 20, 5, 65, 2, 7, 1, 3, 7, 80, 5 };
    // int v[10]; 
    Array.Reverse(v);
    Console.WriteLine(v);
    foreach (int x in v) // for (x : v)
      Console.WriteLine(x);

    Console.WriteLine(v[0]);
    Console.WriteLine(v[9]);

    for (int i = 0; i < v.Length; i++)
      Console.WriteLine(v[i]);

    string[] vs = {"Java", "C#", "Python", "Assembly" };
    foreach (string s in vs) 
      Console.WriteLine(s);

    Array.Sort(vs);
    foreach (string s in vs) 
      Console.WriteLine(s);

    Array.Resize(ref vs, 6);  
    vs[4] = "Visual Basic";
    vs[5] = "Javascript";
    foreach (string s in vs) 
      Console.WriteLine(s);

    int[,]m = new int[3,4];
    Console.WriteLine(m[0,0]); // m[0][0]

    object[] objs = { 1, "C#", "Python", 4.5, false };
    foreach(object obj in objs)
      Console.WriteLine($"{obj} - {obj.GetType()}");
    objs[1] = vs;
    foreach(object obj in objs)
      Console.WriteLine($"{obj} - {obj.GetType()}");

    int p = Array.IndexOf(vs, "C++");
    Console.WriteLine(p);
    p = Array.IndexOf(vs, "Python");
    Console.WriteLine(p);



  }
}