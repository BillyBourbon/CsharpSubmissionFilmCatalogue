
namespace CsharpSubmissionFilmCatalogue
{
    //Provides the details of a film
    public partial class FilmDetails : Form
    {
        public FilmDetails()
        {
            InitializeComponent();
            LoadFilmDetails();
        }
        private void LoadFilmDetails()
        {
            Film film = ViewFilms.selectedFilm;

            film.Ratings.ToList().ForEach(rating => dgvRatingsFilmDetails.Rows.Add([rating.Source, rating.Value]));

            lblActorsFilmDetails.Text = film.Actors;
            lblAwardsFilmDetails.Text = film.Awards;
            lblBoxOfficeFilmDetails.Text = film.BoxOffice;
            lblCountryFilmDetails.Text = film.Country;
            lblDescription.Text = film.Plot;
            lblDirectorFilmDetails.Text = film.Director;
            lblDvdFilmDetails.Text = film.Dvd;
            lblFilmNameFilmDetails.Text = film.Title;
            lblGenreFilmDetails.Text = film.Genre;
            lblImdbRatingFilmDetails.Text = film.ImdbRating;
            lblImdbVotesFilmDetails.Text = film.ImdbVotes;
            lblLanguageFilmDetails.Text = film.Language;
            lblMetascoreFilmDetails.Text = film.Metascore;
            lblReleasedFilmDetails.Text = film.Released;
            lblRunTimeFilmDetails.Text = film.Runtime;
            lblTypeFilmDetails.Text = film.Type;
            lblWebsiteFilmDetails.Text = film.Website;
            lblWritersFilmDetails.Text = film.Writer;
            lblYearFilmDetails.Text = film.Year;
        }

        //Reset selected film when form is closed
        private void FilmDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewFilms.selectedFilm = new Film();
        }
    }
}
