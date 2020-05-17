using System;
using System.IO;
// a classe cliente juridico é classe filha de cliente 
class ClienteJuridico : Cliente{
  protected string cnpj;

// tornando os arquivos publicos para serem trabalhados 
  public string Cnpj{
    get{
      return cnpj;
    }
    set{
      cnpj = value;
    }
  }
    // puxando dados necessários da classe pai cliente
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