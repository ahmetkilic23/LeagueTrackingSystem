using MvcWebProjesi.Entity;
using MvcWebProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebProjesi.Controllers
{
    public class PlayerController : Controller
    {
        DataContext context = new DataContext();
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Player_1()
        {
            var players = context.Players.Where(x=>x.Id==1).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_2()
        {
            var players = context.Players.Where(x => x.Id == 2).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_3()
        {
            var players = context.Players.Where(x => x.Id == 3).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_4()
        {
            var players = context.Players.Where(x => x.Id == 4).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_5()
        {
            var players = context.Players.Where(x => x.Id == 5).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_6()
        {
            var players = context.Players.Where(x => x.Id == 6).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_7()
        {
            var players = context.Players.Where(x => x.Id == 7).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_8()
        {
            var players = context.Players.Where(x => x.Id == 8).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_9()
        {
            var players = context.Players.Where(x => x.Id == 9).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_10()
        {
            var players = context.Players.Where(x => x.Id == 10).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_11()
        {
            var players = context.Players.Where(x => x.Id == 11).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_12()
        {
            var players = context.Players.Where(x => x.Id == 12).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_13()
        {
            var players = context.Players.Where(x => x.Id == 13).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_14()
        {
            var players = context.Players.Where(x => x.Id == 14).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_15()
        {
            var players = context.Players.Where(x => x.Id == 15).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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

        public ActionResult Player_16()
        {
            var players = context.Players.Where(x => x.Id == 16).ToList();
            List<PlayerRatingViewModel> playerLogoList = new List<PlayerRatingViewModel>();

            foreach (var player in players)
            {
                var teamLogo = context.Teams.FirstOrDefault(x => x.Id == player.TeamId).Image;
                PlayerLogoViewModel playerLogoModel = new PlayerLogoViewModel
                {
                    Player = player,
                    Logo = teamLogo
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
    }
}