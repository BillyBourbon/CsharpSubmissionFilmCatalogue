
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms.VisualStyles;

namespace CsharpSubmissionFilmCatalogue
{
    public partial class ViewFilms : Form
    {
        private List<Film> filmList = new List<Film>();
        private int page = 1;
        public static Film selectedFilm = new Film();
        public ViewFilms()
        {
            InitializeComponent();
            LoadFilms();
        }

        private void LoadFilms()
        {
            string filmsFile = Film.LoadFileAsString(Global.filmsFilepath);
            List<Film> filmsList = new List<Film>();

            filmsFile.Split("\n").ToList().ForEach(film =>
            {
                if (film != null && film != "" && JsonSerializer.Deserialize<Film>(film, Global.GetSerializerOptions()).response == "True")
                {
                    filmsList.Add(JsonSerializer.Deserialize<Film>(film, Global.GetSerializerOptions()));
                }
            });
            List<Film> sortedfilmsList = filmsList.OrderBy(film => film.title).ToList();
            filmList = sortedfilmsList;
            DisplayFilms(sortedfilmsList, page);
        }
        private void DisplayFilms(List<Film> sortedFilmList, int page)
        {
            dgvFilmsView.Rows.Clear();
            sortedFilmList.GetRange((page - 1) * Global.rowsPerPage, sortedFilmList.Count - ((page - 1) * Global.rowsPerPage) > Global.rowsPerPage ? Global.rowsPerPage : sortedFilmList.Count - (page - 1) * Global.rowsPerPage).ForEach(film => dgvFilmsView.Rows.Add([film.title, film.year, film.genre, film.director, film.type]));
        }

        private void dgvFilmsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgvFilmsView.Rows[e.RowIndex].Cells;

            Film clickedFilm = filmList.Find(film => film.title == cells[0].Value && film.type == cells[4].Value);
            if (clickedFilm == null) return;

            selectedFilm = clickedFilm;
            Form filmDetailsForm = new FilmDetails();
            filmDetailsForm.ShowDialog();
        }

        private void btnPageRightViewFilms_Click(object sender, EventArgs e)
        {
            int filmListLength = filmList.Count;
            if (filmListLength % Global.rowsPerPage > 0) filmListLength = ((filmListLength / Global.rowsPerPage)+1);
            if ((page + 1) > filmListLength) return;
            DisplayFilms(filmList, page += 1);
        }

        private void btnPageLeftViewFilms_Click(object sender, EventArgs e)
        {
            if (page - 1 < 1) return;
            DisplayFilms(filmList, page -= 1);
        }
    }
}
