using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk2._0___Team_Cumorah
{
    public static class DataStorage
    {
        private const string FILENAME = "NewJsonQuotes.json";
        public static List<DeskQuote> DeskQuotes = new List<DeskQuote>();

        public async static void AddQuote(DeskQuote deskQuote) 
        {  
            DeskQuotes.Add(deskQuote);
            await Serialize();
        }

        public static List<DeskQuote> SearchDeskQuote(DesktopMaterial desktopMaterial)
        {
            var filterQuotes = DeskQuotes.Where(c => c.Desk.SurfaceMaterials == desktopMaterial).ToList();
            return filterQuotes;
        }

        public async static Task Serialize()
        {
            try
            {
                var createStream = File.Create(FILENAME);
                await JsonSerializer.SerializeAsync(createStream, DeskQuotes);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to Serialize desk quotes! Error {e.Message}");
            }
            
        }

        public static void Deserialize()
        {
            try
            {
                string json = File.ReadAllText(FILENAME);
                DeskQuotes = JsonSerializer.Deserialize<List<DeskQuote>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to deserialize desk quotes! Error: {e.Message}");
            }
        }
    }
}
