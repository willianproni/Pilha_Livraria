using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Livraria
{
    internal class PilhaLivro
    {
        public Livro Topo { get; set; }

        public PilhaLivro()
        {
            Topo = null;
        }

        public void Puch(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
        }

        public bool vazio()
        {
            if (Topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (vazio())
            {
                Console.WriteLine("      Nenhum Livro Adicionado");
            }
            else
            {
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                    Console.ReadKey();
                } while (aux != null);
            }
        }

        public void Pop()
        {
            if (vazio())
            {
                Console.WriteLine("      Nenhum Livro Disponivel");
            }
            else
            {
                Console.WriteLine($"REMOVIDO...Livro: {Topo.Titulo} \n");
                Topo = Topo.Anterior;
            }
        }

        public void Seach()
        {
            if (vazio())
            {
                Console.WriteLine("      Nenhum Livro adicionado");
            }
            else
            {

                Console.WriteLine("1 - Nome \n2 - ISBN");
                Console.Write("Escolha: ");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string busca = Console.ReadLine().ToLower();
                    bool check = false;
                    Livro aux = Topo;
                    do
                    {
                        if (busca == aux.Titulo)
                        {
                            Console.WriteLine(aux.ToString());
                            check = true;
                        }
                        aux = aux.Anterior;
                    } while (aux != null);
                    if (check == false)
                    {
                        Console.WriteLine("O livro Buscado não foi encontrado!!");
                    }
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    int busca = int.Parse(Console.ReadLine());
                    Livro aux = Topo;
                    bool check = false;
                    do
                    {
                        if (busca == aux.ISBN)
                        {
                            Console.WriteLine(aux.ToString());
                            check = true;
                        }
                        aux = aux.Anterior;
                    } while (aux != null);
                    if (check == false)
                    {
                        Console.WriteLine("O livro Buscado não foi encontrado!!");
                    }
                }

            }

        }




    }
}
