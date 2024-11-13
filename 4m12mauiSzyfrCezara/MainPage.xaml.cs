namespace _4m12mauiSzyfrCezara
{
    public partial class MainPage : ContentPage
    {
        private static int klucz = 0;
        private static string alfabet = "abcdefghijklmnopqrstuvwxyz";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSzyfruj(object sender, EventArgs e)
        {
            klucz = int.Parse(entKlucz.Text);
            entZaszyfrowany.Text = szyfruj(entJawny.Text, klucz);
        }
        private void btnOdszyfruj(object sender, EventArgs e)
        {
            klucz = int.Parse(entKlucz.Text);
            lblOdszyfrowany.Text = szyfruj(entZaszyfrowany.Text, alfabet.Length - klucz);
        }
        private string szyfruj(string tekst, int klucz)
        {
            string wynik = "";
            foreach (var c in tekst)
            {
                int poz = alfabet.IndexOf(c);
                if (poz == -1)
                {
                    wynik += c;
                    continue;
                }
                poz = (poz + klucz) % alfabet.Length;
                wynik += alfabet[poz];
            }

            return wynik;
        }


    }

}
