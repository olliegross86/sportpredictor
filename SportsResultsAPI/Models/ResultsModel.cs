using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Models
{
    public class ResultsModel
    {
        public IList<JToken> Results { get; set; }
        public IList<JToken> Videos { get; set; }
        public IList<JToken> Logos { get; set; }
        public int AvgHomeScore { get; set; }
    }
}
