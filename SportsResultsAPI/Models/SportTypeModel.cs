using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Models
{
    public class SportTypeModel
    {
        public string SportType { get; set; }

        public IList<JToken> Teams { get; set; }
        public IList<JToken> Scores { get; set; }
        public IList<JToken> Logos { get; set; }
        public String TeamChoice { get; set; }


    }
}
