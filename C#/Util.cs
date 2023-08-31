
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace desafio
{
    internal class Util
    {
        public static void menu(List<int> lista)
        {
            Console.WriteLine("1 - Gerar numeros aleatorios");
            Console.WriteLine("2 - Carregar numeros de arquivo");
            Console.WriteLine("Opcao");
            string opcao = Console.ReadLine();
            if (opcao == "1")
            {
                Console.WriteLine("Quantidade de numeros: ");
                int qtd = Int32.Parse(Console.ReadLine());
                Util.popular_lista(lista, qtd);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();
                popular_lista_arquivo(nomeArquivo, lista);
            }
        }

        public static void popular_lista_arquivo(string nomeArquivo, List<int> lista)
        {
            StreamReader leitor;
            string linha;
            string[] vetorLinha;

            //abrir o arquivo
            try
            {
                leitor = new StreamReader(nomeArquivo); //abre o arquivo para leitura
                do
                {
                    linha = leitor.ReadLine();
                    lista.Add(Int32.Parse(linha));
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Arquivo inexistente ou problema de leitura.. Digite novamente\n");
                popular_lista_arquivo(nomeArquivo, lista);
            }
        }

        public static void popular_lista(List<int> lista, int n)
        {
            Console.WriteLine("Entrou");
            Random numAleatorio = new Random();
            int i = 0;
            while (i < n)
            {
                lista.Add(numAleatorio.Next(0, 1000));
                i = i + 1;
            }
        }

        public static void exibir_lista(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }

        public static void ordenar(List<int> lista)
        {
            List<int> listaBolha = new List<int>(lista);
            List<int> listaSelecao = new List<int>(lista);
            List<int> listaInsersao = new List<int>(lista);
            List<int> listaPente = new List<int>(lista);



            var sw = new Stopwatch();
            sw.Start();
            lista.Sort();
            sw.Stop();
            Console.WriteLine("Tempo de processamento do sort do C#: " + sw.ElapsedMilliseconds);
            sw.Restart();


            //sw.Start();
            //Ordenacao.bolha(listaBolha);
            //sw.Stop();
            //Console.WriteLine("Tempo de processamento do bolha: " + sw.ElapsedMilliseconds);
            //sw.Restart();

            //sw.Start();
            //Ordenacao.selecao(listaSelecao);
            //sw.Stop();
            //Console.WriteLine("Tempo de processamento do selecao: " + sw.ElapsedMilliseconds);
            //sw.Restart();

            //sw.Start();
            //Ordenacao.insercao(listaInsersao);
            //sw.Stop();
            //Console.WriteLine("Tempo de processamento do insercao: " + sw.ElapsedMilliseconds);

            sw.Start();
            Ordenacao.pente(listaPente);
            sw.Stop();
            Console.WriteLine("Tempo de processamento do pente: " + sw.ElapsedMilliseconds);

            Util.exibir_lista(listaPente);
        }

    }
}
