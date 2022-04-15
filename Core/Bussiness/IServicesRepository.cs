using Core.Utilities.Result;
using Core.Entities;
using System.Linq.Expressions;
using Core.Aspects.Autofac.Caching;

namespace Business.Abstract
{
    public interface IServicesRepository<T> where T : class, IEntity, new()
         
    {
        IDataResult<List<T>> GetAll();

        IDataResult<T> GetById(int id);
        
        IResult Add(T entity);
        IResult Update(T entity);

        IResult Delete(T entity);

      
    }
  
}
