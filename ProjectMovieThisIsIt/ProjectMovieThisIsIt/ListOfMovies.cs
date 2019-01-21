using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectMovieThisIsIt
{
    public partial class ListOfMovies : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        public ListOfMovies()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.myListView.ListViewItemSorter = lvwColumnSorter;
            CreateComponents();
            PopulateData();
            SetUpEventHandlers();
        }
        // Create an instance of a ListView column sorter and assign it 
        // to the ListView control.

        LoM movies = new LoM();
        List<Movie> lista = new List<Movie>
                {
            new Movie(1, "Bękarty Wojny", 2009, "Quentinn Tarantino", 8.0, 313, "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera." ),
            new Movie(2, "Pulp Fiction", 1994, "Quentinn Tarantino", 8.4, 204, "Przemoc i odkupienie w opowieści o dwóch płatnych mordercach pracujących na zlecenie mafii, żonie gangstera, bokserze i parze okradającej ludzi w restauracji."),
            new Movie(3, "Batman : Początek", 2005, "Christopher Nolan", 7.6, 103, "Historia milionera Bruce'a Wayne'a, który przemienia się w Batmana – postrach przestępców Gotham City."),
            new Movie(4, "Ojciec Chrzestny", 1972, "Francis Ford Coppola", 8.59, 400, "Opowieść o nowojorskiej rodzinie mafijnej. Starzejący się Don Corleone pragnie przekazać władzę swojemu synowi."),
            new Movie(5, "Skazani na Shawshank", 1994, "Frank Darabont", 8.75, 678, "Adaptacja opowiadania Stephena Kinga. Niesłusznie skazany na dożywocie bankier, stara się przetrwać w brutalnym, więziennym świecie."),
            new Movie(6, "Zielona Mila", 1999, "Frank Darabont", 8.61, 123, "Emerytowany strażnik więzienny opowiada przyjaciółce o niezwykłym mężczyźnie, którego skazano na śmierć za zabójstwo dwóch 9-letnich dziewczynek."),
            new Movie(7, "Forest Gump", 1994, "Robert Zemeckis", 8.52, 342, "Historia życia Forresta, chłopca o niskim ilorazie inteligencji z niedowładem kończyn, który staje się miliarderem i bohaterem wojny w Wietnamie."),
            new Movie(8, "Fantastyczna Czwórka", 2015, "Josh Trank", 4.8, 576, "Podczas nieudanego eksperymentu czterech naukowców zyskuje nadludzkie umiejętności. Wykorzystują je, aby ocalić świat przed okrutnym tyranem."),
            new Movie(9, "Podziemny Krąg", 1999, "David Fincher", 9.26, 124, "Dwóch mężczyzn znudzonych rutyną zakłada klub, w którym co tydzień odbywają się walki na gołe pięści."),
            new Movie(10, "Piękny Umysł", 2001, "Ron Howard", 8.24, 898, "Geniusz matematyczny John Nash za wszelką cenę pragnie opracować teorię, dzięki której zostanie cenionym naukowcem. Przeszkodą staje się jego stopniowo rozwijająca choroba."),
            new Movie(11, "Incepcja", 2010, "Christopher Nolan", 8.23, 356, "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu"),
            new Movie(12, "Milczenie Owiec", 1991, "Jonathan Demme", 8.21, 786, "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary."),
            new Movie(13, "Król Lew", 1994, "Rob Minkoff", 8.2, 521, "Targany niesłusznymi wyrzutami sumienia po śmierci ojca mały lew Simba skazuje się na wygnanie, rezygnując z przynależnego mu miejsca na czele stada."),
            new Movie(14, "Django", 2012, "Quentinn Tarantino", 8.21, 765, "Łowca nagród Schultz i czarnoskóry niewolnik Django wyruszają w podróż, aby odbić żonę tego drugiego z rąk bezlitosnego Calvina Candie'ego."),
            new Movie(15, "Leon Zawodowiec", 1994, "Luc Besson", 8.11, 637, "Płatny morderca ratuje dwunastoletnią dziewczynkę, której rodzina została zabita przez skorumpowanych policjantów"),
            new Movie(16, "Gladiator", 2000, "Ridley Scott", 8.08, 357, "Generał Maximus - prawa ręka cesarza, szczęśliwy mąż i ojciec - w jednej chwili traci wszystko. Jako niewolnik-gladiator musi walczyć na arenie o przeżycie."),
            new Movie(17, "Prestiż", 2006, "Christopher Nolan", 8.06, 825, "Dwaj młodzi iluzjoniści żyją w przyjaznych stosunkach. Gdy ginie żona jednego z nich, mężczyźni stają się śmiertelnymi wrogami"),
            new Movie(18, "Zaginiona Dziewczyna", 2014, "David Fincher", 7.8, 678, "Po przeprowadzce Amy i Nick przeżywają kryzys. Gdy w dniu rocznicy ślubu kobieta znika bez śladu, jej mąż staje się głównym podejrzanym."),
            new Movie(19, "Film o pszczołach", 2007, "Steve Hickner", 6.4, 167, "Niepozorna pszczoła postanawia położyć kres wyzyskiwaniu swojego gatunku przez ludzkość i rozpoczyna sądową batalię z handlującymi miodem korporacjami."),
            new Movie(20, "Zmierzch", 2008, "Catherina Hardwicke", 5.6, 846, "Adaptacja książki Stephenie Meyer. Nieśmiała i zagubiona nastolatka zakochuje się w wampirze."),
            new Movie(21, "Mgła", 2007, "Frank Darabont", 5.8, 728, "Adaptacja opowiadania Stephena Kinga. W gęstej i nieprzeniknionej mgle na ludzi zaczynają polować tajemnicze istoty."),
            new Movie(22, "Batman vs Superman : Świt Sprawiedliwości", 2016, "Zack Snyder", 5.9, 167, "W obliczu wielkiego zagrożenia Batman niechętnie łączy siły z Supermanem. Poza herosami do walki staje także wojownicza Wonder Woman."),
            new Movie(23, "Smoleńsk", 2016, "Antoni Krauze", 2.5, 748, "Młoda dziennikarka na własną rękę prowadzi dochodzenie w sprawie katastrofy smoleńskiej."),
            new Movie(24, "The Room", 2008, "Tommy Wiseau", 2.8, 903, "Życie poczciwego bankiera zostaje wywrócone do góry nogami w momencie, gdy jego narzeczona zaczyna się spotykać z ich najlepszym przyjacielem."),
            new Movie(25, "Dom Śmierci", 2003, "Uwe Boll", 2.7, 584, "Grupa przyjaciół przyjeżdża na imprezę. Wyspa, gdzie odbywa się przyjęcie, jest opanowana przez zombie."),
            new Movie(26, "50 Twarzy Greya", 2008, "Sam Taylor-Johnson", 4.5, 678, "Studentka literatury poznaje przystojnego miliardera, z którym zaczyna ją łączyć nietypowa więź.")
            };


        private void PopulateData()
        {

            foreach (Movie m in lista)
            {
                myListView.Items.Add(new ListViewItem(new[] { m.Name, m.Director, m.Year.ToString(), m.AvgRate.ToString(), m.NumberOfRates.ToString(), m.Description, m.IdMovie.ToString() }));
            }
        }

        private void SearchData(string searchTerm)
        {

            myListView.Items.Clear();
            foreach (Movie m in lista)
            {
                if (m.Name.ToLower().Contains(searchTerm.ToLower()) || m.Director.ToLower().Contains(searchTerm.ToLower()))
                {
                    myListView.Items.Add(new ListViewItem(new[] { m.Name, m.Director, m.Year.ToString(), m.AvgRate.ToString(), m.NumberOfRates.ToString(), m.Description, m.IdMovie.ToString() }));
                }
            }
        }

        private void SetUpEventHandlers()
        {
            myListView.ItemSelectionChanged += MyListView_ItemSelectionChanged;
            searchTxt.TextChanged += SearchTxt_TextChanged;

        }


        private void MyListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                Choice.Text = "Wybrałeś film : ";
                label1.Text = "Tytuł : ";
                label2.Text = myListView.SelectedItems[0].SubItems[0].Text;
                label4.Text = "Reżyser : ";
                label3.Text = myListView.SelectedItems[0].SubItems[1].Text;
                label12.Text = "Ocena : ";
                label11.Text = myListView.SelectedItems[0].SubItems[3].Text;
                label6.Text = "Liczba głosów: ";
                label5.Text = myListView.SelectedItems[0].SubItems[4].Text;
                label7.Text = "Opis filmu : ";
                label8.Text = myListView.SelectedItems[0].SubItems[5].Text;


                ThanksForVoting.Text = "";

                myRatecomboBox.Visible = true;
            }
        }



        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            SearchData(searchTxt.Text);
        }



        private void CreateComponents()
        {
            przywitanie.Text = "Witaj ";

        }



        public double AddRate()
        {
            double a = Convert.ToDouble(myListView.SelectedItems[0].SubItems[3].Text);
            double b = Convert.ToDouble(myListView.SelectedItems[0].SubItems[4].Text);
            int bi = Convert.ToInt32(myListView.SelectedItems[0].SubItems[4].Text);
            double c = Convert.ToDouble(myRatecomboBox.SelectedItem);
            a = (a * b + c) / (b + 1.0);
            a = Math.Round(a, 2);
            string aAsString = string.Format("{0:0.00}", a);
            return a;
        }

        public int PlusPlus()
        {
            int bi = Convert.ToInt32(myListView.SelectedItems[0].SubItems[4].Text);
            bi++;
            return bi;

        }



        private void myRatecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = AddRate().ToString();
            double eeee = Convert.ToDouble(label11.Text);
            eeee = Math.Round(eeee, 2);
            label11.Text = eeee.ToString();
            myListView.SelectedItems[0].SubItems[3].Text = eeee.ToString();
            label5.Text = PlusPlus().ToString();
            myRatecomboBox.Visible = false;
            ThanksForVoting.Text = "Dziękujemy za oddanie głosu! ;) ";

            foreach (Movie m in lista)//nie działa a powinno 
            {
                if (myListView.SelectedItems[0].SubItems[6].Text == m.IdMovie.ToString())
                    m.AvgRate = AddRate();
            }
        }

        private void myListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            myListView.Sort();
        }


    }
}
