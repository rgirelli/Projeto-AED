using System;
using System.IO;

class Recibo : Cliente{

  protected double valorTotal;

  public double ValorTotal{
    get{
      return valorTotal;
    }
    set{
      valorTotal = value;
    }
  }

  public void CriarRecibo(){
    Console.WriteLine("**R E C I B O**");
    Console.Write("Cliente: ");
    Nome = Console.ReadLine();
    Console.Write("Telefone: ");
    Telefone = Console.ReadLine();
    Console.Write("Endereço: ");
    Endereco = Console.ReadLine();

  }

  public void ImprimirDados(){
    Console.WriteLine("Cliente: "+Nome);
    Console.WriteLine("Telefone: "+Telefone);
    Console.WriteLine("Endereco: "+Endereco);
  }

}