using System;
using System.IO;
class MainClass {
  public static void Main (string[] args) {
      //string nome, endereco, telefone, email;
      Cliente c = new Cliente();
      string opcao;
     

      
      Console.WriteLine(">> Bem vindo ao seu assistente pessoal de confeitaria.\n>> Deseja cadastrar um novo cliente? (s/n)");
      opcao = Console.ReadLine();

      if (opcao == "s")
      {
        FileStream meuArq = new FileStream("cadastrocliente.txt", FileMode.Open, FileAccess.Read);

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
      
      
      

      
      
      
      
      
      
      
      
      
      
      /*
      //CLIENTES
      Cliente c = new Cliente();
      //c.CadastrarCliente();
          
      Console.WriteLine(" **CADASTRO DE CLIENTE** ");
      Console.Write(">> Nome: ");
      c.nome = Console.ReadLine();
      Console.WriteLine();
      Console.Write(">> Endereço: ");
      c.endereco = Console.ReadLine();
      Console.WriteLine();
      Console.Write(">> Telefone: ");
      c.telefone = Console.ReadLine();
      Console.WriteLine();
      Console.Write(">> E-mail: ");
      c.email = Console.ReadLine();
      Console.WriteLine();
      
      //Console.WriteLine(c.CadastrarCliente());
      

    
    /*PRODUTOS
    string opcao;
    Produto p = new Produto();
    Produto p1 = new Produto();
    Produto p2 = new Produto();
    Produto p3 = new Produto();
    Produto p4 = new Produto();
    Console.WriteLine("Tabela de preços: ");
    p.InformarPrecos();
    Console.WriteLine();
    //Primeiro produto
    p1.AdicionarProduto();
    Console.WriteLine("Informações sobre o produto escolhido: ");
    Console.WriteLine(p1.CodigoProduto);
    Console.WriteLine(p1.QuantidadeProduto + " unidades");
    Console.WriteLine("R$" + p1.ValorProduto.ToString("F2") + " cada");
    p1.CalcularTotal();
    Console.WriteLine("Total item 1: R$" + p1.CalcularTotal().ToString("F2"));
    double valor1 = p1.CalcularTotal();
    Console.WriteLine();
    
    
    p2.AdicionarProduto();
    Console.WriteLine("Informações sobre o produto escolhido: ");
    Console.WriteLine(p2.CodigoProduto);
    Console.WriteLine(p2.QuantidadeProduto + " unidades");
    Console.WriteLine("R$" + p2.ValorProduto.ToString("F2") + " cada");
    p2.CalcularTotal();
    Console.WriteLine("Total item 2: R$" + p2.CalcularTotal().ToString("F2"));
    double valor2 = p2.CalcularTotal();
    Console.WriteLine();

    p3.AdicionarProduto();
    Console.WriteLine("Informações sobre o produto escolhido: ");
    Console.WriteLine(p3.CodigoProduto);
    Console.WriteLine(p3.QuantidadeProduto + " unidades");
    Console.WriteLine("R$" + p3.ValorProduto.ToString("F2") + " cada");
    p3.CalcularTotal();
    Console.WriteLine("Total item32: R$" + p3.CalcularTotal().ToString("F2"));
    double valor3 = p3.CalcularTotal();
    Console.WriteLine();

    p4.AdicionarProduto();
    Console.WriteLine("Informações sobre o produto escolhido: ");
    Console.WriteLine(p4.CodigoProduto);
    Console.WriteLine(p4.QuantidadeProduto + " unidades");
    Console.WriteLine("R$" + p4.ValorProduto.ToString("F2") + " cada");
    p4.CalcularTotal();
    Console.WriteLine("Total item 4: R$" + p4.CalcularTotal().ToString("F2"));
    double valor4 = p4.CalcularTotal();
    Console.WriteLine();

    double orcamento = valor1 + valor2 + valor3 + valor4;
    Console.WriteLine("Valor total do orçamento: R$" + orcamento.ToString("F2"));

    Entrega entrega = new Entrega();
    Console.WriteLine("Informe a distância da entrega em km: ");
    entrega.distanciaPercorrida = double.Parse(Console.ReadLine());
    Console.WriteLine("Resumo da entrega: ");
    entrega.CalcularLitrosViagem();
    Console.WriteLine("A distância a ser percorrida na entrega é: " + entrega.distanciaPercorrida + "km");
    Console.WriteLine(">> O valor da taxa de entrega considerando o valor atual do litro da gasolina a R$3.59 para essa localidade é: R$ " + entrega.CalcularLitrosViagem().ToString("F2"));
    //Console.WriteLine("O tempo estimado de entrega é: " + ********);

    */



    



   

      
    
  }
    
     

      

      
  }
