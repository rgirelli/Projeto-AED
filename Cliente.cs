//Para uso de Console 
using System;
// Manipulação de Arquivos
using System.IO;
//Classe Cliente 
class Cliente{
  // Atributos da classe cliente
  protected string nome;
  protected string endereco;
  protected string telefone;
  protected string email;
  
  
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

  

  
  
  public void ClientesCadastrados()
  {
    // Percorre todas as Linhas e guarda dentro da variável
    string[] lines = File.ReadAllLines("clientescadastrados.txt");

      foreach(var line in lines) Console.WriteLine(line);
  }
  // o cadastro é efetuado e guardado dentro do txt
  public void EfetuarCadastro()
  {
    Console.WriteLine("Cadastro efetuado com sucesso!");
  }

  
  
  
}