using System;
class Produto{
  

  private string nomeProduto;
  private string codigoProduto;
  private double valorProduto;
  private int quantidadeProduto;
  private string opcao; 

  public string NomeProduto{
    get{
      return nomeProduto;
    }
    set{
      nomeProduto = value;
    }
  }

  public string CodigoProduto{
    get{
      return codigoProduto;
    }
    set{
      codigoProduto = value;
    }
  }

  public double ValorProduto{
    get{
      return valorProduto;
    }
  set{
    valorProduto = value;
   }
  }

  public int QuantidadeProduto{
    get{
      return quantidadeProduto;
    }
    set{
      quantidadeProduto = value;
    }
   }

  

  public void InformarPrecos(){
    Console.WriteLine("1- Bolo de Pote: R$7.00\n2- Cone Trufado: R$6.00\n3- Palha Italiana: R$2.50\n4- Trufa: R$2.00 ");
  }

  public void AdicionarProduto(){
    Console.WriteLine("Informe o código do produto desejado: ");
    codigoProduto = Console.ReadLine();
    if (codigoProduto == "1"){
      valorProduto = 7.00;
    }
    if (codigoProduto == "2"){
      valorProduto = 6.00;
    }
    if (codigoProduto == "3"){
      valorProduto = 2.50;
    }
    if (codigoProduto == "4"){
      valorProduto = 2.00;
    }
    
    Console.WriteLine("Informe a quantidade desejada do produto: ");
    quantidadeProduto = int.Parse(Console.ReadLine());



    //Console.WriteLine("Deseja acrescentar mais itens ao pedido? s/n");
    //opcao = Console.ReadLine();

    
    //while(opcao == "s"){
    //  Console.WriteLine("Informe o código do produto desejado: ");
    //  codigoProduto = Console.ReadLine();
    //  Console.WriteLine("Informe a quantidade desejada do produto: ");
    //  quantidadeProduto = int.Parse(Console.ReadLine());
    //  Console.WriteLine("Deseja acrescentar mais itens ao pedido? s/n");
    //  opcao = Console.ReadLine();
     
    //}
  if (codigoProduto == "1"){
    codigoProduto = "1 - Bolo de pote";
  }
  if (codigoProduto == "2"){
    codigoProduto = "2- Cone trufado";
  }
  if (codigoProduto == "3"){
    codigoProduto = "3 - Palha italiana";
  }
  if (codigoProduto == "4"){
    codigoProduto = "4- Trufa";
  }

  }
  
  public double CalcularTotal(){
    return quantidadeProduto*valorProduto;
  }


  
}