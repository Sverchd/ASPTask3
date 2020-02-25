using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BLL;
using ViewModels;

namespace ASPTask1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        ///     instance of article Service
        /// </summary>
        private readonly ArticleService articleService = new ArticleService();

        private readonly SurveyService surveyService = new SurveyService();

        /// <summary>
        ///     Action for Get requests to home page
        /// </summary>
        /// <returns>view of home page with survey</returns>
        [HttpGet]
        public ActionResult Index()
        {
            var articles = articleService.GetAllArticles();
            var res = new ViewHomeResult(articles, null);
            ViewBag.Type = "survey";
            return View(res);
        }

        /// <summary>
        ///     Action for Post requests to home page
        /// </summary>
        /// <param name="form">collection of form properties</param>
        /// <param name="versions">list of values of selected checkboxes (version of android os)</param>
        /// <param name="emotions">selected emotion about the rom</param>
        /// <returns>view of home page with result of survey</returns>
        [HttpPost]
        public ActionResult IndexResult(FormCollection form, List<string> versions, string emotions)
        {
            var surv = new ViewSurvey(form["Name"], DateTime.Now, form["SurName"], versions, emotions);
            var articles = articleService.GetAllArticles();
            ViewBag.Type = "result";
            surveyService.AddSurvey(surv);
            var res = new ViewHomeResult(articles, surv);
            return View("Index", res);
        }
    }
}