using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Utils
{
    public class API
    {
        public IRestResponse response;

        public IList<JToken> GetTeam()
        {
            Teams();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> teams = json["teams"].Children().ToList();
            IList<JToken> teamList = new List<JToken>();
            
            for (int i = 0; i < teams.Count; i++)
            {
                var leeds = teams[i]["strTeam"].ToString();

                if (leeds.ToString().Contains("Leeds"))
                {
                    continue;
                }

                else
                {
                    {
                        var teamname = teams[i]["strTeam"].ToString();
                        var manager = teams[i]["strManager"].ToString();
                        var stadium = teams[i]["strStadium"].ToString();
                        var description = teams[i]["strDescriptionEN"].ToString();
                        var stadiumImage = teams[i]["strStadiumThumb"].ToString();
                        var stadiumCapacity = teams[i]["intStadiumCapacity"].ToString();
                        var teamLogo = teams[i]["strTeamBadge"].ToString();
                        var teamKit = teams[i]["strTeamJersey"].ToString();
                        teamList.Add(teamname + "*" + manager + "*" + stadium + "*" + description + "*" + stadiumImage + "*" + stadiumCapacity + "*" + teamLogo + "*" + teamKit);
                    }
                }
            }
            
            
            return (teamList);

        }

        public string TeamChoice { get; set; }
        public IList<JToken> GetResults()
        {
            Results();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> results = json["events"].Children().ToList();
            IList<JToken> resultList = new List<JToken>();
            IList<JToken> homeresultList = new List<JToken>();
            IList<JToken> awayresultList = new List<JToken>();

           
                for (int i = 0; i < results.Count; i++)
            {
                if (results[i]["intHomeScore"].ToString() != "")
                { 
                    var homeTeam = results[i]["strHomeTeam"].ToString();
                    var awayTeam = results[i]["strAwayTeam"].ToString();
                    var homeScore = results[i]["intHomeScore"].ToString();
                    var awayScore = results[i]["intAwayScore"].ToString();
                    var date = results[i]["dateEvent"].ToString();
                    var video = results[i]["strVideo"].ToString().Replace("https://www.youtube.com/watch?v=", "https://www.youtube.com/embed/");
                    resultList.Add(homeTeam + "," + homeScore + "," + awayTeam + "," + awayScore + "," + date + "," + video);
                }
            }

            return (resultList);

        }

        public IList<int> AverageScore()
        {
            Results();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> results = json["events"].Children().ToList();
            IList<int> avgScoreList = new List<int>();


            for (int i = 0; i < results.Count; i++)
            {
                if (results[i]["intHomeScore"].ToString() != "")
                {
                    var homeScore = results[i]["intHomeScore"].ToString();
                    var avgHomeScore = Int32.Parse(homeScore);

                    avgScoreList.Add(avgHomeScore);
                }
            }

            return (avgScoreList);

        }

        public IList<JToken> GetFixtures()
        {
            Results();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> fixtures = json["events"].Children().ToList();
            IList<JToken> fixtureList = new List<JToken>();
            IList<JToken> homeFixtureList = new List<JToken>();
            IList<JToken> awayFixtureList = new List<JToken>();


            for (int i = 0; i < fixtures.Count; i++)
            {
                if (fixtures[i]["intHomeScore"].ToString() == "")
                {
                    var homeTeam = fixtures[i]["strHomeTeam"].ToString();
                    var awayTeam = fixtures[i]["strAwayTeam"].ToString();

                    
                    fixtureList.Add(homeTeam + "," + awayTeam);
                }
            }

            return (fixtureList);

        }

        public IList<JToken> GetVideos()
        {
            Results();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> videos = json["events"].Children().ToList();
            IList<JToken> videoList = new List<JToken>();

            for (int i = 0; i < videos.Count; i++)
            {
                {   
                    var video = videos[i]["strVideo"].ToString().Replace("https://www.youtube.com/watch?v=", "https://www.youtube.com/embed/");
                    videoList.Add(video);
                }
            }

            return (videoList);

        }

        public IList<JToken> Logos()
        {
            Teams();

            var jsonData = JsonConvert.DeserializeObject(response.Content);

            JObject json = JObject.Parse(response.Content);

            IList<JToken> logos = json["teams"].Children().ToList();
            IList<JToken> logoList = new List<JToken>();
            
            for (int i = 0; i < logos.Count; i++)
            {
                var leeds = logos[i]["strTeamBadge"].ToString();

                if (leeds.ToString().Contains("https://www.thesportsdb.com/images/media/team/badge/ytptrv1450087244.png"))
                    {
                        continue;
                    }

                    else
                    {
                        var logoImage = logos[i]["strTeamBadge"].ToString();
                        logoList.Add(logoImage);
                    }
                }
            return (logoList);

        }

        public IRestResponse Results()
        {
            var client = new RestClient("https://www.thesportsdb.com/api/v1/json/1/eventsseason.php?id=4414&s=1920");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "__cfduid=d1f3626759c8cec7aa66e1e29cda70e5f1574253953");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "www.thesportsdb.com");
            request.AddHeader("Postman-Token", "ed91ca45-50ce-47a4-8b82-01aed88a37fc,d2a50eb1-d2c6-4205-9fb9-091db56005f5");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            response = client.Execute(request);

            return (response);
        }

        public IRestResponse Teams()
        {
            var client = new RestClient("https://www.thesportsdb.com/api/v1/json/1/lookup_all_teams.php?id=4414");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "www.thesportsdb.com");
            request.AddHeader("Postman-Token", "27bae8b6-06cd-47ab-961b-2447955bc599,6fd48979-2288-4685-b2ef-1f0392456218");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            response = client.Execute(request);

            return (response);
        }

    }

}
