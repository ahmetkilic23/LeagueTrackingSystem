using MvcWebProjesi.Entity;
using MvcWebProjesi.Models;
using RestSharp;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text.Json;
using System.Web;
using System.Web.Mvc;



namespace MvcWebProjesi.Controllers
{
    public class HomeController : Controller
    {
        DataContext context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            //var client = new RestClient("https://api.collectapi.com/football/results?data.league=ingiltere-premier-ligi");
            //var request = new RestRequest()
            //    .AddHeader("authorization", "apikey 5Bo6Ua6esiuyGjACwGx3eB:632SGL3KhUrchTa6KQnHK6");
            //var response = client.Execute(request);


            //var apiJson = System.IO.File.ReadAllText(response.Content);
            //ApiModel apiModel = JsonSerializer.Deserialize<ApiModel>(apiJson);

            return View();
        }

        public ActionResult Results()
        {
            var matches = context.Matches.ToList();
            List<TeamScoreViewModel> TeamScoreList = new List<TeamScoreViewModel>();
            foreach (var match in matches)
            {
                var homeTeamName = context.Teams.FirstOrDefault(x => x.Id == match.HomeTeamId).TeamName;
                var awayTeamName = context.Teams.FirstOrDefault(x => x.Id == match.AwayTeamId).TeamName;
                var homeLogo = context.Teams.FirstOrDefault(x => x.Id == match.HomeTeamId).Image;
                var awayLogo = context.Teams.FirstOrDefault(x => x.Id == match.AwayTeamId).Image;
                TeamScoreViewModel teamScore = new TeamScoreViewModel
                {
                    Score = match.Result,
                    HomeTeamName = homeTeamName,
                    AwayTeamName = awayTeamName,
                    HomeLogo = homeLogo,
                    AwayLogo = awayLogo,
                    Week = match.Week
                };
                TeamScoreList.Add(teamScore);
            }
            return View(TeamScoreList);
        }

        public ActionResult Teams()
        {
            return View(context.Teams.ToList());
        }

        public ActionResult Players()
        {

            var players = context.Players.ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                var teamName = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).TeamName;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo,
                    TeamName = teamName
                };
                playerLogoList.Add(playerLogoModel);
            }
            return View(playerLogoList);
        }

        [HttpPost]
        public ActionResult Players(string playerId)
        {
            var playerID = Convert.ToInt32(playerId);
            var playerAttributes = context.PlayerAttributes.ToList();
            //var players = context.

            var players = context.Players.ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
                };
                playerLogoList.Add(playerLogoModel);
            }
            var selected = playerLogoList.Where(x => x.Player.Id == playerID).ToList();

            return View(selected);
        }

        public ActionResult PlayerAttributes()
        {
            var players = context.Players.ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                var teamName = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).TeamName;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo,
                    TeamName = teamName
                };

                var pa = context.PlayerAttributes.FirstOrDefault(x => x.PlayerId == player.Id);
                PlayerRatingViewModel prvm = new PlayerRatingViewModel
                {
                    PLVM = playerLogoModel,
                    PlayerAttributes = pa
                };
                playerLogoList.Add(prvm);
            }

            return View(playerLogoList);
        }

        public ActionResult ResultTable()
        {
            List<LogoResultViewModel> logoResultList = new List<LogoResultViewModel>();
            var qs = (from t in context.Teams
                      join ts in context.TeamSeasons on t.Id equals ts.TeamId
                      join tr in context.TeamResults on ts.Id equals tr.TeamSeasonId
                      select new
                      {
                          Logo = t.Image,
                          TeamName = t.TeamName,
                          Win = tr.Win,
                          Draw = tr.Draw,
                          Lose = tr.Lose
                      });
            var count = 1;
            foreach (var item in qs)
            {
                var logoResult = new LogoResultViewModel
                {
                    Logo = item.Logo,
                    TeamName = item.TeamName,
                    Win = item.Win,
                    Draw = item.Draw,
                    Lose = item.Lose,
                     Count = count
                    
                };
                logoResultList.Add(logoResult);
                count++;
            }


           
            return View(logoResultList);
        }

        public ActionResult BudgetRatings()
        {
            var budgetRatings = context.BudgetRatings.ToList();
            foreach (var br in budgetRatings)
            {
                var counter = 0;
                var value = 0;
                var playerAttributes = context.PlayerAttributes.Where(x => x.TeamSeasonId == br.TeamSeasonId).ToList();
                foreach (var pa in playerAttributes)
                {
                    counter++;
                    value += pa.Rating;
                }
                br.TeamRating = value / counter;
            }
            context.SaveChanges();

            return View();
        }

        public ActionResult Besiktas()
        {

            var players = context.Players.Where(x => x.TeamId == 1).ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
                };
                playerLogoList.Add(playerLogoModel);
            }

            return View(playerLogoList);
        }

        public ActionResult Fenerbahce()
        {

            var players = context.Players.Where(x => x.TeamId == 2).ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
                };
                playerLogoList.Add(playerLogoModel);
            }

            return View(playerLogoList);
        }

        public ActionResult Galatasaray()
        {

            var players = context.Players.Where(x => x.TeamId == 3).ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
                };
                playerLogoList.Add(playerLogoModel);
            }

            return View(playerLogoList);
        }

        public ActionResult RealMadrid()
        {

            var players = context.Players.Where(x => x.TeamId == 4).ToList();
            List<PlayerLogoViewModel> playerLogoList = new List<PlayerLogoViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
                };
                playerLogoList.Add(playerLogoModel);
            }

            return View(playerLogoList);
        }
    }


}