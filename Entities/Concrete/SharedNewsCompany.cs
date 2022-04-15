using Core.Entities;

namespace Entities.Concrete
{
    public class SharedNewsCompany : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public bool Status { get; set; }
    }
}
