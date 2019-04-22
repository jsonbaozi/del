using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lincoln.ViewModels;
using Lincoln.Models;
using System.Net;
using Newtonsoft.Json;
using Lincoln.Infrastructure;

namespace Lincoln.Controllers
{
  public class HomeController : Controller
  {
    private readonly IGameManager _gameManager;
    public HomeController(IGameManager gameManager)
    {
      _gameManager = gameManager;
    }

    public IActionResult ListGames()
    {
      List<Game> games = _gameManager.ListGames();
      return View(games);
    }

    [Route("Game/{slug}")]
    public IActionResult Game(string slug)
    {
      return View(_gameManager.GetGame(slug));
    }
  }
}
