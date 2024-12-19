using System.Text.Json;
using System.Text.Json.Nodes;
namespace CsharpSubmissionFilmCatalogue
{
    //Requires Class 'Rating.cs'
    //Class to deserialize the JSON responce from OMDB's API into
    //Also allows the programme to Read/Write to a text(.txt) file
    public class Film
    {

        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Rated { get; set; }
        public string? Released { get; set; }
        public string? Runtime { get; set; }
        public string? Genre { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public string? Actors { get; set; }
        public string? Plot { get; set; }
        public  string? Language { get; set; }
        public string? Country { get; set; }
        public string? Awards { get; set; }
        public string? Poster { get; set; }
        public string? Metascore { get; set; }
        public string? ImdbRating { get; set; }
        public string? ImdbVotes { get; set; }
        public string? Type { get; set; }
        public string? Dvd { get; set; }
        public string? BoxOffice { get; set; }
        public string? Website { get; set; }
        public string? Response { get; set; }
        public List<Rating>? Ratings { get; set; }
        
        public static string LoadFileAsString(string filepath)
        {
            if (!File.Exists(filepath))
            {
                string defaultFileText = "";
                File.WriteAllText(filepath, defaultFileText);
            }

            string fileText = File.ReadAllText(filepath);

            return fileText;
        }
        public static void AddNewFilmToFile(string filepath, Film film)
        {
            if (film.Response == "False") return;
            //Make use of Serialization to convert the Film Object into a string which can then be stored 
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