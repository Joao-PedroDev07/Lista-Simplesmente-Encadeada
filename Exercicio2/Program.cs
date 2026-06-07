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
            Console.WriteLine("4 - Buscar Nome");
            Console.WriteLine("5 - Remover do início");
            Console.WriteLine("6 - Remover do final");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome para inserir no início: ");
                    string nomeInicio = Console.ReadLine();
                    Console.Write("Digite a idade: ");
                    int idadeInicio = int.Parse(Console.ReadLine());
                    Console.Write("Digite o telefone: ");
                    string telefoneInicio = Console.ReadLine();
                    Console.Write("Digite o salário: ");
                    decimal salarioInicio = decimal.Parse(Console.ReadLine());

                    lista.inserirInicio(nomeInicio, idadeInicio, telefoneInicio, salarioInicio);

                    Console.WriteLine("Funcionário inserido no início com sucesso!");
                    break;

                case 2:
                    Console.Write("Digite o nome para inserir no final: ");
                    string nomeFim = Console.ReadLine();
                    Console.Write("Digite a idade: ");
                    int idadeFim = int.Parse(Console.ReadLine());
                    Console.Write("Digite o telefone: ");
                    string telefoneFim = Console.ReadLine();
                    Console.Write("Digite o salário: ");
                    decimal salarioFim = decimal.Parse(Console.ReadLine());

                    lista.inserirFim(nomeFim, idadeFim, telefoneFim, salarioFim);

                    Console.WriteLine("Funcionário inserido no final com sucesso!");
                    break;

                case 3:
                    Console.WriteLine("Elementos da lista:");
                    lista.percurso();
                    break;

                case 4:
                    Console.Write("Digite o nome que deseja buscar: ");
                    string nomeBusca = Console.ReadLine();

                    if (lista.buscar(nomeBusca))
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