using System.Collections.Generic;
using System.Data;
using GroceryStoreAppService;
using GroceryStoreModels;

namespace GroceryStoreManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice;

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
                        Create();
                        break;
                        case "2":
                            Read();
                            break;
                     /* case "3":
                            Update();
                            break; */
                        case "4":
                            Delete();
                            break;
                        case "5":
                            return;
                            break;
                        default:
                            Console.WriteLine("Please enter ONLY a number!");
                            break;
                }

            }
        }
        static void Create()
        {
            Branch b = new Branch();

            Console.Write("Enter Branch ID (2 digits): ");
            b.ID = Console.ReadLine();
            Console.Write("Enter the name of the new Branch: ");
            b.Name = Console.ReadLine();
            Console.Write("Enter Location of new Branch: ");
            b.Location = Console.ReadLine();
            Console.Write("Enter New Manager: ");
            b.Manager = Console.ReadLine();
            Console.Write("Enter the Number of Employees you want: ");
            b.Employees = Console.ReadLine(); ;

            AppService.CreateBranch(b);

            Console.WriteLine("New Branch Established!");
        }

        static void Read()
        {
            List<Branch> branches = AppService.GetBranches();

            Console.WriteLine("\n ----- Current SupaMart Branches Available for Viewing ----- \n");
            for (int i = 0; i < branches.Count; i++)
            {
                Branch b = branches[i];
                Console.WriteLine((i + 1) + ". ID: " + b.ID + " | Branch: " + b.Name + " | Location: " + b.Location + " | Manager: " + b.Manager + " | Employees: " + b.Employees);
            }
            Console.Write("Select the number of the Branch you want to view: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < branches.Count) {
                Branch b = branches[index];
                Console.WriteLine("----- Branch Information -----");
                Console.WriteLine("ID: " + b.ID + " | Branch: " + b.Name + " | Location: " + b.Location + " | Manager: " + b.Manager + " | Employees: " + b.Employees);
            }
            else
            {
                Console.WriteLine("Invalid Branch Number");
            }
        }
        static void Delete()
        {
            List<Branch> branches = AppService.GetBranches();

            Console.WriteLine("\n--- Current Branches that are Available ---\n");
            for (int i = 0; i < branches.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + branches[i].Name);
            }
            Console.WriteLine("Select the number of the branch you want to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < branches.Count)
            {
                AppService.DeleteBranch(index);
                Console.WriteLine("Branch deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid branch number.");
            }
        }

    }
}


    