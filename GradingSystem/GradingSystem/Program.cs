
namespace GradingSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("---School Grading System-------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\nWelcome to the School Grading System!");


            string inputFilePath = "C:\\Users\\GADGET STORE\\source\\repos\\SchoolGradingSystem\\GradingSystem\\GradingSystem\\Students.txt"; // Path to the input file
            string outputFilePath = "C:\\Users\\GADGET STORE\\source\\repos\\SchoolGradingSystem\\GradingSystem\\GradingSystem\\Report.txt"; // Path to the output file

            StudentResultProcessor processor = new StudentResultProcessor();

            try
            {
                // Read students from the input file
                var students = processor.ReadStudentsFromFile(inputFilePath);
                Console.WriteLine($"Number of students read: {students.Count}"); // Add this line


                // write the report to the output file
                processor.WriteReportToFile(students, outputFilePath);
                Console.WriteLine($"Report generated successfully: {outputFilePath}\n");

                // Display the report
                Console.WriteLine("Student Report:");
                string reportContent = File.ReadAllText(outputFilePath);
                Console.WriteLine($"Report content legth: {reportContent.Length}");
                Console.WriteLine(reportContent);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (MissingFieldException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (InvalidScoreFormatException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Processing complete.");
            }

        }
    }
}

