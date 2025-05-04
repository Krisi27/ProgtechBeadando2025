using NLog;

namespace Konyvtar_Rendszer_Kezeles
{
    public partial class Kezdőlap : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public Kezdőlap()
        {
            InitializeComponent();
            Logger.Info("A program elindult.");
        }

        private void tovabb_Click(object sender, EventArgs e)
        {
            Logger.Info("A program tovább lépett a rendszerbe.");

            Bejelentkezés bejelentkezes = new Bejelentkezés();
            bejelentkezes.Show();
            this.Hide();
        }
    }
}
