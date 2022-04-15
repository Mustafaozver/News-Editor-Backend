using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Symbol : IEntity
    {
        public int Id { get; set; }
        public string SymbolName { get; set; }
        public string SymbolCode { get; set; }
        public bool Status { get; set; }
    }
}
