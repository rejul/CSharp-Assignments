namespace FileHandlingC
{
    public class Program
    {
        // Entity for CV
        public class Person
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Skills { get; set; }
            public string Education { get; set; }
            public string Experience { get; set; }
        }

        static void Main()
        {
            // File path for all CVs
            string filePath = "save.txt";

            // Sample entities
            List<Person> people = new List<Person>
        {
            new Person { Name = "Amal", Location = "Kochi", Skills = "C#, SQL, Networking", Education = "B.Tech Computer Science", Experience = "IT Support Intern" },
            new Person { Name = "Ammini", Location = "Trivandrum", Skills = "Python, AI", Education = "MSc Artificial Intelligence", Experience = "AI Developer" },
            new Person { Name = "Soju", Location = "Kollam", Skills = "Web Development, HTML, CSS, JS", Education = "B.Sc Computer Science", Experience = "Frontend Developer" }
        };

            // Open file for appending (creates file if it doesn't exist)
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                foreach (var person in people)
                {
                    string cvContent =
                        $"Curriculum Vitae\n" +
                        $"================\n\n" +
                        $"Name: {person.Name}\n" +
                        $"Location: {person.Location}\n\n" +
                        $"Education:\n{person.Education}\n\n" +
                        $"Skills:\n{person.Skills}\n\n" +
                        $"Experience:\n{person.Experience}\n\n" +
                        $"----------------------------------------\n\n";

                    writer.Write(cvContent);
                }
            }

            Console.WriteLine($"All CVs saved/appended in file: {Path.GetFullPath(filePath)}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
