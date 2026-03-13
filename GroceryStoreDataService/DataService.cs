using System.Collections.Generic;
using GroceryStoreModels;

namespace GroceryStoreDataService
{
    public class DataService
    {
        public static List<Branch> branches = new List<Branch>();

        static DataService()
        {
            branches.Add(new Branch { ID = "24", Name = "Pacita", Location = "San Pedro, Laguna", Manager = "Billy Butcher", Employees = "35" });
            branches.Add(new Branch { ID = "67", Name = "Santo Tomas", Location = "Binan, Laguna", Manager = "Hughie Campbell", Employees = "17" });
            branches.Add(new Branch { ID = "33", Name = "Langkiwa", Location = "Binan, Laguna", Manager = "David Martinez", Employees = "25" });
        }
    }
}