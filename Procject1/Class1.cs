using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Procject1
{
    [Serializable]
    public class SearchException : Exception
    {
        public SearchException() { }
        public SearchException(string message) : base(message) { }
        public SearchException(string message, Exception inner) : base(message, inner) { }
       
    }
}
