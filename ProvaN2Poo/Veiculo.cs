using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    public abstract class Veiculo
    {
        #region Atributos privados
        int velocidade = 0;
        int capacidadePassageiros = 0;
        #endregion

        #region Eventos
        public event EventHandler<EventoMsg> MensagemCarregada;
        #endregion

        #region Propriedades
        public string Indentificacao { get; set; }
        public Modelo Modelo { get; set; }
        public int CapacidadePassageiros { get => capacidadePassageiros; }

        #endregion

        #region Construtores
        public Veiculo(string indentificacao, Modelo modelo, int capacidadepassageiros)
        {
            Modelo = new Modelo(modelo.TipoVeiculo, modelo.Marca.Codigo, modelo.Marca.Descricao, modelo.NomeMarca, modelo.Codigo, modelo.Descricao);
            Indentificacao = indentificacao;
            capacidadePassageiros = capacidadepassageiros;


        }
        #endregion

        #region Metodos
        public virtual void Acelera()
        {
            velocidade++;
            DisparaEvento($"O veiculo '{Indentificacao}' esta acelerando...");
        }
        public void Desacelera()
        {
            velocidade--;
            DisparaEvento($"O veiculo '{Indentificacao}' esta desacelerando...");
        }
        public void VelocidadeAtual()
        {
            DisparaEvento($"O veiculo '{Indentificacao}' tem velocidade atual de {velocidade}KM/h ");
        }

      


        protected void DisparaEvento(string frase)
        {
            if (MensagemCarregada != null)
                MensagemCarregada(this, new EventoMsg(frase));
        }
        public override string ToString()
        {
            return "Indentificação: " + Indentificacao + Environment.NewLine
                +"Marca: " + Modelo.Marca.Descricao + " --- " + "Código: " + Modelo.Marca.Codigo + Environment.NewLine
                 + Modelo.NomeMarca + " --- " + "Código: " + Modelo.Codigo + " --- " +"Modelo: "+ Modelo.Descricao + Environment.NewLine
                + "Capacidade de passageiros: " + CapacidadePassageiros + Environment.NewLine
                + "Velocidade atual: " + velocidade +"Km/h"+ Environment.NewLine;
        }
        #endregion
    }




       





}
