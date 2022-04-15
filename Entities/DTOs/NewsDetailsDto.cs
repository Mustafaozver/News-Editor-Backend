
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class NewsDetailsDto: IDto
    {
      
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Body { get; set; }
        public Category Categories {get; set ;}
        public Source Source {get; set ; }
        public DateTime PuplisingDate { get; set; }
        public string Link { get; set; }
        public bool IsActive { get; set; }
    }
}
