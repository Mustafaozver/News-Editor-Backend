using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SourceManager : ISourceService
    {
        ISourceDal _sourceDal;

        public SourceManager(ISourceDal sourceDal)
        {
            _sourceDal = sourceDal;
        }

        public IResult Add(Source source)
        {
            
            _sourceDal.Add(source);
            return new SuccessResult(Messages.SourceAdded);
        }

        public IResult Delete(Source entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Source>> GetAll()
        {
            return new SuccessDataResult<List<Source>>(_sourceDal.GetAll());
        }

        public IDataResult<Source> GetById(int sourceId)
        {
            return new SuccessDataResult<Source>(_sourceDal.Get(c => c.Id == sourceId));
        }

        public IResult Update(Source entity)
        {
            throw new NotImplementedException();
        }
    }
}
