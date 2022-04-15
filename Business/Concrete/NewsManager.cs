using Business.Abstract;
using Business.BussinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Concrete
{
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;

        
        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
           
        }


        [ValidationAspect(typeof(NewsValidator))]
        [CacheRemoveAspect("INewsService.Get")]
        public IResult Add(News news)
        {
            IResult result =BusinessRules.Run(CheckNewsHeadLine(news.Headline));
            if (result!=null)
            {
                return result;
           
                
            }
            _newsDal.Add(news);
            return new SuccessNewsResult(Messages.NewsAddedSuccess) { addedNewsId = news.Id };
        }

        [CacheRemoveAspect("INewsService.Get")]
        public IResult Delete(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult("Haber soft silindi.");
        }

        [CacheRemoveAspect("INewsService.Get")]
        public IResult Update(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult("Haber güncellendi.");
        }


        [CacheAspect]
        public IDataResult<List<News>> GetAll()
        {
            //if (DateTime.Now.Hour == 16)
            //{
            //    return new ErrorDataResult<List<News>>(Messages.NewsGetAllError);
            //}
            return new  SuccessDataResult<List<News>>(_newsDal.GetAll(x=>x.IsActive==true), Messages.NewsGetAllSuccess);
        }


        [CacheAspect]
        public IDataResult<News> GetById(int Id)
        {
            return new SuccessDataResult<News>(_newsDal.Get(c => c.Id == Id));
        }


       

        [CacheAspect]
        public IDataResult<List<News>> GetByTime(DateTime daymin, DateTime daymax)
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetAll(n=>n.PuplisingDate>=daymin && n.PuplisingDate<=daymax));
        }

        [CacheAspect]
        public IDataResult<List<NewsDetailsDto>> GetNewsDetailDto()
        {
            return new SuccessDataResult<List<NewsDetailsDto>>(_newsDal.GetNewsDetails( ));
        }

    
        private IResult CheckNewsHeadLine(string newsHeadline)
        {
            var result = _newsDal.GetAll(n => n.Headline == newsHeadline).Any();
            if (result)
            {
                return new ErrorResult(Messages.NewsHeadlineAllreadyExist);
            }
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(News news)
        {
            throw new NotImplementedException();
        }

        public IResult GetLastNewsId()
        {
            return new SuccessDataResult<News>(_newsDal.GetLastNews());
        }

        public IDataResult<List<News>> GetDraftNewsByEditorId(int Id)
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetAll(x=>x.UserId==Id&&x.IsActive==false), Messages.NewsGetAllSuccess);

        }

        public IDataResult<List<News>> GetAllDraft()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetAll(x=>x.IsActive==false), Messages.NewsGetAllSuccess);

        }
    }
}
