using System.Collections.Generic;
using DataAcess;
using Models;
using ViewModels;

namespace BLL
{
    public class SurveyService
    {
        /// <summary>
        ///     instance of article context used to communicate to data layer
        /// </summary>
        private readonly SurveyContext surveyContext = new SurveyContext();

        /// <summary>
        ///     Method to get all surveys
        /// </summary>
        /// <returns>list of surveys</returns>
        public IList<ViewSurvey> GetAllSurveys()
        {
            var surveys = surveyContext.GetAllSurveys();
            IList<ViewSurvey> viewSurveys = new List<ViewSurvey>();
            foreach (var sur in surveys)
                viewSurveys.Add(new ViewSurvey(sur.name, sur.date, sur.surname, sur.andVers, sur.emotions));

            return viewSurveys;
        }

        /// <summary>
        ///     method to add a survey
        /// </summary>
        /// <param name="viewSurvey">survey</param>
        public void AddSurvey(ViewSurvey viewSurvey)
        {
            IList<string> vers = new List<string>();
            if (viewSurvey.andVers != null)
                vers = viewSurvey.andVers;
            else
                vers.Add("");
            var survey = new Survey(viewSurvey.name, viewSurvey.date, viewSurvey.surname, vers,
                viewSurvey.emotions);
            surveyContext.AddSurvey(survey);
        }
    }
}