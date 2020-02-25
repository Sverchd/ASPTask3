using System;

namespace ViewModels
{
    public class ViewArticle
    {
        public int ArticleId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string content { get; set; }

        public ViewArticleHashtags hashtags { get; set; }

        /// <summary>
        ///     empty constructor
        /// </summary>
        public ViewArticle()
        {
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="ct">content</param>
        public ViewArticle(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            content = ct;
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="ct">content</param>
        /// <param name="vh">hashtags</param>
        public ViewArticle(string nm, DateTime dt, string ct, ViewArticleHashtags vh)
        {
            name = nm;
            date = dt;
            content = ct;
            hashtags = vh;
        }
    }
}