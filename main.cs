using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
      string opcao;
      Console.WriteLine("Deseja visualizar o cardápio?");
      opcao = Console.ReadLine();
      if (opcao == "s") {
        string[] lines = File.ReadAllLines("Cardapio.txt");

        foreach(var line in lines ) Console.WriteLine(line);
    }

      //Cadastro de clientes e clientes cadastrados
      /*
      Cliente c1 = new Cliente();
      Cliente c2 = new Cliente();
      Cliente c3 = new Cliente();
      Cliente c4 = new Cliente();
     
      Console.WriteLine("Cadastrar cliente: ");
      Console.WriteLine(">> Informe o nome do cliente: ");
      c1.nome = Console.ReadLine();
      Console.WriteLine(">> Informe o endereço do cliente: ");
      c1.endereco = Console.ReadLine();
      Console.WriteLine(">> Informe o telefone: ");
      c1.telefone = Console.ReadLine();
      Console.WriteLine(">> Informe o e-mail: ");
      c1.email = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      c1.ImprimirDados();
      Console.WriteLine();
      Console.WriteLine("Cadastrar cliente: ");
      Console.WriteLine(">> Informe o nome do cliente: ");
      c2.nome = Console.ReadLine();
      Console.WriteLine(">> Informe o endereço do cliente: ");
      c2.endereco = Console.ReadLine();
      Console.WriteLine(">> Informe o telefone: ");
      c2.telefone = Console.ReadLine();
      Console.WriteLine(">> Informe o e-mail: ");
      c2.email = Console.ReadLine();
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      
      c2.ImprimirDados();
      Console.WriteLine();

      Console.WriteLine(">> Clientes cadastrados: ");
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      c1.ImprimirDados();
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      c2.ImprimirDados();
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      c3.nome = "Amanda Kelly";
      c3.endereco = "Rua Sto. Antonio, n 35, Serra-ES";
      c3.telefone = "(27) 99885-5519";
      c3.email = "amandakelly@ucl.br";
      c3.ImprimirDados();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Dados do cliente: ");
      c3.nome = "Diego Ferrari";
      c3.endereco = "R. Goiás, Estância Monazídica, n 300, Serra-ES";
      c3.telefone = "(27) 99918-0522";
      c3.email = "diegof@ucl.br";
      c3.ImprimirDados();
      Console.WriteLine();

  


    



   

      
    
  }
    
     

      

      
  }
