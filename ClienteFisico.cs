using System;
using System.IO;
// cliente fisico é classe filha de cliente
class ClienteFisico : Cliente {
  protected string dataNascimento;
  protected string cpf;

    // tornando arquivos publicos para serem manipulados 
  public string DataNascimento{
    get {
      return dataNascimento;

    }
    set{
      dataNascimento = value;

    }
  }


  public string Cpf{
    get{
      return cpf;
    }
    set {
      cpf = value;
    }

  }


       
  
    // utilizandos dados da herança da classe cliente
  public void CadastrarFisico(){
    
        Console.WriteLine("**CADASTRO DE CLIENTE FÍSICO**");
        Console.Write("Nome: ");
        Nome = Console.ReadLine();
        Console.Write("Endereço: ");
        Endereco = Console.ReadLine();
        Console.Write("Telefone: ");
        Telefone = Console.ReadLine();
        Console.Write("E-mail: ");
        Email = Console.ReadLine();
        Console.Write("Data de nascimento: ");
        DataNascimento = Console.ReadLine();
        Console.Write("CPF: ");
        Cpf = Console.ReadLine();
        File.WriteAllText("cadastro.txt", "**CADASTRO DO CLIENTE**\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone +"\nE-mail: " +Email + "\nData de nascimento: " +DataNascimento + "\nCPF: " + Cpf);

      
    }
  }



