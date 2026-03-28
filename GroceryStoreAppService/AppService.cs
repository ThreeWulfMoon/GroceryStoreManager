using GroceryStoreModels;
using GroceryStoreDataService;
using System.Collections.Generic;

namespace GroceryStoreAppService
{
    public class AppService
    {

        private static DataService data = new DataService();

        public static void CreateBranch(Branch b)
        {
            data.Add(b);
        }

        public static List<Branch> GetBranches()
        {
            return data.GetBranches();
        }

        public static void DeleteBranch(int index)
        {
            data.Delete(index);
        }

        public static void UpdateBranch(int index, Branch updated)
        {
            data.Update(index, updated);
        }
    }
}