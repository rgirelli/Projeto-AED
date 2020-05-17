 using System;
 using System.IO;
 class Estoque{
  //Protected faz com que os atributos sejam acessíveis apenas pela própria classe ou pelas classes herdeiras 
  protected string descricaoItem;
  protected int qtdItem;

  public string DescricaoItem{
    get{
      return descricaoItem;
    }
    set{
      descricaoItem = value;
    }
  }

  public int QtdItem{
    get{
      return qtdItem;
    }
    set{
      qtdItem = value;
    }
  }
    //comando para percorrer txt e guardar variáveis
  public void ExibirEstoque(){
    Console.WriteLine("\n**INVENTÁRIO DE MATÉRIA PRIMA**\n");
    string[] lines = File.ReadAllLines("estoque.txt");

      foreach(var line in lines) Console.WriteLine(line);
  }

  }
  

 