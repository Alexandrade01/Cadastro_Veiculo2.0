using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Navio:Veiculo,IAtracar
    {

        #region Construtores
        public Navio(string indentificacao, Modelo modelo, int capacidadepassageiros) 
            : base(indentificacao, modelo, capacidadepassageiros)
        {
        }
        #endregion

        #region Metodos
        public void Atracar()
        {
            DisparaEvento($"Atracando o navio '{Indentificacao}'");
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Environment.NewLine;
        }

        #endregion
    }
}
