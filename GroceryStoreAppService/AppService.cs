using GroceryStoreModels;
using GroceryStoreDataService;
using System.Collections.Generic;

namespace GroceryStoreAppService
{
    public class AppService
    {
        private DataService data = new DataService(new BranchDBData());

        public void CreateBranch(Branch b)
        {
            data.Add(b);
        }

        public List<Branch> GetBranches()
        {
            return data.GetBranches();
        }

        public Branch GetBranchById(string id)
        {
            return data.GetBranches().FirstOrDefault(x => x.ID == id);
        }
        public void DeleteBranch(string id)
        {
            data.Delete(id);
        }

        public void UpdateBranch(Branch updated)
        {
            data.Update(updated);
        }
    }
}