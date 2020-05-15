using System;
using System.IO;

class Cliente{
  
  private string nome;
  private string endereco;
  private string telefone;
  private string email;
  private string dataNascimento;
  
  
  public string Nome{
    get{
      return nome;
    }
    set{
      nome = value;
    }
  }

  public string Endereco{
    get{
      return endereco;
    }
    set{
      endereco = value;
    }
  }

  public string Telefone{
    get{
      return telefone;
    }
    set{
      telefone = value;
    }
  }

  public string Email{
    get{
      return email;
    }
    set{
      email = value;
    }
  }

  public string DataNascimento{
    get{
      return dataNascimento;
    }
    set{
      dataNascimento = value;
    }
  }

  public void CadastrarCliente()
  {
    Console.WriteLine("**CADASTRO DO CLIENTE**");
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
        File.WriteAllText("cadastro.txt", "**CADASTRO DO CLIENTE**\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone +"\nE-mail: " +Email + "\nData de nascimento: " +DataNascimento);
  }
  
  
  public void ClientesCadastrados()
  {
    string[] lines = File.ReadAllLines("clientescadastrados.txt");

      foreach(var line in lines) Console.WriteLine(line);
  }

  public void EfetuarCadastro()
  {
    Console.WriteLine("Cadastro efetuado com sucesso!");
  }
  
  
}