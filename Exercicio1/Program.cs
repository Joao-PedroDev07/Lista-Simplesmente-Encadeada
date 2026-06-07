using System;

class Program
{
    static void Main(string[] args)
    {
        Lista lista = new Lista();
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU - LISTA SIMPLESMENTE ENCADEADA =====");
            Console.WriteLine("1 - Inserir no início");
            Console.WriteLine("2 - Inserir no final");
            Console.WriteLine("3 - Imprimir lista");
            Console.WriteLine("4 - Buscar valor");
            Console.WriteLine("5 - Remover do início");
            Console.WriteLine("6 - Remover do final");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o valor para inserir no início: ");
                    int valorInicio = int.Parse(Console.ReadLine());

                    lista.inserirInicio(valorInicio);

                    Console.WriteLine("Valor inserido no início com sucesso!");
                    break;

                case 2:
                    Console.Write("Digite o valor para inserir no final: ");
                    int valorFim = int.Parse(Console.ReadLine());

                    lista.inserirFim(valorFim);

                    Console.WriteLine("Valor inserido no final com sucesso!");
                    break;

                case 3:
                    Console.WriteLine("Elementos da lista:");
                    lista.percurso();
                    break;

                case 4:
                    Console.Write("Digite o valor que deseja buscar: ");
                    int valorBusca = int.Parse(Console.ReadLine());

                    if (lista.buscar(valorBusca))
                    {
                        Console.WriteLine("Valor encontrado na lista.");
                    }
                    else
                    {
                        Console.WriteLine("Valor não encontrado na lista.");
                    }
                    break;

                case 5:
                    lista.removerinicio();
                    Console.WriteLine("Remoção do início realizada.");
                    break;

                case 6:
                    lista.removerfim();
                    Console.WriteLine("Remoção do final realizada.");
                    break;

                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

        } while (opcao != 0);
    }
}