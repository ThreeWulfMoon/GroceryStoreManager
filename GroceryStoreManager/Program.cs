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
                Console.WriteLine(" ");
                Console.WriteLine("\n--- Welcome to the Grocery Store Manager, User! ---\n");
                Console.WriteLine(" ");
                Console.WriteLine("Please select the number of your choice: ");
                Console.WriteLine("1. Establish a new Branch");
                Console.WriteLine("2. View current Branches");
                Console.WriteLine("3. Update Branch information");
                Console.WriteLine("4. Delete a Branch");
                Console.WriteLine(" ");
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
                         case "3":
                            Update();
                            break; 
                        case "4":
                            Delete();
                            break;
                        case "5":
                            return;
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
                Console.WriteLine(" ");
                Console.WriteLine("----- Branch Information -----");
                Console.WriteLine(" ");
                Console.WriteLine("ID: " + b.ID + " | Branch: " + b.Name + " | Location: " + b.Location + " | Manager: " + b.Manager + " | Employees: " + b.Employees);
            }
            else
            {
                Console.WriteLine("Invalid Branch Number");
            }
        }

        static void Update()
        {
            List<Branch> branches = AppService.GetBranches();

            Console.WriteLine("\n--- Current Branches that are Available for Update ---\n");
            Console.WriteLine(" ");

            for (int i = 0; i < branches.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + branches[i].Name);
            }

            Console.WriteLine(" ");
            Console.Write("Enter the ID of the branch you want to update: ");
            string id = Console.ReadLine();

            Branch existing = branches.Find(b => b.ID == id);

            if (existing != null)
            {
                Branch upd = new Branch();

                upd.ID = id;

                Console.Write("Enter the new Branch name: ");
                upd.Name = Console.ReadLine();

                Console.Write("Enter new Location: ");
                upd.Location = Console.ReadLine();

                Console.Write("Enter new Manager: ");
                upd.Manager = Console.ReadLine();

                Console.Write("Enter new number of Employees: ");
                upd.Employees = Console.ReadLine();

                AppService.UpdateBranch(upd);

                Console.WriteLine("Branch updated successfully!");
            }
            else
            {
                Console.WriteLine("Branch ID was invalid/not found.");
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
            Console.WriteLine(" ");
            Console.Write("Enter the ID of the branch you want to delete: ");
            string id = Console.ReadLine();

            Branch existing = branches.Find(b => b.ID == id);

            if (existing != null)
            {
                AppService.DeleteBranch(id);
                Console.WriteLine("Branch deleted successfully!");
            }
            else
            {
                Console.WriteLine("Branch ID was invalid.");
            }
        }

    }
}


    