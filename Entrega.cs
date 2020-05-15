using System;
using System.IO;
class Entrega{
  /*Levar em consideração ficha técnica da Honda CG 150 
  Tanque: 15,6 litros
  Km/litro: 40km
  */
  
  private double distanciaKM;
  private double litrosGasolina;
  private double precoLitro;

  public double DistanciaKM
  {
    get{
      return distanciaKM;
    }
    set{
      distanciaKM = value;
    }
  }

  public double LitrosGasolina
  {
    get{
    return litrosGasolina;
    }
    set{
      litrosGasolina = value;
    }
  }

  public double PrecoLitro
  {
    get{
      return precoLitro;
    }
    set{
      precoLitro = value;
    }
  }



}