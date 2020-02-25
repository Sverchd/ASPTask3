using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models;

namespace DataAcess
{
    public class ArticleContext
    {
        /// <summary>
        ///     Method to get all article from db context
        /// </summary>
        /// <returns>list of articles</returns>
        public List<Article> GetAllArticles()
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                var datalist = lineageContext.Articles.Include("ArticleHashtags").ToList();
                return datalist;
            }
        }

        /// <summary>
        ///     Method to add an article to the db context
        /// </summary>
        /// <param name="article">article</param>
        public void AddArticle(Article article)
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                lineageContext.Articles.Add(article);
                lineageContext.SaveChanges();
            }
        }

        /// <summary>
        ///     method to get a full single article
        /// </summary>
        /// <param name="year">year of post</param>
        /// <param name="month">month of post</param>
        /// <param name="title">title of article</param>
        /// <returns></returns>
        public Article GetArticle(int year, int month, string title)
        {
            using (var lineageContext = new LineageContext("LineageContext"))
            {
                return lineageContext.Articles
                    .Where(p => p.date.Year == year && p.date.Month == month && p.name == title)
                    .Include("ArticleHashtags")
                    .Single();
            }
        }
    }
}