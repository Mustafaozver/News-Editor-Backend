using Core.Entities;

namespace Entities.Concrete
{
    public class NewsSource : IEntity
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int NewsId { get; set; }
    }
}
