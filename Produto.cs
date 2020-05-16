//Para uso do console
using System;

//Classe produto
class Produto : Estoque{
  
//atributos da classe produto
  protected string nomeProduto;
  private string codigoProduto;
  private double valorProduto;
  protected int quantidadeProduto;
  string opcao; 


//Tornando os atributos publicos para serem utilizados 
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

   public void ConsultarPreco()
   {
     Console.WriteLine("Código do produto: \n1 - Fatias\n2 - Bolos no Pote\n3 - Cone Trufado\n4 - Trufa");
     Console.WriteLine("Informe o código do produto desejado para consultar o preço: ");
        opcao = Console.ReadLine();
        //Condicional para Consultar preços por código 
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
 

  
}