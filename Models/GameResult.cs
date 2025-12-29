using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoStatsApp.Models
{
        public class GameResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;

        public List<string> Players { get; set; } = new();
        public string Winner { get; set; } = "";
    }
}
