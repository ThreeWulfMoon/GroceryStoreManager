using System;
using System.Collections.Generic;
using GroceryStoreModels;

namespace GroceryStoreDataService
{
    public class DataService
    {
        IBranchDataService _dataService;

        public DataService(IBranchDataService dataService)
        {
            _dataService = dataService;
        }

        public void Add(Branch branch)
        {
            _dataService.Add(branch);
        }

        public List<Branch> GetBranches()
        {
            return _dataService.GetBranches();
        }

        public void Update(int index, Branch branch)
        {
            _dataService.Update(index, branch);
        }

        public void Delete(int index)
        {
            _dataService.Delete(index);
        }
    }
}