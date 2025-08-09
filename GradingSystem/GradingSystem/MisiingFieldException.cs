using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class MisiingFieldException : Exception
    {
        public MisiingFieldException()
            : base("A required field is missing. Please ensure all fields are filled out correctly.")
        {
        }
        public MisiingFieldException(string message)
            : base(message)
        {
        }
        public MisiingFieldException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
