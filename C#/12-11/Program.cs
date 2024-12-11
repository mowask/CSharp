
using L_12_11.Context;
using L_12_11.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace L_12_11 {
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new FootballContext()) 
            {
                //context.Players.Load();
                //foreach (var player in context.Players)
                //{
                //    Console.WriteLine(player.Name);
                //}


                //var players = context.Players.Select(p => new
                //{
                //    PlayerName = p.Name,
                //    TeamName = p.Team.Name,
                //    LeagueName = p.Team.League.Name
                //}).ToList();

                //foreach (var player in players)
                //{
                //    Console.WriteLine(player);
                //}

                                
                var players = context.Players.GroupBy(p => p.Team.Name).Select(g => new
                {
                    TeamName = g.Key,
                    Salary = g.Sum(p => p.Salary)
                });

                foreach (var player in players)
                {
                    Console.WriteLine(player);
                }
            }
        }
    }
}