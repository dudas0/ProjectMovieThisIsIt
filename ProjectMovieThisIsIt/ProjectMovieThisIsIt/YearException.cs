using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieThisIsIt
{
    class YearException : Exception
    {
        public YearException()
        {

        }
        public YearException(string message) : base(message)
        {

        }
    }
}