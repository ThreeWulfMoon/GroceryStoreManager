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

        public void Update(Branch branch)
        {
            _dataService.Update(branch);
        }
        public void Delete(string id)
        {
            _dataService.Delete(id);
        }

    }
}