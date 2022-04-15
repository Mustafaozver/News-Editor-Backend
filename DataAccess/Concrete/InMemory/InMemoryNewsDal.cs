using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryNewsDal 
    {
        List<News> _news;

        public InMemoryNewsDal()
        {
            _news = new List<News>
            {
                new News{Id = 1,Headline="HeadLine",Body="Body",Link="llink",PuplisingDate=DateTime.Now,UserId=1,IsActive=true},
                new News{Id = 2,Headline="HeadLine2",Body="Body2",Link="llink2",PuplisingDate=DateTime.Now,UserId=2,IsActive=true}
            };
        }

        public void Add(News news)
        {
            _news.Add(news);
        }

        public void Delete(News news, News? newsToDelete)
        {
            var newsToDeleted = _news.SingleOrDefault(predicate: n => n.Id == newsToDelete.Id);
            _news.Remove(newsToDeleted);
        }

        public News Get(Expression<Func<News>> filter)
        {
            throw new NotImplementedException();
        }

        public News Get(Expression<Func<News, bool>> filter)
        {
            throw new NotImplementedException();
        }

     

        public List<News> GetAll()
        {
            return _news;
        }

        public List<News> GetAll(Expression<Func<News>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public List<News> GetAll(Expression<Func<News, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

       

      

        public List<NewsDetailsDto> GetNewsDetails()
        {
            throw new NotImplementedException();
        }

        public List<NewsDetailsDto> GetNewsDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(News news)
        {
            var newsToUpdate = _news.SingleOrDefault(n => n.Id == news.Id);
            newsToUpdate.Body = news.Body;
            newsToUpdate.Link = news.Link;
            newsToUpdate.PuplisingDate = news.PuplisingDate;
            newsToUpdate.Headline= news.Headline;
            newsToUpdate.IsActive = news.IsActive;
            newsToUpdate.UserId= news.UserId;
            
        }
    }
}
