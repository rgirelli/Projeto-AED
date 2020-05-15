using System;
using System.IO;
class MainClass {
  public static void Main (string[] args) {
      string opcao;
      Cliente c = new Cliente();
      Cardapio cardapio = new Cardapio();
      Produto p = new Produto();
      Pedido pedido = new Pedido();
      
      //Inicialização
      Console.WriteLine(">> Bem vindo ao seu assistente pessoal de confeitaria.\n");
      Console.WriteLine(">> Selecione a opção desejada para prosseguir: ");
      Console.WriteLine();
      Console.WriteLine("1- Exibir cardápio\n2- Exibir clientes cadastrados\n3- Cadastrar cliente\n4- Consultar preço\n5- Registrar pedido\n6- Entrega\n7- Exibir estoque\n8- Compras (reposição de estoque)");
      opcao = Console.ReadLine();

      if (opcao == "1")
      {
        cardapio.ExibirCardapio();        
      } 
      if (opcao == "2")
      {
        c.ClientesCadastrados();
      }
      
      if (opcao == "3")
      { 
        c.CadastrarCliente();
      }

      if (opcao == "4")
      {
        p.ConsultarPreco();
      }

      if (opcao == "5")
      {
        pedido.FazerPedido();
      }
  }
}
            

      
  
