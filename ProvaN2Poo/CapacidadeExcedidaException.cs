﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaN2Poo
{
    class CapacidadeExcedidaException:Exception
    {
        public CapacidadeExcedidaException(string msg):base(msg)
        {

        }
    }
}
