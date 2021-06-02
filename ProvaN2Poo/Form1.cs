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
    public partial class Form1 : Form
    {
        List<Veiculo> Listagem = new List<Veiculo>();

        #region Metodo para Salvar usando Json
        /// <summary>
        /// Metodo que ira salvar usando o Json 
        /// </summary>
        /// <param name="obj"> Objeto do tipo veiculo a ser cadastrado</param>
        private void SaveJson(Veiculo obj)
        {// se o arquivo existir ira carregar na lista Listagem
            if (File.Exists("dados.txt"))
            {
                string conteudoanterior = File.ReadAllText("dados.txt", Encoding.UTF8);
                JsonSerializerSettings setanterior = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                Listagem = JsonConvert.DeserializeObject<List<Veiculo>>(conteudoanterior, setanterior);
            }
            // A lambda ira procurar as indentificações na lista,
            // caso a indentificação ja estiver em uso ira retornar uma mensagem avisando
            if (Listagem.Find(x => x.Indentificacao.ToUpper() == obj.Indentificacao.ToUpper()) != null)
            {
                MessageBox.Show("Identificação ja cadastrada!");
                return;
            }
            else
            {// se não existir a indentificação ira adicionar o objeto veiculo na lista e salvar no arquivo a mesma lista
                MessageBox.Show("Done !");

                Listagem.Add(obj);
                JsonSerializerSettings set = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string conteudo = JsonConvert.SerializeObject(Listagem, set);
                File.WriteAllText("dados.txt", conteudo, Encoding.UTF8);
                Limpar(this);
                MessageBox.Show($"Foi criado o veiculo {obj.Indentificacao}");
                textBox1.Text += obj.ToString();
            }


        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        public bool CapacidadePassageiros(int value, int passageiros)
        {
            if (passageiros < 2 || passageiros > value)
            {
                return true;
            }
            else return false;
        }

        #region Cadastro de veiculos padrão
        /// <summary>
        /// Cadastro padrão de carros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(6, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 6 ");
                    return;
                }
                if (Convert.ToInt32(txtPorta.Text) != 2 && Convert.ToInt32(txtPorta.Text) != 4)
                {
                    MessageBox.Show("Numero de portas é 2 ou 4 ");
                    return;
                }

                var carro = new Carro(txtIndentificacao.Text, (Modelo)CbCarro.SelectedItem, Convert.ToInt32(txtPassageiros.Text), Convert.ToInt32(txtPorta.Text));

                SaveJson(carro);





            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }



        private void BtnCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(4, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 4 ");
                    return;
                }
                var caminhao = new Caminhao(txtIndentificacao.Text,
                    (Modelo)CbCaminhao.SelectedItem, Convert.ToInt32(txtPassageiros.Text),
                    Convert.ToInt32(txtCaminhao1.Text), Convert.ToDouble(txtCaminhao2.Text), Convert.ToDouble(txtCapacidadecarre.Text));


                SaveJson(caminhao);

            }
            catch (CapacidadeExcedidaException erro)
            {
                MessageBox.Show(erro.ToString());
                return;
            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }

        private void BtnOnibus(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(200, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 200 ");
                    return;
                }
                var onibus = new Onibus(txtIndentificacao.Text,
                    (Modelo)CbOnibus.SelectedItem, Convert.ToInt32(txtPassageiros.Text), Convert.ToInt32(txtOnibuseixo.Text), CheckOnibus1.Checked);



                SaveJson(onibus);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }



        private void BtnMoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtPassageiros.Text) != 1 || Convert.ToInt32(txtPassageiros.Text) != 2)
                {
                    MessageBox.Show("Numero de passageiros é 1 ou 2 ");
                    return;
                }
                var moto = new Moto(txtIndentificacao.Text,
                    (Modelo)CbMoto.SelectedItem, Convert.ToInt32(txtPassageiros.Text));


                SaveJson(moto);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }
        private void BtnAviao_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(200, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 200 ");
                    return;
                }
                var aviao = new Aviao(txtIndentificacao.Text,
                    (Modelo)CbAviao.SelectedItem, Convert.ToInt32(txtPassageiros.Text));



                SaveJson(aviao);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }

        private void BtnAviaodeguerra_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(200, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 200 ");
                    return;
                }
                var aviaoguerra = new Aviao(txtIndentificacao.Text,
                    (Modelo)CbAviaoGuerra.SelectedItem, Convert.ToInt32(txtPassageiros.Text));



                SaveJson(aviaoguerra);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }

        private void BtnTrem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(1500, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 1500 ");
                    return;
                }
                var trem = new Trem(txtIndentificacao.Text,
                    (Modelo)CbAviao.SelectedItem, Convert.ToInt32(txtPassageiros.Text), Convert.ToInt32(txtVagoes.Text));

                SaveJson(trem);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }


        private void BtnNavio_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(2000, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 2000 ");
                    return;
                }
                var navio = new Navio(txtIndentificacao.Text,
                    (Modelo)CbNavio.SelectedItem, Convert.ToInt32(txtPassageiros.Text));


                SaveJson(navio);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }

        private void BtnNavioGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                if (CapacidadePassageiros(2000, Convert.ToInt32(txtPassageiros.Text)))
                {
                    MessageBox.Show("Numero de passageiros é de 2 a 2000 ");
                    return;
                }
                var navioguerra = new NaviodeGuerra(txtIndentificacao.Text, (Modelo)CbNavioGuerra.SelectedItem, Convert.ToInt32(txtPassageiros.Text));


                SaveJson(navioguerra);

            }
            catch
            {
                MessageBox.Show("Dados invalidos, por favor corrigir !");
                return;
            }
        }

        #endregion

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisas novatela = new Pesquisas();
            Enabled = false;
            novatela.ShowDialog();
            Enabled = true;
        }

        private void txtCaminhao2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Gerador de ComboBox para cada tipo de veiculo 
            CbCarro.DataSource = ListagemGeral.PegarLista("CARRO"); CbCarro.DisplayMember = "Descricao";
            CbAviao.DataSource = ListagemGeral.PegarLista("AVIAO"); CbAviao.DisplayMember = "Descricao";
            CbAviaoGuerra.DataSource = ListagemGeral.PegarLista("AVIAOGUERRA"); CbAviaoGuerra.DisplayMember = "Descricao";
            CbCaminhao.DataSource = ListagemGeral.PegarLista("CAMINHAO"); CbCaminhao.DisplayMember = "Descricao";
            CbMoto.DataSource = ListagemGeral.PegarLista("MOTO"); CbMoto.DisplayMember = "Descricao";
            CbNavio.DataSource = ListagemGeral.PegarLista("NAVIO"); CbNavio.DisplayMember = "Descricao";
            CbNavioGuerra.DataSource = ListagemGeral.PegarLista("NAVIOGUERRA"); CbNavioGuerra.DisplayMember = "Descricao";
            CbOnibus.DataSource = ListagemGeral.PegarLista("ONIBUS"); CbOnibus.DisplayMember = "Descricao";
            CbTrem.DataSource = ListagemGeral.PegarLista("TREM"); CbTrem.DisplayMember = "Descricao";
            #endregion
        }


        #region Ferramenta de Limpeza usando o control
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
        #endregion


        #region Cadastros Automaticos
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var carro = new Carro($"Carro {rnd.Next(0, 999)}", (Modelo)CbCarro.SelectedItem, 5, 4);

            SaveJson(carro);
        }

        private void Caminhão_Click(object sender, EventArgs e)
        {

        }

        private void BtnAutCam_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var caminhao = new Caminhao($"Caminhao {rnd.Next(0, 999)}", (Modelo)CbOnibus.SelectedItem, 3, 3, 16000, 5000);

            SaveJson(caminhao);
        }

        private void BtnAutOni_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var onibus = new Onibus($"Onibus {rnd.Next(0, 999)}", (Modelo)CbOnibus.SelectedItem, 120, 4, true);

            SaveJson(onibus);
        }

        private void BtnAutMot_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var moto = new Moto($"Moto {rnd.Next(0, 999)}", (Modelo)CbMoto.SelectedItem, 2);

            SaveJson(moto);
        }

        private void BtnAutAv_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var aviao = new Aviao($"Aviao {rnd.Next(0, 999)}", (Modelo)CbAviao.SelectedItem, 150);

            SaveJson(aviao);
        }

        private void BtnAutAVG_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var aviaoguerra = new AviaodeGuerra($"Aviao de guerra {rnd.Next(0, 999)}", (Modelo)CbAviaoGuerra.SelectedItem, 8);

            SaveJson(aviaoguerra);
        }

        private void BtnAutTre_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var trem = new Trem($"Trem {rnd.Next(0, 999)}", (Modelo)CbTrem.SelectedItem, 850, 8);

            SaveJson(trem);
        }

        private void BtnAutNav_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var navio = new Navio($"Navio {rnd.Next(0, 999)}", (Modelo)CbNavio.SelectedItem, 800);

            SaveJson(navio);
        }

        private void BtnAutNVG_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var navioguerra = new NaviodeGuerra($"Navio de guerra {rnd.Next(0, 999)}", (Modelo)CbNavioGuerra.SelectedItem, 1800);

            SaveJson(navioguerra);
        }
        #endregion

        private void BtnPedagio_Click(object sender, EventArgs e)
        {
            TelaPedagio novatela = new TelaPedagio();
            Enabled = false;
            novatela.ShowDialog();
            Enabled = true;
        }

        private void BtnNomes_Click(object sender, EventArgs e)
        {
            Nomes novatela = new Nomes();
            Enabled = false;
            novatela.ShowDialog();
            Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Apagar todos os arquivos ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result.ToString() == "Yes")
            {
                File.Delete("dados.txt");
                File.Delete("pedagios.txt");

                MessageBox.Show("Deletado!");
            }

        }
    }
}



















