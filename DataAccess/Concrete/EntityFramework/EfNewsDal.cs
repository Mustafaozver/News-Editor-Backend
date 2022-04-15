using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfNewsDal : EfEntityRepositoryBase<News, NewsEditorDBContext>, INewsDal
    {
        public News GetLastNews()
        {
            using (NewsEditorDBContext context = new NewsEditorDBContext())
            {
                var result = from n in context.News
                             orderby n.Id descending
                             select new News
                             {
                                 Body = n.Body,
                                 Id = n.Id,
                                 Headline = n.Headline,
                                 IsActive = n.IsActive,
                                 Link = n.Link,
                                 PuplisingDate = n.PuplisingDate,
                                
                                 UserId = n.UserId
                             };

                return result.FirstOrDefault();

            }
        }

        public List<NewsDetailsDto> GetNewsDetails()
        {
            using (NewsEditorDBContext context = new NewsEditorDBContext())
            {
               
                




                var result = from n in context.News
                             join nc in context.NewsCategories
                             on n.Id equals nc.NewsId
                             join c in context.Categories
                             on nc.CategoryId equals c.Id
                             
                             select  new NewsDetailsDto
                             { 
                                 Id = n.Id,
                                 Headline = n.Headline,
                                 Body = n.Body,
                                 Categories=c,
                                 
                                 PuplisingDate = n.PuplisingDate,
                                 Link = n.Link,
                                 IsActive = n.IsActive
                             };
                
                result.ToList();

              
                

                return result.ToList();


                // Haberin Id sini alıp haberkategori tablosundan filtreleme yapacak
                // o haberin kategorilerini bulup categorilerini listeye atacak
                // 

            }
        }
    }

}
