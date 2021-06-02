using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    public class Marca
    {
        public Marca(int codigo, string descrição)
        {
            Codigo = codigo;
            Descricao = descrição;
        }


        public int Codigo { get; set; }
        public string Descricao { get; set; }


    }
    public class Modelo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Marca Marca { get; set; }
        public string NomeMarca { get; set; }
        public string TipoVeiculo { get; set; }

        public Modelo(string tipoveiculo, int codigomarca, string descricaomarca, string nomemarca, int codigomodelo, string descricaomodelo)
        {
            TipoVeiculo = tipoveiculo;
            Marca = new Marca(codigomarca, descricaomarca);
            NomeMarca = nomemarca;
            Codigo = codigomodelo;
            Descricao = descricaomodelo;


        }
       
        /*public override string ToString()
        {
            return $"{Marca.Codigo} -- {Marca.Descrição} -- {NomeMarca} -- {Codigo} -- {Descrição}";
        }*/
    }
}
