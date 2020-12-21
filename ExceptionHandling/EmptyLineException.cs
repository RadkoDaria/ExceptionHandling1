using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class EmptyLineException : Exception
    {
        public EmptyLineException(string message) : base(message)
        { }
    }
}
