using System;
namespace Exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new FilaF();
            while (true)
            {
                Console.WriteLine("Qual das opções abaixo ");
                Console.WriteLine("0 - Adicionar número");
                Console.WriteLine("1 - Remover número");
                Console.WriteLine("2 - Imprimir lista");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite sua opção : ");
                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 3)
                    break;
                else if (menu == 0)
                {
                    Console.Write("Adicionar numero : ");
                    int novoNumero = Convert.ToInt32(Console.ReadLine());
                    if (novoNumero / 2 == 0)
                        fila.AdicionarNoInicio(novoNumero);
                    else
                        fila.AdicionarNoFinal(novoNumero);
                }
                else if (menu == 1)
                {
                    Console.Write("Remover ? [C] para o começo da lista [f] para o final da lista: ");
                    string resposta = Console.ReadLine();
                    if (resposta == "c" || resposta == "C")
                        fila.RemoverNoInicio();
                    else if (resposta == "f" || resposta == "F")
                        fila.RemoverNoFinal();
                    else
                        Console.Write("Opção inválida. ");
                }
                else if (menu == 2)
                    Imprimir(fila);
                else
                    Console.WriteLine("Somente opção válida. ");
            }
        }
        private static void Imprimir(FilaF fila)
        {
            Console.Write("Lista: ");
            fila.PercorrerInicioAoFim((x) => Console.Write($"{x} "));
            Console.WriteLine();
        }
    }
}