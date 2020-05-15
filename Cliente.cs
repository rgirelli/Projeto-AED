//Para uso de Console 
using System;
// Manipulação de Arquivos
using System.IO;
//Classe Cliente 
class Cliente{
  // Atributos da classe cliente
  private string nome;
  private string endereco;
  private string telefone;
  private string email;
  private string dataNascimento;
  
  //Tornando os atributos publicos para serem utilizados 
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
    
    //Coleta de Dados para armazenar no arquivo txt
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
    // Percorre todas as Linhas e guarda dentro da variável
    string[] lines = File.ReadAllLines("clientescadastrados.txt");

      foreach(var line in lines) Console.WriteLine(line);
  }

  public void EfetuarCadastro()
  {
    Console.WriteLine("Cadastro efetuado com sucesso!");
  }
  
  
}