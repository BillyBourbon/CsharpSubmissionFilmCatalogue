namespace CsharpSubmissionFilmCatalogue
{
    //Entry point of the application allowing the user to select what to do
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnFindFilm_Click(object sender, EventArgs e)
        {
            Form findFilm = new FindFilm();
            findFilm.ShowDialog();
        }

        private void btnViewFilmDB_Click(object sender, EventArgs e)
        {
            Form viewFilms = new ViewFilms();
            viewFilms.ShowDialog();
        }
    }
}
