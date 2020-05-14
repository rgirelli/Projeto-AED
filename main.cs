using System;
using System.IO;
class MainClass {
  public static void Main (string[] args) {
     
      Cliente c = new Cliente();
      string opcao;
      //Inicialização
      Console.WriteLine(">> Bem vindo ao seu assistente pessoal de confeitaria.\n");
      //Exibição de cardápio
      Console.WriteLine("Deseja visualizar o cardápio?");
      opcao = Console.ReadLine();
      if (opcao == "s") {
        string[] lines = File.ReadAllLines("Cardapio.txt");

        foreach(var line in lines ) Console.WriteLine(line);
    }
     

      //Etapa de cadastro de cliente
      Console.WriteLine("\n>> Deseja cadastrar um novo cliente? (s/n)");
      opcao = Console.ReadLine();

      if (opcao == "s")
      {

        Console.WriteLine("**CADASTRO DO CLIENTE**");
        Console.Write("Nome: ");
        c.Nome = Console.ReadLine();
        Console.Write("Endereço: ");
        c.Endereco = Console.ReadLine();
        Console.Write("Telefone: ");
        c.Telefone = Console.ReadLine();
        Console.Write("E-mail: ");
        c.Email = Console.ReadLine();
        Console.Write("Data de nascimento: ");
        c.DataNascimento = Console.ReadLine();
        File.WriteAllText("cadastro.txt", "**CADASTRO DO CLIENTE**\nNome: " +c.Nome + "\nEndereco: " +c.Endereco + "\nTelefone: "+c.Telefone +"\nE-mail: " +c.Email + "\nData de nascimento: " +c.DataNascimento);
        
      }

      else
      {
        Console.WriteLine("Deseja exibir cadastros ativos? (s/n)");
        opcao = Console.ReadLine();
        if(opcao == "s"){
          string[] lines = File.ReadAllLines("clientescadastrados.txt");

          foreach(var line in lines) Console.WriteLine(line);

        }
      }
      //Consulta de preços
      Produto p = new Produto();
      Console.WriteLine("Gostaria de consultar valores? (s/n) ");
      opcao = Console.ReadLine();

      if(opcao == "s"){
        Console.WriteLine("Código do produto: 1 - Fatias\n2 - Bolos no Pote\n3 - Cone Trufado\n4 - Trufa");
        Console.WriteLine("Informe o código do produto desejado para consultar o preço: ");
        opcao = Console.ReadLine();
        if (opcao == "1"){
          Console.WriteLine(">> Fatia R$13,00 und.");
        }
        if (opcao == "2"){
          Console.WriteLine(">> Bolo no Pote R$10,00 und.");
        }
        if (opcao == "3"){
          Console.WriteLine(">> Cone Trufado R$7,00 und.");
        }
        if (opcao == "4"){
          Console.WriteLine(">> Trufa R$2,50 und.");
        }

      }
      Console.WriteLine();
      Console.WriteLine();
      //Registrar pedido
      Console.WriteLine("** PEDIDO **");
      Console.WriteLine(">> Gostaria de utilizar o último cadastro efetuado de cliente para iniciar pedido? (s/n) ");
      opcao = Console.ReadLine();
      if (opcao == "s"){
      string[] lines1 = File.ReadAllLines("cadastro.txt");

        foreach(var line in lines1 ) Console.WriteLine(line);
        Console.WriteLine(">> Informe o código do produto, quantidade desejada e o código do sabor: ");
  }     
      else{
        Console.WriteLine(">> Gostaria de utilizar os cadastros anteriores de clientes? (s/n)");
        opcao = Console.ReadLine();
        if(opcao == "s"){
          string[] lines2 = File.ReadAllLines("clientescadastrados.txt");

        foreach(var line in lines2 ) Console.WriteLine(line);
        
        Console.WriteLine(">> Informe o código do cliente desejado: ");
        opcao = Console.ReadLine();
        }
      }        
}
    
  }
            

      
  
