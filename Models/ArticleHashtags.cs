using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class ArticleHashtags
    {
        public int ArticleHashtagsId { get; set; }
        public IList<string> hashtags { get; set; }

        /// <summary>
        ///     empty constructor
        /// </summary>
        public ArticleHashtags()
        {
        }

        /// <summary>
        ///     string property that helps to store list inside db
        /// </summary>
        public string andVersAsString
        {
            get
            {
                if (hashtags.Count > 0)
                    return string.Join(" ", hashtags);
                return " ";
            }
            set => hashtags = value.Split(' ').ToList();
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="ht">list of hashtags</param>
        public ArticleHashtags(IList<string> ht)
        {
            //ArticleHashtagsId = id;
            hashtags = ht;
        }
    }
}