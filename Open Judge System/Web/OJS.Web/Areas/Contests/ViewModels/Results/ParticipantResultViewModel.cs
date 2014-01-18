﻿namespace OJS.Web.Areas.Contests.ViewModels.Results
{
    using System.Collections.Generic;
    using System.Linq;

    public class ParticipantResultViewModel
    {
        public string ParticipantName { get; set; }

        public IEnumerable<ProblemResultPairViewModel> ProblemResults { get; set; }

        public int Total
        {
            get
            {
                return this.ProblemResults.Where(x => x.ShowResult).Sum(x => x.BestSubmission == null ? 0 : x.BestSubmission.Points);
            }
        }

        public int AdminTotal
        {
            get
            {
                return this.ProblemResults.Sum(x => x.BestSubmission == null ? 0 : x.BestSubmission.Points);
            }
        }
    }
}