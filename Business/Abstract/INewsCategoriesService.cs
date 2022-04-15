using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface INewsCategoriesService : IServicesRepository<NewsCategories>
    {
        IDataResult<List<NewsCategories>> GetByNewsId(int Id);
        IDataResult<NewsCategories> GetByIdCategoryId(int Id);
       
    }
}
