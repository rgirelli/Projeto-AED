//Para uso de Console 
using System;
// Manipulação de Arquivos
using System.IO;
class MainClass {
  public static void Main (string[] args) {
      string opcao;
      // Instanciando objetos 
      Cliente c = new Cliente();
      Cardapio cardapio = new Cardapio();
      Produto p = new Produto();
      Pedido pedido = new Pedido();
      Entrega entrega = new Entrega();
      Estoque estoque = new Estoque();
      ClienteFisico cf = new ClienteFisico();
      ClienteJuridico cj = new ClienteJuridico();
      Recibo recibo= new Recibo();
      
      //Inicialização
      Console.WriteLine("** Bem vindo ao seu assistente pessoal de confeitaria.**\n");
      Console.WriteLine("\n>> Selecione a opção desejada para prosseguir: ");
      Console.WriteLine();
      Console.WriteLine("1- Exibir cardápio\n2- Exibir clientes cadastrados\n3- Cadastrar cliente\n4- Consultar preço\n5- Registrar pedido\n6- Entrega\n7- Exibir estoque\n");
      opcao = Console.ReadLine();

      // Menu Interativo do usuário
      if (opcao == "1")
      {
        //Chamando Método Exibir  Cardápio
        cardapio.ExibirCardapio();        
      } 
      if (opcao == "2")
      {
       // Chamando Método Clientes Cadastrados
        c.ClientesCadastrados();
      }
      
      if (opcao == "3")
      { 
       // Chamando Método Cadastrar Cliente
       Console.WriteLine("\n>> Selecione 1 para Cliente Físico ou 2 para Cliente Jurídico: ");
       opcao = Console.ReadLine();
        if (opcao == "1"){
          cf.CadastrarFisico();
       }
        if (opcao == "2"){
          cj.CadastrarJuridico();
        }
       
      }
      if (opcao == "4")
      {
        //Chamando Método Consultar Preço
        p.ConsultarPreco();
      }

      if (opcao == "5")
      {
        //Chamando Método Fazer Pedido 
        recibo.CriarRecibo();
        pedido.FazerPedido();
        recibo.ImprimirDados();        

      }
      // condicional para executar classe para calcular combustivel
      if (opcao == "6")
      {
        entrega.CalcularCombustivel();
      }
      // condicional para exibir estoque
      if (opcao == "7")
      {
        estoque.ExibirEstoque();
      }
  }
}
            

      
  
