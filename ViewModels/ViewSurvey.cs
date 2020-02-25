using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class ViewSurvey
    {
        public int SurveyId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string name { get; set; }

        public DateTime? date { get; set; }
        public IList<string> listVers = new List<string> {"2.3", "4.0", "4.2", "5.0", "6.0", "8.1", "10"};
        public IList<string> listEms = new List<string> {"love", "don`t like", "hate"};
        public string surname { get; set; }
        public IList<string> andVers = new List<string>();
        public string emotions { get; set; }

        /// <summary>
        ///     empty constructor
        /// </summary>
        public ViewSurvey()
        {
            date = DateTime.Now;
        }

        /// <summary>
        ///     constructor with parameters
        /// </summary>
        /// <param name="nm">name</param>
        /// <param name="dt">date</param>
        /// <param name="sr">surname</param>
        /// <param name="vers">versions</param>
        /// <param name="ems">emotions</param>
        public ViewSurvey(string nm, DateTime? dt, string sr, IList<string> vers, string ems)
        {
            name = nm;
            date = dt;
            surname = sr;
            if (vers != null) andVers = vers;

            emotions = ems;
        }
    }
}