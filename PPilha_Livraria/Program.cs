using System;

namespace PPilha_Livraria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro livros = new PilhaLivro();
            int ops;
            int cont = 0;

            void Inserir()
            {
                Console.Write("Titulo do Livro: ");
                string titulo = Console.ReadLine().ToLower();
                Console.Write("ISBN do livro: ");
                int isbn = int.Parse(Console.ReadLine());
                Console.Write("Ano de publicação do Livro: ");
                int ano = int.Parse(Console.ReadLine());

                livros.Puch(new Livro(isbn, titulo, ano));
            }

            Console.WriteLine("-_-_-_-_-_Biblioteca-_-_-_-_-_");

            do
            {
                Console.WriteLine("\nOpções: \n1 - Adicionar Livro \n2 - Remover Livros \n3 - Imprimir Livros \n4 - Quantidade de Livros \n5 - Buscar Livro\n6 - Fechar");
                Console.Write("Escolha: ");
                ops = int.Parse(Console.ReadLine());

                switch (ops)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-_-_-_-_ Adicionando Livro -_-_-_-_\n");
                        cont++;
                        Inserir();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("-_-_-_-_ Removendo Livro -_-_-_-_\n");
                        livros.Pop();
                        if (cont == 0)
                        {

                        }
                        else
                        {
                            cont--;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("-_-_-_-_ Todos os Livros -_-_-_-_\n");
                        livros.Print();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("-_-_-_-_ Buscado Livros -_-_-_-_\n");
                        int quantida = cont;
                        Console.WriteLine($"A quantidade de livros é {quantida}");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("-_-_-_-_ Buscado Livros por: -_-_-_-_\n");
                        livros.Seach();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            } while (ops != 7);
        }
    }
}

