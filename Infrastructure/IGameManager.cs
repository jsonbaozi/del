using Lincoln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lincoln.Infrastructure
{
  public interface IGameManager
  {
    List<Game> ListGames();
    Game GetGame(string slug);
  }
}
