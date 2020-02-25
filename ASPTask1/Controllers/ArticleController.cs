using System.Web.Mvc;
using BLL;

namespace ASPTask1.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService articleService = new ArticleService();

        /// <summary>
        ///     Action for getting a detailed view of an article
        /// </summary>
        /// <param name="year">year of post</param>
        /// <param name="month">month of post</param>
        /// <param name="title">title of article</param>
        /// <returns></returns>
        public ActionResult Article(int year, int month, string title)
        {
            var va = articleService.GetArticle(year, month, title);
            return View(va);
        }
    }
}