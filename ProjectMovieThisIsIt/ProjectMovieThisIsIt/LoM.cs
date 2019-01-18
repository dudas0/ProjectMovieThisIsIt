using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace ProjectMovieThisIsIt
{
    [Serializable]
    public class LoM : ICloneable
    {

        List<Movie> lista = new List<Movie>();

        public LoM() { }

        public List<Movie> Lista { get => lista; set => lista = value; }




        public void Dodaj(Movie m)
        {
            Lista.Add(m);
        }

        public void Sortuj()
        {
            Lista.Sort();
        }

        public void SortujPoOcenie()
        {
            Lista.Sort(new RATEComparator());
        }

        public static void ZapiszJSON(string nazwaPliku, LoM l)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(LoM));
            //StreamWriter writer = new StreamWriter(nPliku);
            using (var fstream = File.Create(nazwaPliku))
            {
                jsonSerializer.WriteObject(fstream, l);
            }
        }
        public static LoM OdczytajJSON(string nazwaPliku)
        {
            // Deserializacja JSON
            try
            {
                FileStream fstream = new FileStream(nazwaPliku, FileMode.Open);
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(LoM));
                fstream.Position = 0;
                LoM l = (LoM)jsonSerializer.ReadObject(fstream);
                fstream.Close();
                return l;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik {0} nie istnieje!!!", nazwaPliku);
            }
            return null;
        }

        public object Clone()
        {
            LoM klon = this.MemberwiseClone() as LoM;
            klon.Lista = new List<Movie>();

            foreach (Movie m in Lista)
            {
                klon.Lista.Add(m.Clone() as Movie);

            }


            return klon;
        }

    }

    class RATEComparator : IComparer<Movie>
    {
        public int Compare(Movie a, Movie b)
        {
            if (a != null && b != null)
                return a.AvgRate.CompareTo(b.AvgRate);
            else
                return 0;
        }
    }
}
