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
            Console.WriteLine("1 - Inserir ordenado por nome");
            Console.WriteLine("2 - Inserir no final");
            Console.WriteLine("3 - Imprimir lista");
            Console.WriteLine("4 - Buscar nome");
            Console.WriteLine("5 - Remover por nome");
            Console.WriteLine("6 - Remover do início");
            Console.WriteLine("7 - Remover do final");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcao))
            {
                opcao = -1;
            }

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    LerDadosDisciplina(out string nomeOrdenado, out string periodoOrdenado, out decimal cargaOrdenado, out string professorOrdenado);
                    lista.ordenada(nomeOrdenado, periodoOrdenado, cargaOrdenado, professorOrdenado);
                    Console.WriteLine("Disciplina inserida em ordem com sucesso!");
                    break;

                case 2:
                    LerDadosDisciplina(out string nomeFim, out string periodoFim, out decimal cargaFim, out string professorFim);
                    lista.inserirFim(nomeFim, periodoFim, cargaFim, professorFim);
                    Console.WriteLine("Disciplina inserida no final com sucesso!");
                    break;

                case 3:
                    Console.WriteLine("Elementos da lista:");
                    lista.percurso();
                    break;

                case 4:
                    Console.Write("Digite o nome da disciplina que deseja buscar: ");
                    string nomeBusca = Console.ReadLine() ?? string.Empty;

                    if (lista.buscar(nomeBusca))
                    {
                        Console.WriteLine("Nome encontrado na lista.");
                    }
                    else
                    {
                        Console.WriteLine("Nome não encontrado na lista.");
                    }
                    break;

                case 5:
                    Console.Write("Digite o nome da disciplina que deseja remover: ");
                    string nomeRemover = Console.ReadLine() ?? string.Empty;
                    lista.removerPorNome(nomeRemover);
                    break;

                case 6:
                    lista.removerinicio();
                    Console.WriteLine("Remoção do início realizada.");
                    break;

                case 7:
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

    static void LerDadosDisciplina(out string nome, out string periodo, out decimal cargaHoraria, out string professorResponsavel)
    {
        Console.Write("Nome da disciplina: ");
        nome = Console.ReadLine() ?? string.Empty;

        Console.Write("Período: ");
        periodo = Console.ReadLine() ?? string.Empty;

        Console.Write("Carga horária: ");
        cargaHoraria = decimal.TryParse(Console.ReadLine(), out decimal carga) ? carga : 0m;

        Console.Write("Professor responsável: ");
        professorResponsavel = Console.ReadLine() ?? string.Empty;
    }
}