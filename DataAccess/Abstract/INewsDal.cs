using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface INewsDal:IEntityRepository<News>
    {
        List<NewsDetailsDto> GetNewsDetails();

        News GetLastNews();

    }

}
