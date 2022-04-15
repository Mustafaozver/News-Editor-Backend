using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class NewsCompany : IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int NewsId { get; set; }
    }
}
