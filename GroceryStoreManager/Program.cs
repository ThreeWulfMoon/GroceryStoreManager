using System.Collections.Generic;
using System.Data;
namespace GroceryStoreManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice;

            List<string> branch = new List<string>();

            branch.Add("ID: 24 | SupaMart Branch: Pacita | Location: San Pedro, Laguna | Manager: Billy Butcher | Employees: 35");
            branch.Add("ID: 67 | SupaMart Branch: Santo Tomas | Location: Binan, Laguna | Manager: Hughie Campbell | Employees: 17");
            branch.Add("ID: 33 | SupaMart Branch: Langkiwa | Location: Binan, Laguna | Manager: David Martinez | Employees: 25");

            while (true)
            {
                Console.WriteLine("\n--- Welcome to the Grocery Store Manager, User! ---\n");
                Console.WriteLine(" ");
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
                        case "2":
                            Read(branch);
                            break;
                     /* case "3":
                            Update(branch);
                            break;
                        case "4":
                            Deleted(branch);
                            break;
                        case "5":
                            return;
                            break;
                        default:
                            Console.WriteLine("Please enter ONLY a number!");
                            break; */
                }

            }
        }
        static void Create(List<string> branch)
        {
            Console.Write("Enter Branch ID (2 digits): ");
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

        static void Read(List<string> branch)
        {
            Console.WriteLine("\n ----- Current SupaMart Branches Available for Viewing ----- \n");
            for (int i = 0; i < branch.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + branch[i]);
            }
            Console.Write("Select the number of the Branch you want to view: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < branch.Count) {
                Console.WriteLine("----- Branch Information -----");
                Console.WriteLine(branch[index]);

                
            }
            else
            {
                Console.WriteLine("Invalid Branch Number");
            }
        }
    }
}


    