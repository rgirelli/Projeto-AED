using System;
using System.IO;
class Entrega{
  /*Levar em consideração ficha técnica da Honda CG 150 
  Tanque: 15,6 litros
  Km/litro: 40km
  */
  // Atributos da classe entrega
  private double distanciaKM;
  private double litrosGasolina;
  private double precoLitro;
  private double taxaEntrega;

  //tornando os atributos públicos para serem utilizados dentro da classe
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

  public double TaxaEntrega
  {
    get{
      return taxaEntrega;
    }
    set{
      taxaEntrega = value;
    }
  }

  public void CalcularCombustivel()
  {
    Console.WriteLine("\n>> GASTOS COM ENTREGA");
   
    //dividir a quilometragem pelo consumo da moto
    Console.Write("- Informe a distância da entrega (km): ");
    DistanciaKM = double.Parse(Console.ReadLine());
    LitrosGasolina = (DistanciaKM/15.6);
    Console.WriteLine();
    Console.WriteLine(">> CONSUMO EM LITROS");
    Console.WriteLine("- A quantidade de gasolina, em litros, consumida para a distância informada é: "+LitrosGasolina.ToString("F2")+" litros.\n");
    Console.WriteLine(">> TAXA DE ENTREGA");
    Console.Write("- Informe o valor, por litro, da gasolina: R$");
    PrecoLitro = double.Parse(Console.ReadLine());
    TaxaEntrega = LitrosGasolina*PrecoLitro;
    Console.WriteLine();
    Console.WriteLine(">> O valor gasto com gasolina para efetuar a entrega na distância informada é: R$"+TaxaEntrega.ToString("F2"));


    
  }



}