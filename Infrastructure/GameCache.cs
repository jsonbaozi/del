using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Lincoln.Models;
using Newtonsoft.Json;

namespace Lincoln.Infrastructure
{
  public class GameCache
  {
    /* This Class needs help acquiring the data from the URL */
    const string GameURL = "https://clientupdate-v6.cursecdn.com/Feed/games/v10/games.json";
    public bool Initialized { get; set; } = false;
    public List<Game> Games { get; set; }

    public GameCache()
    {
    }

    public async Task Initialize()
    {
    }
  }

  [DataContract]
  public class GameDBResponse
  {
    [DataMember(Name = "timestamp")]
    public long TimeStamp { get; set; }
    [DataMember(Name = "data")]
    public IEnumerable<Game> Games { get; set; }
  }
}