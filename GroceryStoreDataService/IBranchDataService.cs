using System;
using System.Collections.Generic;
using System.Text;
using GroceryStoreModels;
using System.Collections.Generic;

namespace GroceryStoreDataService
{
    public interface IBranchDataService
    {
        void Add(Branch branch);
        List<Branch> GetBranches();
        void Update(int index, Branch branch);
        void Delete(int index);

    }
}
