using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Models
{
    public class FixturesModel
    {
        public IList<JToken> Fixtures { get; set; }
        public IList<JToken> Results { get; set; }
        public IList<JToken> Teams { get; set; }
        public IList<int> TeamResults { get; set; }
        public int AvgHomeScore { get; set; }
        public int AvgAwayScore { get; set; }
        public int WinRatio { get; set; }
    }
}
