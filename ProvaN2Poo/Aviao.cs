using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Aviao:Veiculo, ILimpador
    {

        #region Constrututores
        public Aviao(string indentificacao, Modelo modelo, int capacidadepassageiros) : base(indentificacao, modelo, capacidadepassageiros)
        {
        }
        #endregion
        #region Metodos
        public void Pousar()
        {
            DisparaEvento($"Pousando o avião '{Indentificacao}' .....");
        }
        public void Arremeter()
        {
            DisparaEvento($"O avião '{Indentificacao}' arremeteu...");
        }
        public void Decolar()
        {
            DisparaEvento($"O avião '{Indentificacao}' decolou...");
        }
        public void LigaDesligaLimpador()
        {
            DisparaEvento($"Ligando e desligando o limpador do avião '{Indentificacao}'");
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }
}
