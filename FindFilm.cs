using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpSubmissionFilmCatalogue
{
    public partial class FindFilm : Form
    {
        public FindFilm()
        {
            InitializeComponent();
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //Get the inputted film name
            string filmName = tbFilmName.Text;

            //Make request to OMDB's API
            string apiCall = await new OMDBAPI().SetQuery(filmName).Fetch();

            //Create options for the JSON Serializer so it can deserialize the returnt API call into the type 'Film'
            var options = new JsonSerializerOptions();
            //API is not operated by myself as such its subject to change so this options property helps prevent some errors from minor
            //Changes to the API
            options.PropertyNameCaseInsensitive = true;

            try
            {
                Film filmObj = JsonSerializer.Deserialize<Film>(apiCall, options);

                Film.AddNewFilmToFile(Global.filmsFilepath, filmObj);

                lblFilmName.Text = filmObj.Title;
                lblDescription.Text = filmObj.Plot;
                lblDirector.Text = filmObj.Director;
                lblGenre.Text = filmObj.Genre;
                lblReleased.Text = filmObj.Released;
                lblWriters.Text = filmObj.Writer;
                lblRunTime.Text = filmObj.Runtime;
                lblYear.Text = filmObj.Year;
                lblActors.Text = filmObj.Actors;
                lblLanguage.Text = filmObj.Language;
                lblCountry.Text = filmObj.Country;
                lblAwards.Text = filmObj.Awards;
                lblImdbRating.Text = filmObj.ImdbRating;
                lblMetascore.Text = filmObj.Metascore;
                lblWebsite.Text = filmObj.Website;
                lblDvd.Text = filmObj.Dvd;
                lblBoxOffice.Text = filmObj.BoxOffice;
                lblImdbVotes.Text = filmObj.ImdbVotes;
                lblType.Text = filmObj.Type;
            }
            catch
            {
                Console.WriteLine(apiCall);
                lblDescription.Text = $"Couldnt Find Your Film {filmName}. We are sorry for any inconvience this may have caused";
            }
        }
    }
}
