using System;

namespace ViewModels
{
    public class ViewArticlePreview
    {
        public int ArticleId { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public string ShortContent { get; set; }

        /// <summary>
        ///     empty constructor
        /// </summary>
        public ViewArticlePreview()
        {
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="ct">short content</param>
        public ViewArticlePreview(string nm, DateTime dt, string ct)
        {
            name = nm;
            date = dt;
            ShortContent = ct;
        }
    }
}