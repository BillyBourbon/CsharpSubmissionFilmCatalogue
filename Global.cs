
using System.Text.Json;

namespace CsharpSubmissionFilmCatalogue
{
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
