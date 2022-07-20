using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.wwwroot
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int CategoriaId { get; set; }
    }
}
