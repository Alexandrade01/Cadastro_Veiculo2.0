using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    public class  ListagemGeral : Modelo
    {
        #region Construtores
        public ListagemGeral(string tipoveiculo, int codigomarca, string descricaomarca, string nomemarca, int codigomodelo, string descricaomodelo) 
            : base(tipoveiculo, codigomarca, descricaomarca, nomemarca, codigomodelo, descricaomodelo)
        {
        }

        #endregion
        #region Metodos

        /// <summary>
        /// Criação de listas de veiculos para serem cadastrados
        /// </summary>
        /// <returns></returns>

        public static List<Modelo> Dados()
        {
            List<Modelo> ListaGeral = new List<Modelo>();
            ListaGeral.Add(new Modelo("CARRO", 1, "VW", "CAR1", 1, "Gol"));
            ListaGeral.Add(new Modelo("CARRO", 1, "VW", "CAR1", 2, "T-Cross"));
            ListaGeral.Add(new Modelo("CARRO", 2, "Ford", "CAR2", 1, "Mustang"));
            ListaGeral.Add(new Modelo("CARRO", 3, "Toyota", "CAR3", 1, "Corolla"));
            ListaGeral.Add(new Modelo("CARRO", 4, "Fiat", "CAR4", 1, "Uno"));
            ListaGeral.Add(new Modelo("CAMINHAO", 1, "Scania", "CAM1", 1, "Scania R450"));
            ListaGeral.Add(new Modelo("CAMINHAO", 1, "Scania", "CAM1", 2, "Scania R410"));
            ListaGeral.Add(new Modelo("CAMINHAO", 2, "Mercedes-Benz", "CAM2", 1, "Mercedes Actros"));
            ListaGeral.Add(new Modelo("CAMINHAO", 1, "SCANIA", "CAM1", 3, "Scania F880"));
            ListaGeral.Add(new Modelo("ONIBUS", 1, "Mercedes-Benz", "ONI1", 1, " Mercedes O 500R"));
            ListaGeral.Add(new Modelo("ONIBUS", 1, "Mercedes-Benz", "ONI1", 2, " Mercedes OF 1721"));
            ListaGeral.Add(new Modelo("ONIBUS", 2, "Marcopolo", "ONI2", 1, " Marcopolo G7 1200"));
            ListaGeral.Add(new Modelo("MOTO", 1, "Harley Division", "MOT1", 1, "Moto Harley 188"));
            ListaGeral.Add(new Modelo("MOTO", 2, "Honda", "MOT2", 1, "CG 160 Titan"));
            ListaGeral.Add(new Modelo("MOTO", 3, "Yamaha", "MOT3", 1, "Fazer 150"));
            ListaGeral.Add(new Modelo("AVIAO", 1, "Airbus", "AVI1", 1, "Airbus A320"));
            ListaGeral.Add(new Modelo("AVIAO", 2, "Boeing", "AVI2", 1, "Boeing 737"));
            ListaGeral.Add(new Modelo("AVIAO", 3, "Embraer", "AVI3", 1, "Embraer E-Jets"));
            ListaGeral.Add(new Modelo("AVIAOGUERRA", 1, "Lockheed Martin", "AVG1", 1, "F-22 Raptor"));
            ListaGeral.Add(new Modelo("AVIAOGUERRA", 1, "Lockheed Martin", "AVG1", 2, "F-35 Lightning II"));
            ListaGeral.Add(new Modelo("AVIAOGUERRA", 2, "Saab AB", "AVG2", 1, "Saab JAS 39 Gripen"));
            ListaGeral.Add(new Modelo("TREM", 1, "Maglev", "TRE1", 1, "Shanghai Maglev"));
            ListaGeral.Add(new Modelo("TREM", 2, "CPTM", "TRE2", 1, "CPTM série 1700"));
            ListaGeral.Add(new Modelo("TREM", 2, "CPTM", "TRE2", 2, "CPTM série 2070"));
            ListaGeral.Add(new Modelo("NAVIO", 1, "Harland & Wolff", "NAV1", 1, "RMS Titanic"));
            ListaGeral.Add(new Modelo("NAVIO", 2, "Hyundai Merchant Marine", "NAV2", 1, "HMM Algeciras"));
            ListaGeral.Add(new Modelo("NAVIOGUERRA", 1, "Bath Iron Works", "NAG1", 1, "DDG 1000"));
            ListaGeral.Add(new Modelo("NAVIOGUERRA", 2, "Vickers Shipbuilding and Engineering", "NAG2", 1, "NAM Atlântico"));

            return ListaGeral;
        }
        



        /// <summary>
        /// Lista gerada a partir da ListaGeral dependendo do tipo do veiculo procurado pela string
        /// </summary>
        /// <param name="tipoveiculo"></param>
        /// <returns>List<Modelo></returns>
        public static List<Modelo> PegarLista(string tipoveiculo)
        {
            List<Modelo> listaretorno = Dados().FindAll(x => x.TipoVeiculo.ToUpper() == tipoveiculo);
            return listaretorno;

        }
        #endregion
    }
}
            
            
            
            
            
            
           









