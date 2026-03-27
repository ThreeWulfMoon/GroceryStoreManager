using GroceryStoreModels;
using GroceryStoreDataService;
using System.Collections.Generic;

namespace GroceryStoreAppService
{
    public class AppService
    {
        public static void CreateBranch(Branch b)
        {
            DataService.branches.Add(b);
        }
        public static List<Branch> GetBranches()
        {
            return DataService.branches;
        }
           public static void UpdateBranch(int index, Branch updatedBranch)
        {
            DataService.branches[index] = updatedBranch;
        }
             public static void DeleteBranch(int index)
        {
            DataService.branches.RemoveAt(index);
        }
    }
}