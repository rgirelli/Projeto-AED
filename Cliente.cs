using System;
class Cliente{
  public string nome;
  public string endereco;
  public string telefone;
  public string email;

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

  public void ImprimirDados(){
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Endereço: " + endereco);
    Console.WriteLine("Telefone: " + telefone);
    Console.WriteLine("E-mail: " + email);
  }
  
}