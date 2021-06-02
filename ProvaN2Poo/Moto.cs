using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Moto:Veiculo,IEmpinar,IPedagio
    {

        #region Construtores
        public Moto(string indentificacao, Modelo modelo, int capacidadepassageiros) 
            : base(indentificacao, modelo, capacidadepassageiros)
        {
        }
        #endregion

        #region Metodos
        public void Empinar()
        {
            DisparaEvento($"A moto '{Indentificacao}' esta sendo empinada...");
        }

        public double PagarPedagio()
        {
            DisparaEvento($"Pedagio pago da moto '{Indentificacao}' no valor de R$3,00");
            return 3.00;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + Environment.NewLine;
        }
        #endregion
    }
}
