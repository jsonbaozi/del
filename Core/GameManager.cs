using Lincoln.Infrastructure;
using Lincoln.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Lincoln.Core
{
  public class GameManager : IGameManager
  {
    public List<Game> ListGames()
    {
      List<Game> games = new List<Game>();

      try
      {
        using (var client = new WebClient())
        {
          var json = client.DownloadString("https://clientupdate-v6.cursecdn.com/Feed/games/v10/games.json");
          var items = JsonConvert.DeserializeObject<GameDBResponse>(json);

          var lowPrioGames = items.Games.Where(i => i.Order == 0).OrderByDescending(i => i.SupportsAddons).ThenBy(i => i.Name);
          items.Games = items.Games.Where(i => i.Order > 0).OrderByDescending(i => i.Order).ThenBy(i => i.Name).Concat(lowPrioGames);

          foreach (var game in items.Games)
          {
            games.Add(game);
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }
      return games;
    }

    public Game GetGame(string slug)
    {
      try
      {
        Game game = new Game();
        using (var client = new WebClient())
        {
          var json = client.DownloadString("https://clientupdate-v6.cursecdn.com/Feed/games/v10/games.json");
          var items = JsonConvert.DeserializeObject<GameDBResponse>(json);
          return items.Games.First(i => i.Slug == slug);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }
  }
}
