using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    public class EventoMsg : EventArgs
    {
        public string FraseCarregado { get; set; }

        public EventoMsg(string frase)
        {
            FraseCarregado = frase;
        }
    }
}
