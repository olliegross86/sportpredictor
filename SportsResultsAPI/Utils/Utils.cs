using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Utils
{
    public class Utils
    {
        public void jsonSplitter(List<JToken> list, String splitter, int i)
        {
            list.ToList()[i].ToString().Split(splitter);
        }
    }
}
