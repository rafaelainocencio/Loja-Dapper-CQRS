using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public class Pedido
    {
        public Pedido()
        {
            DataPedido = DateTime.UtcNow;
        }

        public DateTime DataPedido { get; set; }
    }
}
