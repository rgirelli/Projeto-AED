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
 

  
}