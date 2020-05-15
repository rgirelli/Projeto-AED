using System;
using System.IO;

class Pedido{
  
  private string codigoProduto;
  private int qtd;
  private double valorUnitario;
  string sabor;
  string continuar = "s";
  double total;

  public string CodigoProduto{
    get{
      return codigoProduto;
    }
    set{
      codigoProduto = value;
    }
  }

  public int Qtd{
    get{
      return qtd;
    }
    set{
      qtd = value;
    }
  }
  
  public double ValorUnitario{
    get{
      return valorUnitario;
    }
    set{
      valorUnitario = value;
    }
  }

  public string Sabor{
    get{
      return sabor;
    }
    set{
      sabor = value;
    }
  }

  public void FazerPedido()
  { 
    string[] lines = File.ReadAllLines("Cardapio.txt");

      foreach(var line in lines) Console.WriteLine(line);
    Console.WriteLine();
    Console.WriteLine(">> Informe o código do produto, a quantidade e o sabor desejado: ");
    CodigoProduto = Console.ReadLine();
    Qtd = int.Parse(Console.ReadLine());
    Sabor = Console.ReadLine();
    Console.WriteLine();

    if (CodigoProduto == "1")
    {
      total = 13*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Fatia\n>> Quantidade: "+Qtd+ "\n>> Sabor escolhido: " +Sabor+ "\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "2")
    {
      total = 10*Qtd; 
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Bolo no pote\n>> Quantidade: "+Qtd+ "\n>> Sabor escolhido: " +Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "3")
    {
      total = 7*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Cone Trufado\n>> Quantidade: "+Qtd+ "\n>> Sabor: "+Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "4")
    {
      total = 2.5*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Trufa\n>> Quantidade: "+Qtd+ "\n>> Sabor: "+Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }


    Console.WriteLine(">> \nDeseja inserir mais itens ao pedido? (s/n) ");
    continuar = Console.ReadLine();

    while (continuar == "s")
    {
        Console.WriteLine();
    Console.WriteLine(">> Informe o código do produto, a quantidade e o sabor desejado: ");
    CodigoProduto = Console.ReadLine();
    Qtd = int.Parse(Console.ReadLine());
    Sabor = Console.ReadLine();
    Console.WriteLine();

    if (CodigoProduto == "1")
    {
      total = 13*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Fatia\n>> Quantidade: "+Qtd+ "\n>> Sabor escolhido: " +Sabor+ "\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "2")
    {
      total = 10*Qtd; 
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Bolo no pote\n>> Quantidade: "+Qtd+ "\n>> Sabor escolhido: " +Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "3")
    {
      total = 7*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Cone Trufado\n>> Quantidade: "+Qtd+ "\n>> Sabor: "+Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }

    if (CodigoProduto == "4")
    {
      total = 2.5*Qtd;
      Console.WriteLine("DETALHES DO PEDIDO:\n>> Produto: Trufa\n>> Quantidade: "+Qtd+ "\n>> Sabor: "+Sabor+"\n>> Valor total do pedido: R$"+total.ToString("F2"));
    }


    Console.WriteLine("\n>> Deseja inserir mais itens ao pedido? (s/n) ");
    continuar = Console.ReadLine();
    }
    Console.WriteLine(">> Pedido encerrado. ");
    
  }

  


  
}