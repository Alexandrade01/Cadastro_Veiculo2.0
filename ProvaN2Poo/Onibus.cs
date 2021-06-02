using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Onibus:Veiculo, ILimpador,IPedagio
    {

        #region Propriedades
        public int QtdEixos { get; set; }
        public bool Leito { get; set; }
        #endregion
        #region Construtores
        public Onibus(string indentificacao, Modelo modelo, int capacidadepassageiros, int eixos, bool leito)
            : base(indentificacao, modelo, capacidadepassageiros)
        {
            Leito = leito;
            QtdEixos = eixos;
        }
        #endregion

        #region Metodos
        public void LigaDesligaLimpador()
        {
            DisparaEvento($"Ligando e desligando o limpador do onibus '{Indentificacao}'");
        }

        public double PagarPedagio()
        {
            DisparaEvento($"Pedagio pago do ônibus '{Indentificacao}' no valor de R${ 8.50 * QtdEixos}");
            return 8.50 * QtdEixos;
        }

        public override string ToString()
        {
            return base.ToString() + "Quantidade de eixos :"+QtdEixos + Environment.NewLine + " Leitos :" +(Leito?"SIM":"NÃO")
                 + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }
}
