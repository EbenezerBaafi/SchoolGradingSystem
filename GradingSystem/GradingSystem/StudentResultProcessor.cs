using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    public class StudentResultProcessor
    {
        public   List<Student> ReadStudentsFromFile(string inputFilePath) 
        {
            var students = new List<Student>();

            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                string line;
                int LineNumber = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    LineNumber++;
                    string[] parts = line.Split(',');

                    // validate the number of fields
                    if (parts.Length != 3)
                    {
                        throw new MissingFieldException($"Line {LineNumber}: Expected 3 fields but found {parts.Length}.");
                    }

                    string Id = parts[0].Trim();
                    string FullName = parts[1].Trim();
                    string Score = parts[2].Trim();

                    // Try converting Id and Score to integers
                    if (!int.TryParse(Id, out int id))
                    {
                        throw new InvalidScoreFormatException($"Line {LineNumber}: Invalid score format for '{Score}'. Must be an integer.");
                    }


                    // Try converting Score to an integer
                    if (!int.TryParse(Score, out int score) || score < 0 || score > 100)
                    {
                        throw new InvalidScoreFormatException($"Line {LineNumber}: Invalid score format for '{Score}'. Must be an integer between 0 and 100.");
                    }

                    // Create a new Student object and add it to the list
                    var student = new Student(id, FullName, score);
                    students.Add(student);
                }
            }
            return students;
        }

        public  void WriteReportToFile(List<Student> students, string outputFilePath)
        {
            using (StreamWriter sw = new StreamWriter(outputFilePath))
            {
                foreach (var student in students) 
                {
                    sw.WriteLine ($"{student.Id}, {student.FullName}, {student.Score}, {student.GetGrade()}");
                    
                }
            }
        }
    }
}
