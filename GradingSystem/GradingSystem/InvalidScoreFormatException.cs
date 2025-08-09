using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class InvalidScoreFormatException : Exception
    {
        public InvalidScoreFormatException()
            : base("The score format is invalid. Please ensure the score is a valid number between 0 and 100")
        {
        }
        public InvalidScoreFormatException(string message)
            : base(message)
        {
        }
        public InvalidScoreFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
