using System.Collections.Generic;

namespace ViewModels
{
    public class ViewArticleHashtags
    {
        public int ArticleHashtagsId { get; set; }
        public IList<string> hashtags { get; set; }

        /// <summary>
        ///     empty constructore
        /// </summary>
        public ViewArticleHashtags()
        {
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="ht">list of hashtags</param>
        public ViewArticleHashtags(IList<string> ht)
        {
            //ArticleHashtagsId = id;
            hashtags = ht;
        }
    }
}