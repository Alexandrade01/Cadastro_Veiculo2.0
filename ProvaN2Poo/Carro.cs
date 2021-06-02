using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Carro:Veiculo,ILimpador,IPedagio
    {
        #region AtributosPrivados
        int quantidadedePortas = 0;
        #endregion
        #region Propriedades
        public int QuantidadedePortas { get => quantidadedePortas;}
        #endregion

        #region Construtores
        public Carro(string indentificacao, Modelo modelo, int capacidadepassageiros,int quantidadedeportas) 
            : base(indentificacao, modelo, capacidadepassageiros)
        {
            quantidadedePortas = quantidadedeportas;
        }
        #endregion

        #region     Metodos
        public void LigaDesligaLimpador()
        {
            DisparaEvento($"Ligando e desligando o limpador do carro '{Indentificacao}'");
        }
    


        public override string ToString()
        {
            return base.ToString()
                + "Quantidade de portas " + QuantidadedePortas + Environment.NewLine + Environment.NewLine;
        }

        public double PagarPedagio()
        {
            DisparaEvento($"Pedagio pago do carro '{Indentificacao}' no valor de R$7,00");
            return 7.00;
           
        }
        #endregion
    }
}
