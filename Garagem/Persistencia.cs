using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    internal class Persistencia
    {
       
        public static void GravarArquivoEntrada(Garagem garagem)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosEntrada.txt", true);

                escritor.WriteLine(garagem.Placa.ToUpper() + ";" + garagem.DataEntrada + ";" + garagem.HoraEntrada);
                escritor.Flush();
                escritor.Close();
                MessageBox.Show("Cadastro concluído com sucesso!", "Obrigada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                Console.WriteLine("Arquivo de veículos com problemas" + error.Message);
            }

        }

             
        public static void GravarArquivoSaida(Garagem garagem)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.txt", true);

                escritor.WriteLine(garagem.Placa.ToUpper() +
                    ";" + garagem.HoraSaida + ";" + garagem.TempoPermanecia + ";" + garagem.ValorCobrado);
                escritor.Flush();
                escritor.Close();
                MessageBox.Show("O Tempo de permanência foi: " + garagem.TempoPermanecia +
                    " minutos." + "\nValor de cobrança: R$" + garagem.ValorCobrado + ",00.", "Obrigada!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                Console.WriteLine("Arquivo de veículos com problemas" + error.Message);
            }
        }

       
        internal static void GravarArquivoEntrada(List<Garagem> listaEntrada)
        {
            string linha;
            string dataEntrada;
            string horaEntrada;
            try
            {
                StreamReader leitor = new StreamReader("veiculosEntrada.txt");
                do
                {
                    linha = leitor.ReadLine();

                    dataEntrada = leitor.ReadLine();
                    horaEntrada = leitor.ReadLine();
                    new List<Garagem>().Add(new Garagem(linha, dataEntrada, horaEntrada));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception) { 

            }
            

        }


        internal static void GravarArquivoSaida(List<Garagem> listaSaida)
        {
            StreamReader leitor = new StreamReader("veiculosSaida.txt");
            string linha;
            string horaSaida;
            int TempoPermanecia;
            double ValorCobrado;
            try
            {
                StreamReader streamReader = new StreamReader("veiculosSaida.txt");
                do
                {
                    linha = leitor.ReadLine();
                    horaSaida = leitor.ReadLine();
                    TempoPermanecia = leitor.ReadLine();
                    ValorCobrado = leitor.ReadLine();
                    new List<Garagem>().Add(new Garagem(linha, horaSaida, TempoPermanecia, ValorCobrado);

                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {

            }

                  }





       /* public static List<Garagem> LerArquivoSaida()
        {
            List<Garagem> listaGaragem = new List<Garagem>();
            string linha;
            string[] dataHora;
            try
            {
                StreamReader leitor = new StreamReader("veiculosSaida.txt");
                do
                {
                    linha = leitor.ReadLine();
                    dataHora = linha.Split(';');
                    listaGaragem.Add(new Garagem(dataHora[0], dataHora[1], dataHora[2], dataHora[3],
                        dataHora[4], int.Parse(dataHora[5]), double.Parse(dataHora[6])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {

            }
            return listaGaragem;
        }
       */

        public static void limparArquivoVeiculosEntrada()
        {
            string nomeArquivo = "veiculosEntrada.txt";

            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo);
                escritor.WriteLine("");
                escritor.Flush();
                escritor.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
            }

        }

        
        
    }
}
