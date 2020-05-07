class Entrega{
  public double taxaEntrega;
  public double tempoEstimado;
  //distancia a ser percorrida em km
  public double distanciaPercorrida;
  public double precoGasolina;
  //public double valorGasolina = 3.59;
  
  public double consumoMoto = 14.0;
  //metodo para calcular gastos mensais com gasolina
  //metodo p calcular entrega (valor) atraves da KM e preco da gasolina
  //considerando que a moto faz 14km/litro
  

  public double TaxaEntrega{
    get{
      return taxaEntrega;
    }
    set{
      taxaEntrega = value;
    }
  }

  public double TempoEstimado{
    get{
      return tempoEstimado;
    }
    set{
      tempoEstimado = value;
    }
  }

  public double DistanciaPercorrida{
    get{
      return distanciaPercorrida;
    }
    set{
      distanciaPercorrida = value;
    }
  }
  
  public double PrecoGasolina{
    get{
      return precoGasolina;
    }
    set{
      precoGasolina = value;
    }
  }

  //public double ValorGasolina{
    //get{
      //return valorGasolina;
   // }
    //set{
     // valorGasolina = value;
   // }
  //}

  public double CalcularLitrosViagem(){
    return (distanciaPercorrida/consumoMoto)*3.59;
   
  }

  //public double CalcularTempo(){
    //cálculo de tempo estimado
  //}
}