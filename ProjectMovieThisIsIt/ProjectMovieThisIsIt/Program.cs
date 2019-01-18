using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMovieThisIsIt
{
    static partial class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {

            LoM l1 = new LoM();
            l1.Dodaj(new Movie(1, "Bękarty Wojny", 2009, "Quentinn Tarantino", 8.0, 313, "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera."));
            l1.Dodaj(new Movie(1, "Bękarty Wojny", 2009, "Quentinn Tarantino", 8.0, 313, "W okupowanej przez nazistów Francji oddział złożony z Amerykanów żydowskiego pochodzenia planuje zamach na Hitlera."));
            l1.Dodaj(new Movie(2, "Pulp Fiction", 1994, "Quentinn Tarantino", 8.4, 204, "Przemoc i odkupienie w opowieści o dwóch płatnych mordercach pracujących na zlecenie mafii, żonie gangstera, bokserze i parze okradającej ludzi w restauracji."));
            l1.Dodaj(new Movie(3, "Batman : Początek", 2005, "Christopher Nolan", 7.6, 103, "Historia milionera Bruce'a Wayne'a, który przemienia się w Batmana – postrach przestępców Gotham City."));
            l1.Dodaj(new Movie(4, "Ojciec Chrzestny", 1972, "Francis Ford Coppola", 8.59, 400, "Opowieść o nowojorskiej rodzinie mafijnej. Starzejący się Don Corleone pragnie przekazać władzę swojemu synowi."));
            l1.Dodaj(new Movie(5, "Skazani na Shawnshang", 1994, "Frank Darabont", 8.75, 678, "Adaptacja opowiadania Stephena Kinga. Niesłusznie skazany na dożywocie bankier, stara się przetrwać w brutalnym, więziennym świecie."));
            l1.Dodaj(new Movie(6, "Zielona Mila", 1999, "Frank Darabont", 8.61, 123, "Emerytowany strażnik więzienny opowiada przyjaciółce o niezwykłym mężczyźnie, którego skazano na śmierć za zabójstwo dwóch 9-letnich dziewczynek."));
            l1.Dodaj(new Movie(7, "Forest Gump", 1994, "Robert Zemeckis", 8.52, 342, "Historia życia Forresta, chłopca o niskim ilorazie inteligencji z niedowładem kończyn, który staje się miliarderem i bohaterem wojny w Wietnamie."));
            l1.Dodaj(new Movie(8, "Fantastyczna Czwórka", 2015, "Josh Trank", 4.8, 576, "Podczas nieudanego eksperymentu czterech naukowców zyskuje nadludzkie umiejętności. Wykorzystują je, aby ocalić świat przed okrutnym tyranem."));
            l1.Dodaj(new Movie(9, "Podziemny Krąg", 1999, "David Fincher", 9.26, 124, "Dwóch mężczyzn znudzonych rutyną zakłada klub, w którym co tydzień odbywają się walki na gołe pięści."));
            l1.Dodaj(new Movie(10, "Piękny Umysł", 2001, "Ron Howard", 8.24, 898, "Geniusz matematyczny John Nash za wszelką cenę pragnie opracować teorię, dzięki której zostanie cenionym naukowcem. Przeszkodą staje się jego stopniowo rozwijająca choroba."));
            l1.Dodaj(new Movie(11, "Incepcja", 2010, "Christopher Nolan", 8.23, 356, "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu"));
            l1.Dodaj(new Movie(12, "Milczenie Owiec", 1991, "Jonathan Demme", 8.21, 786, "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary."));
            l1.Dodaj(new Movie(13, "Król Lew", 1994, "Rob Minkoff", 8.2, 521, "Targany niesłusznymi wyrzutami sumienia po śmierci ojca mały lew Simba skazuje się na wygnanie, rezygnując z przynależnego mu miejsca na czele stada."));
            l1.Dodaj(new Movie(14, "Django", 2012, "Quentinn Tarantino", 8.21, 765, "Płatny morderca ratuje dwunastoletnią dziewczynkę, której rodzina została zabita przez skorumpowanych policjantów"));
            l1.Dodaj(new Movie(15, "Leon Zawodowiec", 1994, "Luc Besson", 8.11, 637, "Generał Maximus - prawa ręka cesarza, szczęśliwy mąż i ojciec - w jednej chwili traci wszystko. Jako niewolnik-gladiator musi walczyć na arenie o przeżycie."));
            l1.Dodaj(new Movie(16, "Gladiator", 2000, "Ridley Scott", 8.08, 357, "Dwaj młodzi iluzjoniści żyją w przyjaznych stosunkach. Gdy ginie żona jednego z nich, mężczyźni stają się śmiertelnymi wrogami."));
            l1.Dodaj(new Movie(17, "Prestiż", 2006, "Christopher Nolan", 8.06, 825, "Po przeprowadzce Amy i Nick przeżywają kryzys. Gdy w dniu rocznicy ślubu kobieta znika bez śladu, jej mąż staje się głównym podejrzanym."));
            l1.Dodaj(new Movie(18, "Zaginiona Dziewczyna", 2014, "David Fincher", 7.8, 678, "Niepozorna pszczoła postanawia położyć kres wyzyskiwaniu swojego gatunku przez ludzkość i rozpoczyna sądową batalię z handlującymi miodem korporacjami."));
            l1.Dodaj(new Movie(19, "Film o pszczołach", 2007, "Steve Hickner", 6.4, 167, "Niepozorna pszczoła postanawia położyć kres wyzyskiwaniu swojego gatunku przez ludzkość i rozpoczyna sądową batalię z handlującymi miodem korporacjami."));
            l1.Dodaj(new Movie(20, "Zmierzch", 2008, "Catherina Hardwicke", 5.6, 846, "Adaptacja książki Stephenie Meyer. Nieśmiała i zagubiona nastolatka zakochuje się w wampirze."));
            l1.Dodaj(new Movie(21, "Mgła", 2007, "Frank Darabont", 5.8, 728, "Adaptacja opowiadania Stephena Kinga. W gęstej i nieprzeniknionej mgle na ludzi zaczynają polować tajemnicze istoty."));
            l1.Dodaj(new Movie(22, "Batman vs Superman : Świt Sprawiedliwości", 2016, "Zack Snyder", 5.9, 167, "W obliczu wielkiego zagrożenia Batman niechętnie łączy siły z Supermanem. Poza herosami do walki staje także wojownicza Wonder Woman."));
            l1.Dodaj(new Movie(23, "Smoleńsk", 2016, "Antoni Krauze", 2.5, 748, "Młoda dziennikarka na własną rękę prowadzi dochodzenie w sprawie katastrofy smoleńskiej."));
            l1.Dodaj(new Movie(24, "The Room", 2008, "Tommy Wiseau", 2.8, 903, "Życie poczciwego bankiera zostaje wywrócone do góry nogami w momencie, gdy jego narzeczona zaczyna się spotykać z ich najlepszym przyjacielem."));
            l1.Dodaj(new Movie(25, "Dom Śmierci", 2003, "Uwe Boll", 2.7, 584, "Grupa przyjaciół przyjeżdża na imprezę. Wyspa, gdzie odbywa się przyjęcie, jest opanowana przez zombie."));
            l1.Dodaj(new Movie(26, "50 Twarzy Greya", 2008, "Sam Taylor-Johnson", 4.5, 678, "Studentka literatury poznaje przystojnego miliardera, z którym zaczyna ją łączyć nietypowa więź."));

            LoM.ZapiszJSON("zapis.json", l1);
            LoM zjson = new LoM();
            zjson = (LoM)LoM.OdczytajJSON("zapis.json");

            LoM l2 = (LoM)l1.Clone();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }

    }

}


