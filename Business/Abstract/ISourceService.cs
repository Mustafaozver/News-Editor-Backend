using Core.Utilities.Result;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface ISourceService 
    {
        IDataResult<List<Source>> GetAll();

        IDataResult<Source> GetById(int id);

        IResult Add(Source source);
        IResult Update(Source source);

        IResult Delete(Source source);
    }
}
