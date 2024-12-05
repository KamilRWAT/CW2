namespace Dziedziczenie
{
    public partial class FormStartowy : Form
    {
        List<Zwierze> Zwierzeta = new List<Zwierze>();

        public FormStartowy()
        {
            InitializeComponent();
            Pies pies = new Pies
            {
                Nazwa = "Reksio",
                Gatunek = "Pies",
                Rasa = "Samojed",
                Wiek = 1,
                Waga = 5
            };
            Zwierzeta.Add(pies);

            Kot kot = new Kot();
            kot.Nazwa = "Filemon";
            kot.Gatunek = "Kot";
            kot.Wiek = 2; 
            kot.Waga = 3;
            Zwierzeta.Add(kot);

            Owczarek_Niemiecki owczarek_Niemiecki = new Owczarek_Niemiecki();
            Zwierzeta.Add(owczarek_Niemiecki);
        }

        private void btnWyswietl_Click(object sender, EventArgs e)
        {
            foreach (var zwierze in Zwierzeta)
            {
                if(zwierze is Pies)
                {
                    Pies pies = (Pies)zwierze;
                    MessageBox.Show($"{pies.Rasa} wydaje dŸwiêk {pies.DajGlos()}");
                }
                else
                {
                    //string glos = zwierze.DajGlos();
                    MessageBox.Show($"{zwierze.Gatunek} wydaje dŸwiêk {zwierze.DajGlos()}");
                }
            }
        }
    }
}
