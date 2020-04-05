using System;

class MainClass {
  public static void Main (string[] args) {
  int NUM1,NUM2;
  string linea;
  Console.Write("Ingrese primer número:");
  linea=Console.ReadLine();
  NUM1=int.Parse(linea);
  Console.Write("Ingrese segundo número:");
  linea=Console.ReadLine();
  NUM2=int.Parse(linea);
  Console.WriteLine();
  Console.WriteLine("Primer número:" + NUM1);
  Console.WriteLine();
  Console.WriteLine("Segundo número:" + NUM2);
  int sum=NUM1 + NUM2;
  int difference=NUM1 - NUM2;
  int product=NUM1*NUM2;
  int quotient=NUM1/NUM2;
  Console.WriteLine();
  Console.WriteLine("La suma es:" + sum);
  Console.WriteLine("La resta es:" + difference);
  Console.WriteLine("La multiplicación es:" + product);
  Console.WriteLine("La división es:" + quotient);


  }
}