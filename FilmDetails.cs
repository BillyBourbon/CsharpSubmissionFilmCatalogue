
namespace CsharpSubmissionFilmCatalogue
{
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
            Console.WriteLine(film);

            film.ratings.ToList().ForEach(rating => dgvRatingsFilmDetails.Rows.Add([rating.source, rating.value]));

            lblActorsFilmDetails.Text = film.actors;
            lblAwardsFilmDetails.Text = film.awards;
            lblBoxOfficeFilmDetails.Text = film.boxOffice;
            lblCountryFilmDetails.Text = film.country;
            lblDescription.Text = film.plot;
            lblDirectorFilmDetails.Text = film.director;
            lblDvdFilmDetails.Text = film.dvd;
            lblFilmNameFilmDetails.Text = film.title;
            lblGenreFilmDetails.Text = film.genre;
            lblImdbRatingFilmDetails.Text = film.imdbRating;
            lblImdbVotesFilmDetails.Text = film.imdbVotes;
            lblLanguageFilmDetails.Text = film.language;
            lblMetascoreFilmDetails.Text = film.metascore;
            lblReleasedFilmDetails.Text = film.released;
            lblRunTimeFilmDetails.Text = film.runtime;
            lblTypeFilmDetails.Text = film.type;
            lblWebsiteFilmDetails.Text = film.website;
            lblWritersFilmDetails.Text = film.writer;
            lblYearFilmDetails.Text = film.year;

        }

        private void FilmDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewFilms.selectedFilm = new Film();
        }
    }
}
