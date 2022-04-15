using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NewsCategoriesManager : INewsCategoriesService
    {
        INewsCategoriesDal _newsCategoriesdal;

        public NewsCategoriesManager(INewsCategoriesDal newsCategoriesdal)
        {
            _newsCategoriesdal = newsCategoriesdal;
        }

        public IResult Add(NewsCategories newsCategories)
        {
            _newsCategoriesdal.Add(newsCategories);
            return new SuccessResult(Messages.NewsCategoriesAddedSuccess);
        }

        public IResult Delete(NewsCategories entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<NewsCategories>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<NewsCategories> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<NewsCategories> GetByIdCategoryId(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<NewsCategories>> GetByNewsId(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(NewsCategories entity)
        {
            throw new NotImplementedException();
        }
    }
}
