using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class NewsCompanyManager : INewsCompanyServices
    {
        INewsCompanyDal _newsCompanyDal;
        public NewsCompanyManager(INewsCompanyDal newsCompanyDal)
        {
            _newsCompanyDal = newsCompanyDal;
        }
        public IResult Add(NewsCompany newsCompany)
        {
            _newsCompanyDal.Add(newsCompany);
            return new SuccessResult(Messages.AddedNewsCompany);
        }

        public IResult Delete(NewsCompany newsCompany)
        {
            _newsCompanyDal.Delete(newsCompany);
            return new SuccessResult(Messages.DeletedNewsCompany);
        }

        public IDataResult<List<NewsCompany>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<NewsCompany> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(NewsCompany newsCompany)
        {
            _newsCompanyDal.Update(newsCompany);
            return new SuccessResult(Messages.UpdatedNewsCompany);
        }
    }
}
