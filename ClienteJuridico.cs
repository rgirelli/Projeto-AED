using System;
using System.IO;

class ClienteJuridico : Cliente{
  protected string cnpj;

  public string Cnpj{
    get{
      return cnpj;
    }
    set{
      cnpj = value;
    }
  }

   public void CadastrarJuridico(){
    
        Console.WriteLine("**CADASTRO DE CLIENTE JURÍDICO**");
        Console.Write("Nome: ");
        Nome = Console.ReadLine();
        Console.Write("Endereço: ");
        Endereco = Console.ReadLine();
        Console.Write("Telefone: ");
        Telefone = Console.ReadLine();
        Console.Write("E-mail: ");
        Email = Console.ReadLine();
        Console.Write("Cnpj: ");
        Cnpj = Console.ReadLine();
        File.WriteAllText("cadastro.txt", "**CADASTRO DO CLIENTE**\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone +"\nE-mail: " +Email + "\nCNPJ: " + Cnpj);

      
    }
}