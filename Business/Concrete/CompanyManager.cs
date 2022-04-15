using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company entity)
        {
            _companyDal.Add(entity);
            return new SuccessResult(Messages.AddedCompany);
        }

        public IResult Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Company> Get(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll());
        }

        public IDataResult<Company> GetById(int sourceId)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(c => c.Id == sourceId));
        }

        public IResult Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
    
}
