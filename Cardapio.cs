//Para uso de Console 
using System;
//Manipulação de Arquivos 
using System.IO;

// Classe Cardápio
class Cardapio{

// Percorre todas as Linhas e guarda dentro da variável

  public void ExibirCardapio(){
  string[] lines = File.ReadAllLines("Cardapio.txt");

      
      foreach(var line in lines) Console.WriteLine(line);
 }
}