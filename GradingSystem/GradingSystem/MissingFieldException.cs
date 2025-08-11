using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class MissingFieldException : Exception
    {
        public MissingFieldException()
            : base("A required field is missing. Please ensure all fields are filled out correctly.")
        {
        }
        public MissingFieldException(string message)
            : base(message)
        {
        }
        public MissingFieldException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
