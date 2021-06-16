using System;

class MainClass {
  public static void Main (string[] args) {

    int var1 = 10;
    int var2 = 2;

    Console.WriteLine("Orperadores arimeticos");
    Console.WriteLine (var1 + var2);
    Console.WriteLine (var1 - var2);
    Console.WriteLine ( var1 / var2);
    Console.WriteLine (var1 * var2);
    Console.WriteLine ( var1 % var2);

    Console.WriteLine("Orperadores logicos");
    Console.WriteLine(var1 == var2);
    Console.WriteLine(var1 != var2);
    Console.WriteLine(var1 < var2);
    Console.WriteLine(var1 > var2);
    Console.WriteLine(var1 <= var2);
  }
}