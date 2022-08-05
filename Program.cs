using System;
using System.Collections.Generic;
using System.Linq;

namespace NBA_Draft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Time> list = PopulaLista();
            ExibirMenu(list);
        }
        public static List<Time> ExibirMenu(List<Time> lista)
        {
            string escolhaErrada;
            int saida = 0;
            while (saida == 0)
            {
                Console.WriteLine("Digite 1 para ver o NBA Draft 2022");
                Console.WriteLine("Digite 2 para sortear");
                Console.WriteLine("Digite 3 para sair");
                string escolha = Console.ReadLine();

                if (string.IsNullOrEmpty(escolha.ToString()))
                {
                    Console.WriteLine(" Opcao errada, deseja escolher novamente? Digite S para sim e N para Nao");
                    escolhaErrada = Console.ReadLine();
                    if (escolhaErrada == "S" || escolhaErrada == "s") ExibirMenu(lista);
                }

                switch (Convert.ToInt32(escolha))
                {
                    case 1:
                        MostrarLista(lista);
                        break;
                    case 2:
                        SortearLista(lista);
                        break;
                    case 3:
                        saida = 1;
                        Sair();
                        break;
                    default:
                        break;
                }

            }
            return ExibirMenu(lista);
        }
        public static void Sair()
        {
            try
            {
                Console.WriteLine(" Deseja sair? Pressione 1 para sim ou 0 para não");
                int saida = Convert.ToInt32(Console.ReadLine());
                if (saida == 1) Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static List<Time> PopulaLista()
        {
            // Criacao da lista 
            List<Time> list = new List<Time>();

            //Criando os times
            Time Pacers = new Time("Pacers", 82, 25, 57);
            Time Pinstons = new Time("Pinstons", 82, 23, 59);
            Time Magic = new Time("Magic", 82, 22, 60);
            Time Blazers = new Time("Blazers", 82, 27, 55);
            Time Thunder = new Time("Thunder", 82, 24, 58);
            Time Rockets = new Time("Rockets", 82, 20, 62);

            //Populando a lista
            list.Add(Pacers);
            list.Add(Pinstons);
            list.Add(Magic);
            list.Add(Blazers);
            list.Add(Thunder);
            list.Add(Rockets);
            return list;
        }
        public static List<Time> MostrarLista(List<Time> lista)
        {
            foreach (Time t in lista)
            {
                try
                {
                    if (t.nome.ToString() == null || t.nome.ToString() == "")
                    {
                        Console.WriteLine(t.vitorias.ToString() + " | vitorias | "
                       + t.derrotas.ToString() + " derrotas");
                    }
                    else
                    {
                        Console.WriteLine(t.nome.ToString() + " | " + t.vitorias.ToString() + " vitorias | "
                       + t.derrotas.ToString() + " derrotas");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return lista;
        }

        public static List<Time> SortearLista(List<Time> lista)
        {
            Random r = new Random();
            Console.Clear();
            for (int i = 0; i < lista.Count - 3; i++)
            {
                var listaSorteio = lista[r.Next(lista.Count)];

                Console.WriteLine(listaSorteio.nome);
            }
            Console.WriteLine();
            return ExibirMenu(lista);

        }

    }
}
