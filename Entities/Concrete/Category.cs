using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public bool Status { get; set; }

        public static implicit operator List<object>(Category v)
        {
            throw new NotImplementedException();
        }
    }

}
