namespace ConsoleAppCollectionsA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First IN, First OUT (FIFO)
            //Implement a waiting list of patient’s names in a hospital.  
            // The person sending in the patients to the doctors room should 
            // be able to find the next person to go in. 
            Queue<string> waitingList = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n=== Hospital Waiting List ===");
                Console.WriteLine("1. Add Patient to Waiting List");
                Console.WriteLine("2. Call Next Patient");
                Console.WriteLine("3. View Waiting List");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Patient Name: ");
                        string name = Console.ReadLine();
                        waitingList.Enqueue(name);
                        Console.WriteLine($"{name} added to waiting list.");
                        break;

                    case "2":
                        if (waitingList.Count > 0)
                        {
                            string nextPatient = waitingList.Dequeue();
                            Console.WriteLine($"Next patient to see the doctor: {nextPatient}");
                        }
                        else
                        {
                            Console.WriteLine("No patients in the waiting list.");
                        }
                        break;

                    case "3":
                        if (waitingList.Count > 0)
                        {
                            Console.WriteLine("Patients currently waiting:");
                            foreach (var patient in waitingList)
                            {
                                Console.WriteLine(" - " + patient);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Waiting list is empty.");
                        }
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
