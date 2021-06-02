using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Pedagio
    {
        #region Atributos privados
        string indentificacao;
        string localizacao;
        double totalPedagioRecebido;
        double valorRecebido;
        #endregion

        #region Eventos
        public event EventHandler<EventoMsg> MensagemCarregada;
        #endregion

        #region Propriedades
        public double ValorRecebido { get => valorRecebido; }
        public string Indentificacao { get => indentificacao; }
        public string Localizacao { get => localizacao;}
        public double TotalPedagioRecebido { get => totalPedagioRecebido;}
        #endregion

        #region Construtores
        public Pedagio(string indentificacao, string localizacao, double valorRecebido, double totalpedagiorecebido)
        {
            this.indentificacao = indentificacao;
            this.localizacao = localizacao;
            this.valorRecebido = valorRecebido;
            this.totalPedagioRecebido = totalpedagiorecebido;
        }
        #endregion

        #region Metodos
        public void Receber(double valor)
        {
            valorRecebido = valor;
        }

      
        public override string ToString() => "Indenficação: " + Indentificacao +Environment.NewLine + "---" + "Localização: " + Localizacao
            + Environment.NewLine + "---" + "Valor Recebido R$" + ValorRecebido.ToString("0.00") + "---"+Environment.NewLine +"Total pedagio recebido anteriormente R$" + TotalPedagioRecebido.ToString("0.00")
            +Environment.NewLine+Environment.NewLine;
        #endregion
    }
}
