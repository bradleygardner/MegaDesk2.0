using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MegaDesk2._0___Team_Cumorah
{
    public static class DataStorage
    {
        private const string FILENAME = "quotes.json";
        public static List<DeskQuote> DeskQuotes = new List<DeskQuote>();

        public static void AddQuote(DeskQuote deskQuote) 
        {  
            DeskQuotes.Add(deskQuote);
            Serialize();
        }

        public static List<DeskQuote> SearchDeskQuote(DesktopMaterial desktopMaterial)
        {
            var filterQuotes = DeskQuotes.Where(c => c.Desk.SurfaceMaterials == desktopMaterial).ToList();
            return filterQuotes;
        }

        public static void Serialize()
        {
            try
            {
                var json = JsonConvert.SerializeObject(DeskQuotes);
                File.WriteAllText(FILENAME, json);
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
                DeskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to deserialize desk quotes! Error: {e.Message}");
            }
        }
    }
}
