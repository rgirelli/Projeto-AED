using System;

class MainClass {
  public static void Main (string[] args) {
      //Cadastro de clientes e clientes cadastrados
      Cliente c1 = new Cliente();
      Cliente c2 = new Cliente();
      Cliente c3 = new Cliente();
      Cliente c4 = new Cliente();
     
      //Console.WriteLine("Cadastrar cliente: ");
      //Console.WriteLine(">> Informe o nome do cliente: ");
      //c1.nome = Console.ReadLine();
      //Console.WriteLine(">> Informe o endereço do cliente: ");
      //c1.endereco = Console.ReadLine();
      //Console.WriteLine(">> Informe o telefone: ");
      //c1.telefone = Console.ReadLine();
      //Console.WriteLine(">> Informe o e-mail: ");
      //c1.email = Console.ReadLine();
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      //c1.ImprimirDados();
      //Console.WriteLine();
      //Console.WriteLine("Cadastrar cliente: ");
      //Console.WriteLine(">> Informe o nome do cliente: ");
      //c2.nome = Console.ReadLine();
      //Console.WriteLine(">> Informe o endereço do cliente: ");
      //c2.endereco = Console.ReadLine();
      //Console.WriteLine(">> Informe o telefone: ");
      //c2.telefone = Console.ReadLine();
      //Console.WriteLine(">> Informe o e-mail: ");
      //c2.email = Console.ReadLine();
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      
      //c2.ImprimirDados();
      //Console.WriteLine();

      //Console.WriteLine(">> Clientes cadastrados: ");
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      //c1.ImprimirDados();
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      //c2.ImprimirDados();
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      //c3.nome = "Amanda Kelly";
      //c3.endereco = "Rua Sto. Antonio, n 35, Serra-ES";
      //c3.telefone = "(27) 99885-5519";
      //c3.email = "amandakelly@ucl.br";
      //c3.ImprimirDados();
      //Console.WriteLine();
      //Console.WriteLine();
      //Console.WriteLine("Dados do cliente: ");
      //c3.nome = "Diego Ferrari";
      //c3.endereco = "R. Goiás, Estância Monazídica, n 300, Serra-ES";
      //c3.telefone = "(27) 99918-0522";
      //c3.email = "diegof@ucl.br";
      //c3.ImprimirDados();
      //Console.WriteLine();

      //Produtos
     

    //string opcao;
    Produto p = new Produto();
    Produto p1 = new Produto();
    Produto p2 = new Produto();
    Produto p3 = new Produto();
    Produto p4 = new Produto();
    Console.WriteLine("Tabela de preços: ");
    p.InformarPrecos();
    Console.WriteLine();
    //Primeiro produto
    //p1.AdicionarProduto();
    //Console.WriteLine("Informações sobre o produto escolhido: ");
    //Console.WriteLine(p1.CodigoProduto);
    //Console.WriteLine(p1.QuantidadeProduto + " unidades");
    //Console.WriteLine("R$" + p1.ValorProduto.ToString("F2") + " cada");
    //p1.CalcularTotal();
    //Console.WriteLine("Total item 1: R$" + p1.CalcularTotal().ToString("F2"));
    //double valor1 = p1.CalcularTotal();
    //Console.WriteLine();
    
    
    //p2.AdicionarProduto();
    //Console.WriteLine("Informações sobre o produto escolhido: ");
    //Console.WriteLine(p2.CodigoProduto);
    //Console.WriteLine(p2.QuantidadeProduto + " unidades");
    //Console.WriteLine("R$" + p2.ValorProduto.ToString("F2") + " cada");
    //p2.CalcularTotal();
    //Console.WriteLine("Total item 2: R$" + p2.CalcularTotal().ToString("F2"));
    //double valor2 = p2.CalcularTotal();
    //Console.WriteLine();

    //p3.AdicionarProduto();
    //Console.WriteLine("Informações sobre o produto escolhido: ");
    //Console.WriteLine(p3.CodigoProduto);
    //Console.WriteLine(p3.QuantidadeProduto + " unidades");
    //Console.WriteLine("R$" + p3.ValorProduto.ToString("F2") + " cada");
    //p3.CalcularTotal();
    //Console.WriteLine("Total item32: R$" + p3.CalcularTotal().ToString("F2"));
    //double valor3 = p3.CalcularTotal();
    //Console.WriteLine();

    //p4.AdicionarProduto();
    //Console.WriteLine("Informações sobre o produto escolhido: ");
    //Console.WriteLine(p4.CodigoProduto);
    //Console.WriteLine(p4.QuantidadeProduto + " unidades");
    //Console.WriteLine("R$" + p4.ValorProduto.ToString("F2") + " cada");
    //p4.CalcularTotal();
    //Console.WriteLine("Total item 4: R$" + p4.CalcularTotal().ToString("F2"));
    //double valor4 = p4.CalcularTotal();
    //Console.WriteLine();

    //double orcamento = valor1 + valor2 + valor3 + valor4;
    //Console.WriteLine("Valor total do orçamento: R$" + orcamento.ToString("F2"));

    Entrega entrega = new Entrega();
    Console.WriteLine("Informe a distância da entrega em km: ");
    entrega.distanciaPercorrida = double.Parse(Console.ReadLine());
    Console.WriteLine("Resumo da entrega: ");
    entrega.CalcularLitrosViagem();
    Console.WriteLine("A distância a ser percorrida na entrega é: " + entrega.distanciaPercorrida + "km");
    Console.WriteLine(">> O valor da taxa de entrega considerando o valor atual do litro da gasolina a R$3.59 para essa localidade é: R$ " + entrega.CalcularLitrosViagem().ToString("F2"));
    //Console.WriteLine("O tempo estimado de entrega é: " + ********);

    



    



   

      
    
  }
    
     

      

      
  }
