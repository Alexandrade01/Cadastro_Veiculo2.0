using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Trem : Veiculo, ILimpador
    {
        #region Propriedades
        public int QuantidadeVagoes { get; set; }
        #endregion

        #region Construtores
        public Trem(string indentificacao, Modelo modelo, int capacidadepassageiros, int vagoes) : base(indentificacao, modelo, capacidadepassageiros)
        {
            QuantidadeVagoes = vagoes;
        }
        #endregion


        #region Metodos
        public void LigaDesligaLimpador()
        {
            DisparaEvento($"Ligando e desligando o limpador do trem '{Indentificacao}'");
        }
        public override string ToString()
        {
            return base.ToString() + "Quantidade de vagas :"+QuantidadeVagoes
                 + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }

}
