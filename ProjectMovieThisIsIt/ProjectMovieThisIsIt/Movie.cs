using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ProjectMovieThisIsIt
{
    [Serializable]

    public class Movie : IComparable, ICloneable
    {
        int idMovie;
        string name;
        int year;
        string director;
        double avgRate;
        int numberOfRates;
        string description;

        public int IdMovie
        {
            get
            {
                return idMovie;
            }
            set
            {
                if (checkIdMovie(value))
                {
                    idMovie = value;

                }
                else
                {
                    throw new idMovieException("Numer id musi być większy od 0");

                }


            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (checkName(value))
                {
                    name = value;

                }
                else
                {
                    throw new NameException("Tytuł filmy musi być dłuższy niż 2 znaki!");

                }


            }

        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (checkYear(value))
                {
                    year = value;

                }
                else
                {
                    throw new YearException("Pierwszy film został nakręcony 1895 roku!");

                }


            }
        }
        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                if (checkDirector(value))
                {
                    director = value;

                }
                else
                {
                    throw new DirectorException("Wprowadź co najmniej 5 znaków!");

                }


            }
        }
        public double AvgRate { get => avgRate; set => avgRate = value; }
        public int NumberOfRates { get => numberOfRates; set => numberOfRates = value; }
        public string Description { get => description; set => description = value; }

        public bool checkIdMovie(int idMovie)
        {
            if (idMovie <= 0)
                return false;
            else
                return true;
        }

        public bool checkName(string name)
        {
            if (name.Length >= 1)
                return true;
            else
                return false;
        }

        public bool checkYear(int year)
        {
            if (year >= 1895)
                return true;
            else
                return false;
        }

        public bool checkDirector(string director)
        {
            if (director.Length >= 5)
                return true;
            else
                return false;
        }
        public Movie() { }

        public Movie(int idMovie, string name, int year, string director, double avgRate, int numberOfRates, string description)
        {
            IdMovie = idMovie;
            Name = name;
            Year = year;
            Director = director;
            AvgRate = avgRate;
            NumberOfRates = numberOfRates;
            Description = description;
        }


        public int CompareTo(object o)
        {
            if (o != null)
            {
                Movie c = (Movie)o;
                int cmp = this.Name.CompareTo(c.Name);
                if (cmp != 0)
                    return cmp;
                else
                    return this.Year.CompareTo(c.Year);
            }
            else
                return 1;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
