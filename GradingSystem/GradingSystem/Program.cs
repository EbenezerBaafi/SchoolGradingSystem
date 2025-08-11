
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


            string inputFilePath = "C:/Users/Gadget Store/Desktop/csharp/example.txt"; // Path to the input file
            string outputFilePath = "report.txt"; // Path to the output file

            StudentResultProcessor processor = new StudentResultProcessor();

            try
            {
                // Read students from the input file
                var students = processor.ReadStudentsFromFile(inputFilePath);
                processor.WriteReportToFile(students, outputFilePath);
                Console.WriteLine("Report generated successfully!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            catch (MisiingFieldException ex)
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

