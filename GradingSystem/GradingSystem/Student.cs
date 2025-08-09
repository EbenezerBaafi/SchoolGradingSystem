using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class Student
    {
        #region fields
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Score { get; set; }

        #endregion fields

        #region constructors
        public Student(int id, string fullName, int score)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Score = score;
        }
        #endregion constructors

        #region methods
        public string GetGrade()
        {
            if (Score >= 80 && Score <= 100)
            {
                return "A";
            }
            else if (Score >= 70 && Score <= 79)
            {
                return "B";
            }
            else if (Score >= 60 && Score <= 69)
            { 
                return "C"; 
            }

            else if (Score >= 50 && Score <= 59)
            { 
                return "D"; 
            }
            else if (Score >= 0 && Score <= 49)
            { 
                return "E"; 
            }
            else
            { 
                return "Invalid Score"; 
            }

        }

        #endregion

    }
}
