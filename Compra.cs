class Compra{
  public string descricaoItem;
  public double precoItem;
  public int qtdItem;

  //metodo para calcular valor total da Compra
  //metodo para adicionar ao estoque 

  public string DescricaoItem{
    get{
      return descricaoItem;
    }
    set{
      descricaoItem = value;
    }
  }

  public double PrecoItem{
    get{
      return precoItem;
    }
    set{
      precoItem = value;
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
}