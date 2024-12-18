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
            string filmName = tbFilmName.Text;
            string apiCall = await new OMDBAPI().QueryString(filmName).Fetch();

            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;

            try
            {
                Film filmObj = JsonSerializer.Deserialize<Film>(apiCall, options);

                Film.AddNewFilmToFile("films.txt", filmObj);

                lblFilmName.Text = filmObj.title;
                lblDescription.Text = filmObj.plot;
                lblDirector.Text = filmObj.director;
                lblGenre.Text = filmObj.genre;
                lblReleased.Text = filmObj.released;
                lblWriters.Text = filmObj.writer;
                lblRunTime.Text = filmObj.runtime;
                lblYear.Text = filmObj.year;
                lblActors.Text = filmObj.actors;
                lblLanguage.Text = filmObj.language;
                lblCountry.Text = filmObj.country;
                lblAwards.Text = filmObj.awards;
                lblImdbRating.Text = filmObj.imdbRating;
                lblMetascore.Text = filmObj.metascore;
                lblWebsite.Text = filmObj.website;
                lblDvd.Text = filmObj.dvd;
                lblBoxOffice.Text = filmObj.boxOffice;
                lblImdbVotes.Text = filmObj.imdbVotes;
                lblType.Text = filmObj.type;
            }
            catch
            {
                Console.WriteLine(apiCall);
                lblDescription.Text = $"Couldnt Find Your Film {filmName}. We are sorry for any inconvience this may have caused";
            }
        }
    }
}
