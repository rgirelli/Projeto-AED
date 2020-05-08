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
  
  
  public void ImprimirDados()
  {
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Endereço: " + endereco);
    Console.WriteLine("Telefone: " + telefone);
    Console.WriteLine("E-mail: " + email);
  }

  public void EfetuarCadastro()
  {
    Console.WriteLine("Cadastro efetuado com sucesso!");
  }
  
  
}