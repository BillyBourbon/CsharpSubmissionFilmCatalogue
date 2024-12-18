using System.Net.Http;
using System.Net.Http.Headers;

namespace CsharpSubmissionFilmCatalogue
{
    internal class OMDBAPI
    {
        private List<string> paramaters = new List<string>();
        private string query;
        private readonly string apikey = "e0c10ffe"; //Remeber it should be stored in an .env or equivilent however your leaving in plain text for assesment
        private readonly HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://www.omdbapi.com/")
        };

        public void Type(string type)
        {
            this.paramaters.Clear();
            this.paramaters.Add(type);
        }

        public OMDBAPI QueryString(string queryString)
        {
            this.query = String.Join("+", queryString.Split(" "));
            return this;
        }

        public async Task<string> Fetch()
        {
            string response = "";
            try
            {
                var call = await httpClient.GetStringAsync($"?apikey={this.apikey}&t=${this.query}");
                response = call;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }
    }
}