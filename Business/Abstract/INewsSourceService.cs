using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INewsSourceService
    {
        IDataResult<List<NewsSource>> GetAll();

        IDataResult<NewsSource> GetById(int id);

        IResult Add(NewsSource newsSource);
        IResult Update(NewsSource newsSource);

        IResult Delete(NewsSource newsSource);


    }
}
