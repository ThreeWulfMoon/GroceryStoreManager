using GroceryStoreModels;
using GroceryStoreDataService;
using System.Collections.Generic;

namespace GroceryStoreAppService
{
    public class AppService
    {

        private static DataService data = new DataService(new BranchJsonData());

        public static void CreateBranch(Branch b)
        {
            data.Add(b);
        }

        public static List<Branch> GetBranches()
        {
            return data.GetBranches();
        }

        public static void DeleteBranch(string id)
        {
            data.Delete(id);
        }

        public static void UpdateBranch(Branch updated)
        {
            data.Update(updated);
        }
    }
}