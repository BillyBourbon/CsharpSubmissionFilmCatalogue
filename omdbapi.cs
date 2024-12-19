using System.Net.Http;
using System.Net.Http.Headers;

namespace CsharpSubmissionFilmCatalogue
{
    //A class to interact with the external service OMDB's API to retrieve film and movie infomation
    internal class OMDBAPI
    {
        private List<string> paramaters = new List<string>();
        private string query = "";

        //Declared secret in 'Global.cs' to act like a .env containing config settings
        private readonly string apikey = Global.omdbApikey;
        private readonly HttpClient httpClient = new HttpClient()
        {
            //Set Base uri for the API being requested
            BaseAddress = new Uri("http://www.omdbapi.com/")
        };

        public OMDBAPI SetQuery(string queryString)
        {
            //API requires query strings with whitespace to be joined with the '+' char
            this.query = String.Join("+", queryString.Split(" "));

            //Return this to allow for chaining of the 'Fetch' method
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