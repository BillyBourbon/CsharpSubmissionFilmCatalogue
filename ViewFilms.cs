
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CsharpSubmissionFilmCatalogue
{
    public partial class ViewFilms : Form
    {
        //Empty List of Films to act as Cache
        private List<Film> filmList = new List<Film>();
        //Default page to show
        private int page = 1;
        //Public static variable so it may be passed into another form without needing to instantiate this class
        public static Film selectedFilm = new Film();
        public ViewFilms()
        {
            InitializeComponent();
            //On Form Open load films previously search and subsequently stored
            LoadFilms();
        }

        private void LoadFilms()
        {
            string filmsFile = Film.LoadFileAsString(Global.filmsFilepath);
            List<Film> filmsList = new List<Film>();

            filmsFile.Split("\n").ToList().ForEach(film =>
            {
                if (film != null && film != "" && JsonSerializer.Deserialize<Film>(film, Global.GetSerializerOptions()).Response == "True")
                {
                    filmsList.Add(JsonSerializer.Deserialize<Film>(film, Global.GetSerializerOptions()));
                }
            });
            //Sort stored films by FilmTitle order A -> Z
            List<Film> sortedfilmsList = filmsList.OrderBy(film => film.Title).ToList();

            //Set(Cache essentially) the 'filmList' to save needing to read the file each time the user selects a different film
            filmList = sortedfilmsList;
            
            DisplayFilms(sortedfilmsList, page);
        }
        private void DisplayFilms(List<Film> sortedFilmList, int page)
        {
            //Clear old rows that may be present in the DataGridView
            dgvFilmsView.Rows.Clear();

            //Create rows from the List of 'Films' returning a simple overview [FilmTitle, FilmReleaseYear, FilmGenre, FilmDirector, FilmType]
            //Add a range of rows (1,Global.rowsPerPage) to the DataGridView
            sortedFilmList.GetRange((page - 1) * Global.rowsPerPage, sortedFilmList.Count - ((page - 1) * Global.rowsPerPage) > Global.rowsPerPage ? Global.rowsPerPage : sortedFilmList.Count - (page - 1) * Global.rowsPerPage).ForEach(film => dgvFilmsView.Rows.Add([film.Title, film.Year, film.Genre, film.Director, film.Type]));
        }

        private void dgvFilmsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Variable 'e' refers to the cell clicked by the user inside the DataGridView
            var cells = dgvFilmsView.Rows[e.RowIndex].Cells;
            Film clickedFilm = filmList.Find(film => film.Title == cells[0].Value && film.Type == cells[4].Value);
            if (clickedFilm == null) return;

            //Set selected film so its value may be passed into the Form 'FilmDetails' 
            selectedFilm = clickedFilm;
            Form filmDetailsForm = new FilmDetails();
            filmDetailsForm.ShowDialog();
        }

        private void btnPageRightViewFilms_Click(object sender, EventArgs e)
        {
            //Ensure the table pages up (+1 page, + 1 to 10 new rows in dgv) only if theres rows left to show. prevents errors
            int filmListLength = filmList.Count;
            if (filmListLength % Global.rowsPerPage > 0) filmListLength = ((filmListLength / Global.rowsPerPage)+1);
            if ((page + 1) > filmListLength) return;
            DisplayFilms(filmList, page += 1);
        }

        private void btnPageLeftViewFilms_Click(object sender, EventArgs e)
        {
            //Ensure the table pages down(-1 page, +10 old rows in dgv) only if theres rows that have been paged past. prevents errors
            if (page - 1 < 1) return;
            DisplayFilms(filmList, page -= 1);
        }
    }
}
