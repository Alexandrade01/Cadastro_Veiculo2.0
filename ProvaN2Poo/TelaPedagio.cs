using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace ProvaN2Poo
{
    public partial class TelaPedagio : Form
    {
        List<Veiculo> ListaPesquisa = new List<Veiculo>();
        Veiculo itempesquisado;
        List<Pedagio> HistoricoPedagios = new List<Pedagio>();

        /// <summary>
        /// Salvar objetos da classe pedagio na lista HistoricoPedagios
        /// </summary>
        /// <param name="obj"></param>
        private void SaveJson(Pedagio obj)
        {
            if (File.Exists("pedagios.txt"))
            {
                string conteudoanterior = File.ReadAllText("pedagios.txt", Encoding.UTF8);
                JsonSerializerSettings setanterior = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                HistoricoPedagios = JsonConvert.DeserializeObject<List<Pedagio>>(conteudoanterior, setanterior);




                HistoricoPedagios.Add(obj);
                JsonSerializerSettings set = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string conteudo = JsonConvert.SerializeObject(HistoricoPedagios, set);
                File.WriteAllText("pedagios.txt", conteudo, Encoding.UTF8);
                Limpar(this);
            }
            else
            {
                textBox1.Text += obj.ToString();
                HistoricoPedagios.Add(obj);
                JsonSerializerSettings set = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string conteudo = JsonConvert.SerializeObject(HistoricoPedagios, set);
                File.WriteAllText("pedagios.txt", conteudo, Encoding.UTF8);
                Limpar(this);
            }
        }
        /// <summary>
        /// Limpador de tela 
        /// </summary>
        /// <param name="clean"></param>
        private void Limpar(Control clean)
        {

            if (clean is TextBoxBase)
            {
                (clean as TextBoxBase).Clear();
            }
            foreach (Control control in clean.Controls)
            {
                Limpar(control);
            }


        }
        /// <summary>
        /// Acumuldor dos historicos de pedagio para ser adicionado no proximo cadastro
        /// </summary>
        /// <returns></returns>
        public double Acumulado()
        {
            double acumulado = 0;
            foreach (var dados in HistoricoPedagios)
            {
                acumulado += dados.ValorRecebido;
            }

            return acumulado;
        }




        public TelaPedagio()
        {
            
            if (File.Exists("dados.txt"))
            {
                string conteudo = File.ReadAllText("dados.txt", Encoding.UTF8);
                JsonSerializerSettings set = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                ListaPesquisa = JsonConvert.DeserializeObject<List<Veiculo>>(conteudo, set);
            }
            if (File.Exists("pedagios.txt"))
            {
                string conteudoanterior = File.ReadAllText("pedagios.txt", Encoding.UTF8);
                JsonSerializerSettings setanterior = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                HistoricoPedagios = JsonConvert.DeserializeObject<List<Pedagio>>(conteudoanterior, setanterior);
            }
            InitializeComponent();


        }
        private void CarregarEvento(object sender, EventoMsg e)
        {
            MessageBox.Show(e.FraseCarregado);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            itempesquisado = ListaPesquisa.Find(pesquisa => pesquisa.Indentificacao.ToUpper() == txtIndentificacao.Text.ToUpper());
            if (itempesquisado != null)
                MessageBox.Show("Achou !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Não Encontrado!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BtnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (itempesquisado is IPedagio)
                {
                    itempesquisado.MensagemCarregada += CarregarEvento;
                    double valor = (itempesquisado as IPedagio).PagarPedagio();
                    itempesquisado.MensagemCarregada -= CarregarEvento;
                    double acumulado = 0;
                    acumulado = Acumulado();
                    var dado = new Pedagio(itempesquisado.Indentificacao, (string)cbCidades.SelectedItem, valor, acumulado);
                    SaveJson(dado);
                }
            }
            catch
            {
                MessageBox.Show("Dados Invalidos!");
            }

        }



        private void BtnTotal_Click(object sender, EventArgs e)
        {
            double valortotal = 0;
            foreach (var dadospedagios in HistoricoPedagios)
            {
                valortotal += dadospedagios.ValorRecebido;
            }

            textBox1.Clear();
            textBox1.Text = $"O valor total recebido de pedagios são R${valortotal.ToString("0.00",CultureInfo.InvariantCulture)}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (var dados in HistoricoPedagios)
            {
                textBox1.Text += dados.ToString();
            }
        }

        private void BtnPagarTodos_Click(object sender, EventArgs e)
        {
            foreach(var itempesquisado in ListaPesquisa)
            {
                if (itempesquisado is IPedagio)
                {
                    itempesquisado.MensagemCarregada += CarregarEvento;
                    double valor = (itempesquisado as IPedagio).PagarPedagio();
                    itempesquisado.MensagemCarregada -= CarregarEvento;
                    double acumulado = 0;
                    acumulado = Acumulado();
                    var dado = new Pedagio(itempesquisado.Indentificacao,"Brasil", valor, acumulado);
                    SaveJson(dado);
                }
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form1 aux = new Form1();
            
        }
    }
}
