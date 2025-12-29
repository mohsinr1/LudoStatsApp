using LudoStatsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LudoStatsApp.Services
{
    public class GameStorageService
    {
        private readonly string gamesPath =
            Path.Combine(FileSystem.AppDataDirectory, "games.json");

        private readonly string playersPath =
            Path.Combine(FileSystem.AppDataDirectory, "players.json");

        public List<GameResult> GetGames()
        {
            if (!File.Exists(gamesPath)) return new();
            return JsonSerializer.Deserialize<List<GameResult>>(File.ReadAllText(gamesPath))!;
        }

        public void SaveGames(List<GameResult> games)
        {
            File.WriteAllText(gamesPath, JsonSerializer.Serialize(games));
        }

        public List<Player> GetPlayers()
        {
            if (!File.Exists(playersPath)) return new();
            return JsonSerializer.Deserialize<List<Player>>(File.ReadAllText(playersPath))!;
        }

        public void SavePlayers(List<Player> players)
        {
            File.WriteAllText(playersPath, JsonSerializer.Serialize(players));
        }
    }

}
