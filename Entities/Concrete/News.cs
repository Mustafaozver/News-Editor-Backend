using Core.Entities;


namespace Entities.Concrete
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Headline  { get; set; }
        public string Body  { get; set; }
        public DateTime PuplisingDate { get; set; }
        public string Link { get; set; }
        public int UserId { get; set; }
     
        public bool IsActive{ get; set; }
    }
}
