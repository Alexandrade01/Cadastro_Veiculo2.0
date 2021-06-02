using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class Caminhao:Veiculo, ILimpador,IPedagio
    {
        #region AtributosPrivados
        double pesoCarregado = 0;
        #endregion


        #region Propriedades
        public double PesoCarregado { get => pesoCarregado; }
        public double QtdEixos { get; set; }
        public double CapacidadeMaxima { get; set; }
        #endregion

        #region Construtores
        public Caminhao(string indentificacao, Modelo modelo, int capacidadepassageiros, int quantidadeeixos, double capacidademaxima,double capacidadecarregada) : 
            base(indentificacao, modelo, capacidadepassageiros)
        {
            QtdEixos = quantidadeeixos;
            CapacidadeMaxima = capacidademaxima;
            pesoCarregado = capacidadecarregada;
        }
        #endregion


        #region Metodos
        public void LigaDesligaLimpador()
        {
            DisparaEvento($"Ligando e desligando o limpador do caminhão '{Indentificacao}'");
        }
        public void Carregar(double peso)
        {
            pesoCarregado += peso;
            DisparaEvento($"O caminhão '{Indentificacao}' esta com {PesoCarregado}Kgs carregados");
        }
        public void Descarregar()
        {
            pesoCarregado = 0;
            DisparaEvento($"O caminhão '{Indentificacao}' foi descarregado");
        }
       

        public override void Acelera()
        {
            if (PesoCarregado > CapacidadeMaxima)
            {
                DisparaEvento($"O caminhão '{Indentificacao}' está sobrecarregado e não pode acelerar");
                
            }
            else
                base.Acelera();

        }
        public double PagarPedagio()
        {
            DisparaEvento($"Pedagio pago do caminhão '{Indentificacao}' no valor de R${ 8.50 * QtdEixos:0.00}");
            return 8.50 * QtdEixos;
        }
        public override string ToString()
        {
            return base.ToString()
                + "Peso carregado Kg"
                + PesoCarregado
                +Environment.NewLine
                + "Quantidade de eixos "
                + QtdEixos
                +Environment.NewLine
                + "Capacidade Maxima"
                + CapacidadeMaxima +" Kg"
                + Environment.NewLine
                + Environment.NewLine;

        }
        #endregion


    }
}
      






