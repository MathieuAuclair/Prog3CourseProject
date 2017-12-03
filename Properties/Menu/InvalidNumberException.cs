
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinalProject.Properties.Menu
{
    [Serializable]
    class InvalidNumberException : Exception
    {
        public InvalidNumberException()
        {

        }

        public InvalidNumberException(string nb)
        : base(String.Format("Ceci n'est pas un nombre acceptable: {0}", nb))
    {

        }

    }

}