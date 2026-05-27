using Options.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Options.Infrastructure.Services
{
    public class WatchlistStorageService
    {
        private readonly string _filePath = "C:\\Token\\watchlist.json";

        public void Save(List<WatchItem> items)
        {
            string json =
                JsonSerializer.Serialize(
                    items,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

            File.WriteAllText(_filePath, json);
        }

        public List<WatchItem> Load()
        {
            if (!File.Exists(_filePath))
            {
                return new List<WatchItem>();
            }

            string json =
                File.ReadAllText(_filePath);

            return JsonSerializer.Deserialize<List<WatchItem>>(json)
                   ?? new List<WatchItem>();
        }
    }
}
