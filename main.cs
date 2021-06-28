using System;
using System.Collections.Generic;

class MainClass {

  public static void Cadastrar(){
    Console.WriteLine("\n\nCadastro de Produto");

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Preço: ");
    double preco = Convert.ToDouble(Console.ReadLine());

    Produto p = new Produto(nome, preco);
    p.Persistir();
  }

  public static void Listar()
  {
    Console.WriteLine("\n");
    List<Produto> produtos = Produto.ConsultarProdutos();

    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  }

  public static void ProcurarEspecifico()
  {
    Console.Write("\n\nEntre com a palavra chave da busca: ");
    string especificos = Console.ReadLine();

    List<Produto> produtos = Produto.ProcurarProdutos("%"+especificos+"%");

    foreach(var produto in produtos)
    {
      produto.Imprimir();
    }
  }


  public static void Menu(){
    char opcao;
    do {
      Console.WriteLine("\nOpções: [C]adastrar [L]istar [P]rocurar específico [S]air");

      opcao = Char.ToLower(Console.ReadKey().KeyChar);
      switch (opcao)
      {
        case 'c':
          Cadastrar();
          break;

        case 'l':
          Listar();
          break;

        case 'p':
          ProcurarEspecifico();
          break;

        case 's':
          break;

        default:
          Console.WriteLine("Opção Inválida!");
          break;
      } 
    } while (opcao != 's');
  }
  
  public static void Main (string[] args) {
    Console.WriteLine("\n\nSeja bem vindo ao cadastro de produtos!\n");
    Menu();
    Console.WriteLine("\n\nAté breve!");
  }
}