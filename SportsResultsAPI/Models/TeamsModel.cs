using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Models
{
    public class TeamsModel
    {
        public IList<JToken> Teams { get; set; }
        public IList<JToken> Logos { get; set; }
        public IList<JToken> Results { get; set; }
        public IList<JToken> Fixtures { get; set; }
        public int avgHomeScore { get; set; }
        public int avgAwayScore { get; set; }
        public int avgHomeConceded { get; set; }
        public int avgAwayConceded { get; set; }
        public List<int> avgHomeScoreList { get; set; }
        public List<int> avgAwayScoreList { get; set; }
        public List<int> avgHomeConcededList { get; set; }
        public List<int> avgAwayConcededList { get; set; }
        public string NextTeam { get; set; }
        public List<int> HomeWinsList { get; set; }
        public int homeWins { get; set; }
        public List<int> AwayWinsList { get; set; }
        public int awayWins { get; set; }

        public List<int> HomeLossList { get; set; }
        public int homeLoss { get; set; }
        public List<int> AwayLossList { get; set; }
        public int awayLoss { get; set; }

        public List<int> HomeDrawList { get; set; }
        public int homeDraw { get; set; }
        public List<int> AwayDrawList { get; set; }
        public int awayDraw { get; set; }



        public int HomeTeamAverageResult { get; set; }
        public int AwayTeamAverageResult { get; set; }

        public int TeamHomePrediction { get; set; }
        public int TeamAwayPrediction { get; set; }
        public int HomeTeamHomePrediction { get; set; }
        public int AwayTeamAwayPrediction { get; set; }
    }
}
