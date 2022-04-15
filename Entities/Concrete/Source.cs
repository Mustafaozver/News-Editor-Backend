using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Source : IEntity
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public bool IsActive{ get; set; }
    }
}
