//Essa classe serve como um registro de compra de matéria prima, permitindo que o usuário registre itens, quantidades e valores unitários. Visa auxiliar o controle financeiro e servir de comparativo para as outras compras de material.
//Classe compra herda métodos e atributos da classe Estoque
using System;
using System.IO;
class Compra{

  private double precoUnitario;
  
  public double PrecoUnitario{
    get{
      return precoUnitario;
    }
    set{
      precoUnitario = value;
    }
  }

}