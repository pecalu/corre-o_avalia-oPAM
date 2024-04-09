namespace avaliacaoPAM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void rolarDados(object sender, EventArgs e)
        {

            int selectSides = Convert.ToInt32(SidesPicker.SelectedItem);
            Random random = new Random();
            int DrawnNumber = random.Next(1, selectSides+1);
            ValorSorteado.Text = DrawnNumber.ToString();
        }
    }

}
