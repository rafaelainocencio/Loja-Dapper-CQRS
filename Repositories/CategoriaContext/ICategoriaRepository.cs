using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Repositories.CategoriaContext
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> ListAll();
        Task Insert(Categoria categoria);
    }
}
