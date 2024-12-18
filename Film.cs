using System.Text.Json;
using System.Text.Json.Nodes;
namespace CsharpSubmissionFilmCatalogue
{
    public class Film
    {
        public string title { get; set; }
        public string year { get; set; }
        public string rated { get; set; }
        public string released { get; set; }
        public string runtime { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public string writer { get; set; }
        public string actors { get; set; }
        public string plot { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public string awards { get; set; }
        public string poster { get; set; }
        public string metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string type { get; set; }
        public string dvd { get; set; }
        public string boxOffice { get; set; }
        public string website { get; set; }
        public string response { get; set; }
        public List<Rating> ratings { get; set; }
        public static string LoadFileAsString(string filepath)
        {
            if (!File.Exists(filepath))
            {
                string defaultFileText = "{ \"films\" : [] }";
                File.WriteAllText(filepath, defaultFileText);
            }

            string fileText = File.ReadAllText(filepath);

            return fileText;
        }
        public static JsonNode LoadFileAsJson(string filepath)
        {
            string fileText = LoadFileAsString(filepath);
            string fileTextEdit = string.Join(",", fileText);
            JsonNode json = JsonArray.Parse(fileTextEdit);

            return json;
        }
        public static void AddNewFilmsToFile(string filepath, List<Film> films)
        {
            List<string> lines = new List<string>();

            films.ForEach(film => {
                string filmString = JsonSerializer.Serialize(film);
                if (film.response == "False" || CheckIsDuplicate(Global.filmsFilepath, filmString)) return;
                lines.Add(filmString);
                });

            if (!File.Exists(filepath))
            {
                File.WriteAllLines(filepath, lines);
            }
            else
            {
                File.AppendAllLines(filepath, lines);
            }

        }
        public static void AddNewFilmToFile(string filepath, Film film)
        {
            if (film.response == "False") return;

            string filmString = JsonSerializer.Serialize(film);
            if (CheckIsDuplicate(Global.filmsFilepath, filmString)) return;
            
            List<string> lines = new List<string>();
            lines.Add(filmString);
            if (!File.Exists(filepath))
            {
                File.WriteAllLines(filepath, lines);
            }
            else
            {
                File.AppendAllLines(filepath, lines);
            }
        }
        public static void AddNewFilmToFile(string filepath, string film)
        {
            List<string> lines = new List<string>();
            lines.Add(film);
            if (!File.Exists(filepath))
            {
                File.WriteAllLines(filepath, lines);
            }
            else
            {
                File.AppendAllLines(filepath, lines);
            }
        }
        private static bool CheckIsDuplicate(string filepath, string film)
        {
            bool isDuplicate = false;
            if(File.Exists(filepath))
            {
                List<string> fileLines = File.ReadAllLines(filepath).ToList();
                isDuplicate = fileLines.Contains(film);
            }

            return isDuplicate;
        }

    }
}