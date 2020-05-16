using System;
using System.IO;

class ClienteFisico : Cliente {
  protected string dataNascimento;
  protected string cpf;


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

  

       
  

  public void Selecionar(){
    Console.WriteLine("Digite 1 para Cliente Físico ou digite 2 para Cliente Jurídico: ");
    opcao = Console.ReadLine();
    if (opcao == "1"){
        Console.WriteLine("**CADASTRO DE CLIENTE FISICO**");
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
        Console.WriteLine("CPF: ");
        Cpf = Console.ReadLine();
        File.WriteAllText("cadastro.txt", "**CADASTRO DO CLIENTE**\nNome: " +Nome + "\nEndereco: " +Endereco + "\nTelefone: "+Telefone +"\nE-mail: " +Email + "\nData de nascimento: " +DataNascimento + "\nCPF: " + Cpf);

      
    }
  }



}