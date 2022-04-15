using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NewsSourceManager : INewsSourceService
    {
        INewsSourceDal _newsSourcesdal;

        public NewsSourceManager(INewsSourceDal newsSourcesdal)
        {
            _newsSourcesdal = newsSourcesdal;
        }

        public IResult Add(NewsSource newsSource)
        {
            _newsSourcesdal.Add(newsSource);
            return new SuccessResult(Messages.NewsSourceAdded);
        }

        public IResult Delete(NewsSource newsSource)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<NewsSource>> GetAll()
        {
            return new SuccessDataResult<List<NewsSource>>(_newsSourcesdal.GetAll());
        }

        public IDataResult<NewsSource> GetById(int id)
        {
            return new SuccessDataResult<NewsSource>(_newsSourcesdal.Get(n => n.NewsId == id));

        }

      

        public IResult Update(NewsSource newsSource)
        {
            _newsSourcesdal.Update(newsSource);
            return new SuccessResult(newsSource.NewsId+"'li haberin kaynakları güncellendi.");
        }
    }
}
