using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InCommingNews : IEntity
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string HeadLine { get; set; }
        public string Body { get; set; }
    }
}
