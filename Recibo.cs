using System;
using System.IO;


// classe recibo que possui é classe filha de cliente
class Recibo : Cliente{

  protected double valorTotal;


  // tornando arquivos publicos 
  public double ValorTotal{
    get{
      return valorTotal;
    }
    set{
      valorTotal = value;
    }
  }
    //puxando os dados necessários da classe clientr
  public void CriarRecibo(){
    Console.WriteLine("**R E C I B O**");
    Console.Write("Cliente: ");
    Nome = Console.ReadLine();
    Console.Write("Telefone: ");
    Telefone = Console.ReadLine();
    Console.Write("Endereço: ");
    Endereco = Console.ReadLine();

  }
    // imprimindo os dados para o usuário
  public void ImprimirDados(){
    Console.WriteLine("Cliente: "+Nome);
    Console.WriteLine("Telefone: "+Telefone);
    Console.WriteLine("Endereco: "+Endereco);
  }

}