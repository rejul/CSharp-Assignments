namespace FileHandlingB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Retrieve five characters starting from the third character and 
            //display it in a console

            string path = "sample.txt";

            //To Create the file and add some random text
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "HelloWorld");
                Console.WriteLine("File not found. Created sample.txt with default content.");
            }

            using (StreamReader reader = new StreamReader(path))
            {
                // Skip first 2 characters
                reader.Read();
                reader.Read();

                // Read next 5 characters
                char[] buffer = new char[5];
                int readCount = reader.Read(buffer, 0, 5);

                Console.WriteLine("Extracted text: " + new string(buffer, 0, readCount));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
