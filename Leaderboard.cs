using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata2 
{
  public class Leaderboard 
  {
    private List<Player> Players { get; set; }
    public Leaderboard() 
    {
      Players = new List<Player>();
    }
    public void AddPlayer(Player player) 
    {
      Players.Add(player);
    }
    public List<Player> GetSortedPlayers()
    {
      return Players.OrderByDescending(p => p.Level).ToList();
    }
    public void PrintStats()
    {
      var sortedPlayers = GetSortedPlayers();
      Console.WriteLine("Leaderboard:");
      foreach (var player in sortedPlayers) 
      {
        Console.WriteLine(player.GetDescription());
      }
    }
  }
}
