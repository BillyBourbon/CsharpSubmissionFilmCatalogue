using System.Text.Json;

namespace CsharpSubmissionFilmCatalogue
{
    //Class that acts as a .env holding configuration constants
    //Variables declared as static to allow them to be used without instantizing the 'Global' Class
    //This shouldnt be in the Github repo however ive included for the sake of testing and the assesment.
    static internal class Global
    {
        public static string filmsFilepath = "films.txt";
        public static string omdbApikey = "e0c10ffe";
        public static int rowsPerPage = 10;

        public static JsonSerializerOptions GetSerializerOptions()
        {
            JsonSerializerOptions serializerOptions = new JsonSerializerOptions();
            serializerOptions.PropertyNameCaseInsensitive = true;
            return serializerOptions;
        }
    }
}
