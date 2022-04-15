using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Abstract
{
    public interface INewsService 
    {


        

        //SERVİCEREPODAN ALINCA CACHE SISTEMI CALISMIYOR
        IDataResult<List<News>> GetAll();
        IDataResult<List<News>> GetByTime(DateTime daymin,DateTime daymax);
        IDataResult<News> GetById(int Id);
        IDataResult<List<News>> GetDraftNewsByEditorId(int Id);
        IDataResult<List<News>> GetAllDraft();
        IDataResult<List<NewsDetailsDto>> GetNewsDetailDto();
        IResult Add(News news);
        IResult Delete(News news);
        IResult Update(News news);
        IResult GetLastNewsId();
        IResult AddTransactionalTest(News news);

    }
   
}
