using System.Collections.Generic;
namespace GroceryStoreManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice;

            List<string> branch = new List<string>();

            branch.Add("ID: 24 | SupaMart Branch: Pacita | Location: San Pedro, Laguna | Manager: Billy Butcher | Employees: 35");
            branch.Add("ID: 67 | SupaMart Branch: Santo Tomas | Location: Binan, Laguna | Manager: Jotaro Kujo | Employees: 17");
            branch.Add("ID: 33 | SupaMart Branch: Pacita | Location: San Pedro, Laguna | Manager: David Martinez | Employees: 25");

            while (true)
            {
                Console.WriteLine("\n--- Welcome to the Grocery Store Manager, User! ---\n");
                Console.WriteLine("");
                Console.WriteLine("Please select the number of your choice: ");
                Console.WriteLine("1. Establish a new Branch");
                Console.WriteLine("2. View current Branches");
                Console.WriteLine("3. Update Branch information");
                Console.WriteLine("4. Delete a Branch");

                Console.Write("Input Here: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Create(branch);
                        break;

                }

            }
        }
        static void Create(List<string> branch)
        {
            Console.Write("Enter Branch ID");
            string branchID = Console.ReadLine();
            Console.Write("Enter the name of the new Branch: ");
            string branchName = Console.ReadLine();
            Console.Write("Enter Location of new Branch: ");
            string branchLoc = Console.ReadLine();
            Console.Write("Enter New Manager: ");
            string branchManager = Console.ReadLine();
            Console.Write("Enter the Number of Employees you want: ");
            string branchEmpl = Console.ReadLine();

            string branchy = "ID: " + branchID + " | SupaMart Branch: " + branchName + " | Location: " + branchLoc + " | Manager: " + branchManager + " | Employees: " + branchEmpl;

            branch.Add(branchy);

            Console.WriteLine("New Branch Established!");
        }
    }
}



    