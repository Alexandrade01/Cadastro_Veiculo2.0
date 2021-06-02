using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class NaviodeGuerra:Veiculo,IAtracar,IAtacar
    {
        #region Construtores
        public NaviodeGuerra(string indentificacao, Modelo modelo, int capacidadepassageiros) 
            : base(indentificacao, modelo, capacidadepassageiros)
        {
        }
        #endregion


        #region Metodos
        public void Atracar()
        {
            DisparaEvento($"Atracando o navio de guerra '{Indentificacao}'");
        }
        public void Atacar()
        {
            DisparaEvento($"O navio de guerra '{Indentificacao}' esta atacando pow!pow!");
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }
}
