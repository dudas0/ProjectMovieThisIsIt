using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieThisIsIt
{
    class DirectorException : Exception
    {
        public DirectorException()
        {

        }
        public DirectorException(string message) : base(message)
        {

        }
    }
}