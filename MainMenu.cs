namespace CsharpSubmissionFilmCatalogue
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnFindFilm_Click(object sender, EventArgs e)
        {
            Form findActor = new FindFilm();
            findActor.ShowDialog();
        }

        private void btnViewFilmDB_Click(object sender, EventArgs e)
        {
            Form viewFilms = new ViewFilms();
            viewFilms.ShowDialog();
        }
    }
}
