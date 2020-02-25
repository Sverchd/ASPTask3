using System.Collections.Generic;

namespace ViewModels
{
    public class ViewHomeResult
    {
        /// <summary>
        ///     list of article previews
        /// </summary>
        public IList<ViewArticlePreview> articles = new List<ViewArticlePreview>();

        /// <summary>
        ///     instance of survey
        /// </summary>
        public ViewSurvey survey = new ViewSurvey();

        /// <summary>
        ///     empty constructor
        /// </summary>
        public ViewHomeResult()
        {
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="art">list of articles</param>
        /// <param name="surv">survey instance</param>
        public ViewHomeResult(IList<ViewArticlePreview> art, ViewSurvey surv)
        {
            articles = art;
            survey = surv;
        }
    }
}