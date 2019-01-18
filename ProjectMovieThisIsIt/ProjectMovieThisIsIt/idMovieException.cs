using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieThisIsIt
{
    class idMovieException : Exception
    {
        public idMovieException()
        {

        }
        public idMovieException(string message) : base(message)
        {

        }

    }
}
