using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ProvaN2Poo
{
    public partial class Pesquisas : Form
    {
        List<Veiculo> ListaPesquisa = new List<Veiculo>();
        Veiculo itempesquisado;
        public Pesquisas()
        {
            InitializeComponent();
            if (File.Exists("dados.txt"))
            {
                string conteudo = File.ReadAllText("dados.txt", Encoding.UTF8);
                JsonSerializerSettings set = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                ListaPesquisa = JsonConvert.DeserializeObject<List<Veiculo>>(conteudo, set);
            }
        }

        private void Pesquisas_Load(object sender, EventArgs e)
        {

        }

        #region Metodos para carregamento de Eventos
        private void CarregarEvento(object sender, EventoMsg e)
        {
            MessageBox.Show(e.FraseCarregado);
        }
        /// <summary>
        /// Ira utilizar um metodo como parametro e acionar evento
        /// </summary>
        /// <param name="metodo"></param>
        public void MensagemEvento(Action metodo)
        {
            itempesquisado.MensagemCarregada += CarregarEvento;
            metodo();
            itempesquisado.MensagemCarregada -= CarregarEvento;


        }
        #endregion

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {

            itempesquisado = ListaPesquisa.Find(pesquisa => pesquisa.Indentificacao.ToUpper() == txtIndentificacao.Text.ToUpper());
            if (itempesquisado != null)
                MessageBox.Show("Achou !","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
               MessageBox.Show("Não Encontrado!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        #region Metodos do tipo Carro
        private void BtnCarroLimpador_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Carro)
                MensagemEvento(() => (itempesquisado as Carro).LigaDesligaLimpador());

            else
            {
                MessageBox.Show("Não é um carro !");
                return;
            }



        }
        #endregion


        #region Metodos de Velocidade/Acelerar/Frear
        private void BtnAcelera_Click(object sender, EventArgs e)
        {
            MensagemEvento(() => itempesquisado.Acelera());

        }

        private void BtnDesacelera_Click(object sender, EventArgs e)
        {
            MensagemEvento(() => itempesquisado.Desacelera());
        }
        private void BtnVelocidadeAtual_Click(object sender, EventArgs e)
        {
            MensagemEvento(() => itempesquisado.VelocidadeAtual());
        }
        #endregion


        #region Metodos do tipo Caminhão
        private void BtnCaminhaoCarregar(object sender, EventArgs e)
        {
            double peso = 0;
            try
            {
                peso = Convert.ToDouble(txtCamCarregar.Text);
            }
            catch
            {
                MessageBox.Show("peso invalido!");
                return;
            }
            if (itempesquisado is Caminhao)
                MensagemEvento(() => (itempesquisado as Caminhao).Carregar((peso)));

            else
            {
                MessageBox.Show("Não é um caminhão !");
                return;
            }
        }

        private void BtnCamLimpador_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Caminhao)
                MensagemEvento(() => (itempesquisado as Caminhao).LigaDesligaLimpador());

            else
            {
                MessageBox.Show("Não é um caminhão !");
                return;
            }
        }

        private void BtnCamDescarregar_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Caminhao)
                MensagemEvento(() => (itempesquisado as Caminhao).Descarregar());

            else
            {
                MessageBox.Show("Não é um caminhão !");
                return;
            }
        }
        #endregion

        #region Metodos do tipo Onibus
        private void BtnLimpadorOni_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Onibus)
                MensagemEvento(() => (itempesquisado as Onibus).LigaDesligaLimpador());
            else
            {
                MessageBox.Show("Não é um ônibus !");
                return;
            }
        }
        #endregion

        #region Metodos do tipo Moto
        private void BtnEmpinaMoto_Click(object sender, EventArgs e)
        {

            if (itempesquisado is Moto)
                MensagemEvento(() => (itempesquisado as Moto).Empinar());
            else
            {
                MessageBox.Show("Não é uma moto !");
                return;
            }
        }
        #endregion


        #region Metodos do tipo Avião
        private void BtnAviaoPousar_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Aviao)
                MensagemEvento(() => (itempesquisado as Aviao).Pousar());
            else
            {
                MessageBox.Show("Não é um avião !");
                return;
            }
        }

        private void BtnAviaoArremete_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Aviao)
                MensagemEvento(() => (itempesquisado as Aviao).Arremeter());
            else
            {
                MessageBox.Show("Não é um avião !");
                return;
            }
        }

        private void BtnAviaoDecolar_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Aviao)
                MensagemEvento(() => (itempesquisado as Aviao).Decolar());
            else
            {
                MessageBox.Show("Não é um avião !");
                return;
            }
        }

        private void BtnAviaoLimpador_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Aviao)
                MensagemEvento(() => (itempesquisado as Aviao).LigaDesligaLimpador());
            else
            {
                MessageBox.Show("Não é um avião !");
                return;
            }
        }
        #endregion

        #region Metodos do tipo Avião de guerra
        private void BtnAviaoGuerraP_Click(object sender, EventArgs e)
        {
            if (itempesquisado is AviaodeGuerra)
                MensagemEvento(() => (itempesquisado as AviaodeGuerra).Pousar());
            else
            {
                MessageBox.Show("Não é um avião de guerra !");
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (itempesquisado is AviaodeGuerra)
                MensagemEvento(() => (itempesquisado as AviaodeGuerra).Arremeter());
            else
            {
                MessageBox.Show("Não é um avião de guerra !");
                return;
            }
        }

        private void BtnAviaoGuerraD_Click(object sender, EventArgs e)
        {
            if (itempesquisado is AviaodeGuerra)
                MensagemEvento(() => (itempesquisado as AviaodeGuerra).Decolar());
            else
            {
                MessageBox.Show("Não é um avião de guerra !");
                return;
            }
        }

        private void BtnAviaoGuerraAt_Click(object sender, EventArgs e)
        {
            if (itempesquisado is AviaodeGuerra)
                MensagemEvento(() => (itempesquisado as AviaodeGuerra).Arremeter());
            else
            {
                MessageBox.Show("Não é um avião de guerra !");
                return;
            }
        }

        private void BtnAviaoGuerraE_Click(object sender, EventArgs e)
        {
            if (itempesquisado is AviaodeGuerra)
                MensagemEvento(() => (itempesquisado as AviaodeGuerra).Ejetar());
            else
            {
                MessageBox.Show("Não é um avião de guerra !");
                return;
            }
        }
        #endregion


        #region Metodos do tipo Trem
        private void BtnLimpadorTrem_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Trem)
                MensagemEvento(() => (itempesquisado as Trem).LigaDesligaLimpador());
            else
            {
                MessageBox.Show("Não é um trem !");
                return;
            }
        }
        #endregion

        #region Metodos do tipo Navio
        private void BtnNavioAtracar_Click(object sender, EventArgs e)
        {
            if (itempesquisado is Navio)
                MensagemEvento(() => (itempesquisado as Navio).Atracar());
            else
            {
                MessageBox.Show("Não é um navio !");
                return;
            }
        }
        #endregion

        #region Metodos do tipo Navio de guerra
        private void BtnNavioGuerra_Click(object sender, EventArgs e)
        {
            if (itempesquisado is NaviodeGuerra)
                MensagemEvento(() => (itempesquisado as NaviodeGuerra).Atracar());
            else
            {
                MessageBox.Show("Não é um navio de guerra !");
                return;
            }
        }

        private void BtnNavioGuerraAta_Click(object sender, EventArgs e)
        {
            if (itempesquisado is NaviodeGuerra)
                MensagemEvento(() => (itempesquisado as NaviodeGuerra).Atacar());
            else
            {
                MessageBox.Show("Não é um navio de guerra !");
                return;
            }
        }
        #endregion


        #region Metodos do tipo Todos
        private void BtnLimpaTodos_Click(object sender, EventArgs e)
        {
            foreach (Veiculo veiculo in ListaPesquisa)
            {
                if (veiculo is ILimpador)
                {
                    veiculo.MensagemCarregada += CarregarEvento;
                    (veiculo as ILimpador).LigaDesligaLimpador();
                    veiculo.MensagemCarregada -= CarregarEvento;

                }
            }
        }

        private void BtnAtracaTodos_Click(object sender, EventArgs e)
        {
            foreach (Veiculo veiculo in ListaPesquisa)
            {
                if (veiculo is IAtracar)
                {
                    veiculo.MensagemCarregada += CarregarEvento;
                    (veiculo as IAtracar).Atracar();
                    veiculo.MensagemCarregada -= CarregarEvento;

                }
            }
        }

        private void BtnAtacarTodos_Click(object sender, EventArgs e)
        {
            foreach (Veiculo veiculo in ListaPesquisa)
            {
                if (veiculo is IAtacar)
                {
                    veiculo.MensagemCarregada += CarregarEvento;
                    (veiculo as IAtacar).Atacar();
                    veiculo.MensagemCarregada -= CarregarEvento;

                }
            }
        }

        private void BtnEmpinarTodos_Click(object sender, EventArgs e)
        {
            foreach (Veiculo veiculo in ListaPesquisa)
            {
                if (veiculo is IEmpinar)
                {
                    veiculo.MensagemCarregada += CarregarEvento;
                    (veiculo as IEmpinar).Empinar();

                    veiculo.MensagemCarregada -= CarregarEvento;

                }
            }
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var veiculopesquisa in ListaPesquisa)
            {
                textBox1.Text += veiculopesquisa.ToString();
            }
        }

        #endregion

        private void BtnListar_Click(object sender, EventArgs e)
        {
            if (itempesquisado != null)
            {
                textBox1.Clear();
                textBox1.Text += itempesquisado.ToString();
            }
            else
                MessageBox.Show("Não achou");
        }



      

      


    }
}
