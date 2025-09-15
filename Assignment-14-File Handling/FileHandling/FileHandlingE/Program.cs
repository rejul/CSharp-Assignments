namespace FileHandlingE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask for source file path
            Console.Write("Enter the full path of the source file: ");
            string sourceFile = Console.ReadLine();

            // Check if source file exists
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Ask for destination folder
            Console.Write("Enter the destination folder path: ");
            string destFolder = Console.ReadLine();

            // Check if destination folder exists
            if (!Directory.Exists(destFolder))
            {
                Console.WriteLine("Destination folder does not exist.");
                return;
            }

            try
            {
                // Get the file name from the source path
                string fileName = Path.GetFileName(sourceFile);

                // Combine destination folder and file name
                string destFile = Path.Combine(destFolder, fileName);

                // Copy the file
                File.Copy(sourceFile, destFile, overwrite: true); // overwrite if exists
                Console.WriteLine($"File copied successfully to: {destFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while copying file: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
