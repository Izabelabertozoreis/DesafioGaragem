using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    internal class Garagem
    {

        string placa; // -> 7 caracteres -> verificar jaNaGaragem
        string dataEntrada;
        string horaEntrada;
        string dataSaida;
        string horaSaida;
        int tempoPermanecia; //minutos
        double valorCobrado;
        private TextBox textBox_placa;
        private string[] vetorDados;
        private object tempoPermanecia1;
        private object valorCobrado1;

        public Garagem(string placa, string dataEntrada, string horaEntrada, string dataSaida, string horaSaida, int tempoPermanecia, double valorCobrado)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanecia = tempoPermanecia;
            this.valorCobrado = valorCobrado;
        }


        public Garagem(string placa, string dataEntrada, string horaEntrada)
        {
            this.placa = placa;
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;



        }

        public Garagem(TextBox textBox_placa)
        {
            this.textBox_placa = textBox_placa;
        }

        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanecia { get => tempoPermanecia; set => tempoPermanecia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }


        public void gerarDataHora(string tipo)
        {
            DateTime dateTime = DateTime.Now;
            string[] vetorDados = dateTime.ToString().Split(' ');
            switch (tipo)
            {
                case "dataEntrada":
                    this.DataEntrada = vetorDados[0];
                    break;
                case "horaEntrada":
                    this.HoraEntrada = vetorDados[1];
                    break;
                case "dataSaida":
                    this.DataSaida = vetorDados[0];
                    break;
                case "horaSaida":
                    this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// metodo que calcula o tempo de permanencia (em minutos) e calcula o valor de cobranca 
        /// </summary>
        /// <param name="valorHora">valor de referencia da hora</param>

            public void gerarCobranca(double valorHora)
        {
            string[] vetorDados = horaEntrada.Split(':');
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;


            vetorDados = HoraSaida.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = int.Parse(vetorDados[0]) * 60 + minutos;

            this.TempoPermanecia = saida - entrada;
            double tempo = (double)this.TempoPermanecia / 60;
            double qtdHorasNaGaragem = Math.Ceiling(tempo);

            this.valorCobrado = (int)qtdHorasNaGaragem * valorHora;

        }

        public static int localizado(string placa, List<Garagem> lista)
        {
            foreach (Garagem i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }

        public Garagem(string placa, int tempoPermanecia, double valorCobrado)
        {
            this.Placa = placa;
            this.TempoPermanecia = tempoPermanecia;
            this.ValorCobrado = valorCobrado;
        }


        public Garagem(string placa, string dataEntrada, string horaEntrada, string dataSaida, string horaSaida, int tempoPermanecia, double valorCobrado, TextBox textBox_placa, string[] vetorDados)
        {
            this.textBox_placa = textBox_placa;
            this.vetorDados = vetorDados;
            this.Placa = placa;
            this.DataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;
            this.DataSaida = dataSaida;
            this.HoraSaida = horaSaida;
            this.TempoPermanecia = tempoPermanecia;
            this.ValorCobrado = valorCobrado;
        }

        public Garagem(string placa, string horaSaida, int tempoPermanecia, double valorCobrado) 
        {
            this.Placa = placa;
            this.HoraSaida = horaSaida;
            this.TempoPermanecia = tempoPermanecia;
            this.ValorCobrado = valorCobrado;
        }
    }
}
