using System.Collections.Generic;
using DataAcess;
using Models;
using ViewModels;

namespace BLL
{
    public class ArticleService
    {
        /// <summary>
        ///     instance of article context used to communicate to data layer
        /// </summary>
        private readonly ArticleContext articleContext = new ArticleContext();

        /// <summary>
        ///     Method to get all articles
        /// </summary>
        /// <returns>list of articles</returns>
        public List<ViewArticlePreview> GetAllArticles()
        {
            var articles = articleContext.GetAllArticles();
            var viewArticles = new List<ViewArticlePreview>();
            foreach (var art in articles)
            {
                var z = art.content.Length > 200 ? art.content.Substring(0, 200) : art.content;
                z += "...";
                viewArticles.Add(
                    new ViewArticlePreview(art.name, art.date, z)
                );
            }


            return viewArticles;
        }

        /// <summary>
        ///     method to add an article
        /// </summary>
        /// <param name="viewArticlePreview">article</param>
        public void AddArticle(ViewArticle viewArticle)
        {
            var article = new Article(viewArticle.name, viewArticle.date, viewArticle.content, new ArticleHashtags());
            articleContext.AddArticle(article);
        }

        /// <summary>
        ///     method to get a full single article
        /// </summary>
        /// <param name="year">year of post</param>
        /// <param name="month">month of post</param>
        /// <param name="title">title of article</param>
        /// <returns></returns>
        public ViewArticle GetArticle(int year, int month, string title)
        {
            var article = articleContext.GetArticle(year, month, title);
            return new ViewArticle(article.name, article.date, article.content,
                new ViewArticleHashtags(article.articleHashtags.hashtags));
        }
    }
}