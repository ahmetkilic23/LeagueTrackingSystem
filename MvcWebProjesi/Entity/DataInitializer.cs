using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebProjesi.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var teams = new List<Team>()
            {
                new Team() {TeamName = "Besiktas", Country = "Turkey", Image = "/TeamImg/besiktas.png", IsActive = true},
                new Team() {TeamName = "Fenerbahce", Country = "Turkey", Image = "/TeamImg/fenerbahce.png", IsActive = true},
                new Team() {TeamName = "Galatasaray", Country = "Turkey", Image = "/TeamImg/galatasaray.png", IsActive = true},
                new Team() {TeamName = "RealMadrid", Country = "Spain", Image = "/TeamImg/realmadrid.png", IsActive = true}
            };

            foreach (var item in teams)
            {
                context.Teams.Add(item);
            }
            context.SaveChanges();

            //----------------------------------------------------------

            var seasons = new List<Season>()
            {
                new Season() {SeasonYear = "2022-2023", SeasonName="Dr. Cemil Taşçıoğlu"},
                new Season() {SeasonYear = "2023-2024", SeasonName="Trendyol"},
                new Season() {SeasonYear = "2024-2025", SeasonName="Ahmet Çalık"},
            };

            foreach (var item in seasons)
            {
                context.Seasons.Add(item);
            }
            context.SaveChanges();

            //----------------------------------------------------------

            var teamSeasons = new List<TeamSeason>() {
                new TeamSeason() { TeamId = 1, SeasonId = 1 },
                new TeamSeason() { TeamId = 1, SeasonId = 2 },
                new TeamSeason() { TeamId = 1, SeasonId = 3 },
                new TeamSeason() { TeamId = 2, SeasonId = 1 },
                new TeamSeason() { TeamId = 2, SeasonId = 2 },
                new TeamSeason() { TeamId = 2, SeasonId = 3 },
                new TeamSeason() { TeamId = 3, SeasonId = 1 },
                new TeamSeason() { TeamId = 3, SeasonId = 2 },
                new TeamSeason() { TeamId = 3, SeasonId = 3 },
                new TeamSeason() { TeamId = 4, SeasonId = 1 },
                new TeamSeason() { TeamId = 4, SeasonId = 2 },
                new TeamSeason() { TeamId = 4, SeasonId = 3 },
            };

            foreach (var item in teamSeasons)
            {
                context.TeamSeasons.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            var players = new List<Player>()
            {
                new Player() {PlayerName = "Vincent Aboubakar", Country="Cameroon", Image="/PlayerImg/aboubakar.jpg",TeamId = 1},
                new Player() {PlayerName = "Rachid Ghezzal", Country="Algeria", Image="/PlayerImg/ghezzal.jpg",TeamId = 1},
                new Player() {PlayerName = "Cenk Tosun", Country="Turkey", Image="/PlayerImg/tosun.jpg",TeamId = 1},
                new Player() {PlayerName = "Mert Gunok", Country="Turkey", Image="/PlayerImg/gunok.jpg",TeamId = 1},
                new Player() {PlayerName = "Dusan Tadic", Country="Serbia", Image="/PlayerImg/tadic.jpg",TeamId = 2},
                new Player() {PlayerName = "Mert Hakan Yandas", Country="Turkey", Image="/PlayerImg/yandas.jpg",TeamId = 2},
                new Player() {PlayerName = "Ferdi Kadioglu", Country="Turkey", Image="/PlayerImg/kadioglu.jpg",TeamId = 2},
                new Player() {PlayerName = "Altay Bayindir", Country="Turkey", Image="/PlayerImg/bayindir.jpg",TeamId = 2},
                new Player() {PlayerName = "Mauro Icardi", Country="Argentina", Image="/PlayerImg/icardi.jpg",TeamId = 3},
                new Player() {PlayerName = "Wilfried Zaha", Country="Ivory Coast", Image="/PlayerImg/zaha.jpg",TeamId = 3},
                new Player() {PlayerName = "Nicolo Zaniolo", Country="Italy", Image="/PlayerImg/zaniolo.jpg",TeamId = 3},
                new Player() {PlayerName = "Fernando Muslera", Country="Uruguay", Image="/PlayerImg/muslera.jpg",TeamId = 3},
                new Player() {PlayerName = "Arda Guler", Country="Turkey", Image="/PlayerImg/guler.jpg",TeamId = 4},
                new Player() {PlayerName = "Vinicius Junior", Country="Brazil", Image="/PlayerImg/vinicius.jpg",TeamId = 4},
                new Player() {PlayerName = "Rodrygo", Country="Brazil", Image="/PlayerImg/rodrygo.jpg",TeamId = 4},
                new Player() {PlayerName = "Thibaut Courtois", Country="Belgium", Image="/PlayerImg/courtois.jpg",TeamId = 4}
            };

            foreach (var item in players)
            {
                context.Players.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            var matches = new List<Match>()
            {
                new Match() {HomeTeamId = 1, AwayTeamId = 2, Result = "0-0", Week = 1, SeasonId = 1},
                new Match() {HomeTeamId = 2, AwayTeamId = 3, Result = "0-0", Week = 1, SeasonId = 1},
                new Match() {HomeTeamId = 1, AwayTeamId = 3, Result = "0-0", Week = 2, SeasonId = 1},
                new Match() {HomeTeamId = 2, AwayTeamId = 4, Result = "0-0", Week = 2, SeasonId = 1},
                new Match() {HomeTeamId = 1, AwayTeamId = 4, Result = "0-0", Week = 3, SeasonId = 1},
                new Match() {HomeTeamId = 2, AwayTeamId = 3, Result = "0-0", Week = 3, SeasonId = 1}
            };

            foreach (var item in matches)
            {
                context.Matches.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            var teamResults = new List<TeamResult>()
            {
                new TeamResult() { TeamSeasonId = 1, Win = 0, Draw = 0, Lose = 0},
                new TeamResult() { TeamSeasonId = 4, Win = 0, Draw = 0, Lose = 0},
                new TeamResult() { TeamSeasonId = 7, Win = 0, Draw = 0, Lose = 0},
                new TeamResult() { TeamSeasonId = 10, Win = 0, Draw = 0, Lose = 0}
            };

            foreach (var item in teamResults)
            {
                context.TeamResults.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            var playerAttributes = new List<PlayerAttribute>()
            {
                //Besiktas Players
                new PlayerAttribute() {PlayerId = 1, Age = 31, Rating = 82, PlayerValue = 6000000, TeamSeasonId = 1},
                new PlayerAttribute() {PlayerId = 2, Age = 31, Rating = 80, PlayerValue = 5000000, TeamSeasonId = 1},
                new PlayerAttribute() {PlayerId = 3, Age = 32, Rating = 78, PlayerValue = 3200000, TeamSeasonId = 1},
                new PlayerAttribute() {PlayerId = 4, Age = 34, Rating = 77, PlayerValue = 1300000, TeamSeasonId = 1},

                //Fenerbahce Players
                new PlayerAttribute() {PlayerId = 5, Age = 34, Rating = 82, PlayerValue = 6000000, TeamSeasonId = 4},
                new PlayerAttribute() {PlayerId = 6, Age = 28, Rating = 76, PlayerValue = 2000000, TeamSeasonId = 4},
                new PlayerAttribute() {PlayerId = 7, Age = 23, Rating = 80, PlayerValue = 17000000, TeamSeasonId = 4},
                new PlayerAttribute() {PlayerId = 8, Age = 25, Rating = 78, PlayerValue = 11000000, TeamSeasonId = 4},

                //Galatasaray Players
                new PlayerAttribute() {PlayerId = 9, Age = 30, Rating = 82, PlayerValue = 19000000, TeamSeasonId = 7},
                new PlayerAttribute() {PlayerId = 10, Age = 30, Rating = 80, PlayerValue = 22000000, TeamSeasonId = 7},
                new PlayerAttribute() {PlayerId = 11, Age = 24, Rating = 79, PlayerValue = 27000000, TeamSeasonId = 7},
                new PlayerAttribute() {PlayerId = 12, Age = 37, Rating = 77, PlayerValue = 1600000, TeamSeasonId = 7},

                //Real Madrid Players
                new PlayerAttribute() {PlayerId = 13, Age = 18, Rating = 80, PlayerValue = 15000000, TeamSeasonId = 10},
                new PlayerAttribute() {PlayerId = 14, Age = 23, Rating = 90, PlayerValue = 150000000, TeamSeasonId = 10},
                new PlayerAttribute() {PlayerId = 15, Age = 22, Rating = 88, PlayerValue = 100000000, TeamSeasonId = 10},
                new PlayerAttribute() {PlayerId = 16, Age = 31, Rating = 86, PlayerValue = 45000000, TeamSeasonId = 10},
            };

            foreach (var item in playerAttributes)
            {
                context.PlayerAttributes.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            var budgetRatings = new List<BudgetRating>()
            {
                new BudgetRating() {TeamSeasonId = 1, TeamRating = 0, TeamBudget = 13000000},
                new BudgetRating() {TeamSeasonId = 4, TeamRating = 0, TeamBudget = 24000000},
                new BudgetRating() {TeamSeasonId = 7, TeamRating = 0, TeamBudget = 22000000},
                new BudgetRating() {TeamSeasonId = 10, TeamRating = 0, TeamBudget = 200000000}
            };

            foreach(var item in budgetRatings)
            {
                context.BudgetRatings.Add(item);
            }

            context.SaveChanges();

            //----------------------------------------------------------

            base.Seed(context);
        }
    }
}