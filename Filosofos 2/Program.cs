using System;

class Program
{
    static void MenuFilosofo(Filosofo f)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine($"MENU DO FILÓSOFO {f.Nome}");
            Console.WriteLine("1 - Pegar Faca (α)");
            Console.WriteLine("2 - Pegar Garfo (β)");
            Console.WriteLine("0 - Voltar");

            Console.Write("\nEscolha: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            Console.Clear();
            switch (opcao)
            {
                case 1:
                    f.PegarFaca();
                    break;
                case 2:
                    f.PegarGarfo();
                    break;
                case 0:
                    Console.WriteLine("Voltando ao menu principal...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }

    static void Main()
    {
        Talheres talheres = new Talheres();
        Filosofo F1 = new Filosofo("F1", talheres);
        Filosofo F2 = new Filosofo("F2", talheres);

        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== CONTROLE DOS FILÓSOFOS ===\n");
            Console.WriteLine("1 - Filósofo F1");
            Console.WriteLine("2 - Filósofo F2");
            Console.WriteLine("0 - Sair");

            Console.Write("\nEscolha: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            switch (opcao)
            {
                case 1:
                    MenuFilosofo(F1);
                    break;
                case 2:
                    MenuFilosofo(F2);
                    break;
                case 0:
                    Console.WriteLine("Encerrando programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != 0);
    }
}