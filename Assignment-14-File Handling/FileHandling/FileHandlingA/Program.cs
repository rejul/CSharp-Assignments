using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace FileHandlingA;
    public class Program
    {
        static void Main(string[] args)
        {
        ////Append a text to the existing text in a file. Other files should be  
        //able to interact with this file only in the Read Mode while your
        //application is interacting with the file. 
            string path = "log.txt";
            string textToAppend = "This is new appended line at " + DateTime.Now;

            // Open file for append with read-sharing (others can read, but not write)
            using (FileStream fs = new FileStream(path,
                                                  FileMode.Append,
                                                  FileAccess.Write,
                                                  FileShare.Read))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(textToAppend);
                }
            }

            Console.WriteLine("Text appended successfully. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
