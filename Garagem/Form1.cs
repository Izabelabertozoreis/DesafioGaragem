using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            Persistencia.GravarArquivoEntrada(listaEntrada);
            preencherlb_Entrada();
            Persistencia.GravarArquivoSaida(listaSaida);
            preencherlb_Saida();
        
        }

        List<Garagem> listaEntrada = new List<Garagem>();
        List<Garagem> listaSaida = new List<Garagem>();

        private void preencherlb_Entrada()
        {
            lb_entrada.Items.Clear();

            foreach (var entrada in listaEntrada)
            {
                lb_entrada.Items.Add(entrada.Placa + " ; "  + entrada.DataEntrada + " ; " + entrada.HoraEntrada);
            }

        }

        private void preencherlb_Saida()
        {
            lb_saida.Items.Clear();

            foreach (var saida in listaSaida)
            {
                lb_saida.Items.Add(saida.Placa + saida.HoraSaida + saida.TempoPermanecia + saida.ValorCobrado);

            }
        }

        

            private void button_entrada_Click(object sender, EventArgs e)
        {
            DateTime dataAgora = DateTime.Now;
            string dataEntrada = dataAgora.ToShortDateString();
            string horaEntrada = dataAgora.ToShortTimeString();

            Garagem garagem = new Garagem(textBox_placa.Text, dataEntrada, horaEntrada);
            textBox_placa.Text = textBox_placa.Text;
         
            if (textBox_placa.Text.Equals(""))
            {
                MessageBox.Show("Precisa digitar um placa", "Alerta");
                return;
            }
            if (textBox_placa.Text.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa correta." );
                return;
            }

            listaEntrada.Add(garagem);
            Persistencia.GravarArquivoEntrada(garagem);
            preencherlb_Entrada();


        }

        

        private void button_limpar_Click(object sender, EventArgs e)
        {
            
            textBox_placa.Clear();
            lb_entrada.Items.Clear();


           // listView_entrada.Items.AddRange(new );

        }

        private void listView_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void button_saida_Click(object sender, EventArgs e)


        {


            DateTime dataAgora = DateTime.Now;
            string dataSaida = dataAgora.ToShortDateString();
            string horaSaida = dataAgora.ToShortTimeString();
          

            if (textBox_placa.Text.Equals(""))
            {
                MessageBox.Show("Precisa digitar um placa para Saida", "Alerta");
                return;
            }
            Garagem garagem = new Garagem(textBox_placa);

            
            var veiculo = Garagem.localizado(textBox_placa.Text, listaEntrada);
            textBox_placa.Text = "";
            Garagem.Equals(garagem, veiculo);
            garagem = listaEntrada[veiculo];
            garagem.gerarDataHora("horaSaida");


            garagem.gerarCobranca(10);
            MessageBox.Show("O Tempo de Permanencia foi: " + garagem.TempoPermanecia);
            MessageBox.Show("O valor é: " + garagem.ValorCobrado);
            

            listaEntrada.Remove(garagem);
            listaSaida.Add(garagem);
            Persistencia.GravarArquivoSaida(garagem);
            preencherlb_Saida();
            lb_saida.Items.Clear();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
