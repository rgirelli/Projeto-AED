using System;
using System.IO;

class Cardapio{

  public void ExibirCardapio(){
  string[] lines = File.ReadAllLines("Cardapio.txt");

      foreach(var line in lines) Console.WriteLine(line);
 }
}