using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class AviaodeGuerra:Veiculo,IAtacar
    {
        #region Construtores
        public AviaodeGuerra(string indentificacao, Modelo modelo, int capacidadepassageiros) : base(indentificacao, modelo, capacidadepassageiros)
        {
        }
        #endregion
        #region Metodos
        public void Pousar()
        {
            DisparaEvento($"Pousando o avião de guerra '{Indentificacao}' .....");
        }
        public void Arremeter()
        {
            DisparaEvento($"O avião de guerra '{Indentificacao}' arremeteu...");
        }
        public void Decolar()
        {
            DisparaEvento($"O avião de guerra '{Indentificacao}' decolou...");
        }
        public void Atacar()
        {
            DisparaEvento($"O avião de guerra '{Indentificacao}' esta atacando pow!pow!...");
        }

        public void Ejetar()
        {
            DisparaEvento($"O avião de guerra '{Indentificacao}' decolou...");
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }
}
