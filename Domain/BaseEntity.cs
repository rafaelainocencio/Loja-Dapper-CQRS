using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }
    }
}
