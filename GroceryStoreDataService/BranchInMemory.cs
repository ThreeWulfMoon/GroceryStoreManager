using GroceryStoreModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryStoreDataService
{
        public class BranchInMemoryData : IBranchDataService
        {
            private List<Branch> branches = new List<Branch>();

            public BranchInMemoryData()
            {
                branches.Add(new Branch { ID = "24", Name = "Pacita", Location = "San Pedro", Manager = "Billy Butcher", Employees = "35" });
                branches.Add(new Branch { ID = "67", Name = "Santo Tomas", Location = "Binan, Laguna", Manager = "Hughie Campbell", Employees = "17" });
                branches.Add(new Branch { ID = "33", Name = "Langkiwa", Location = "Binan, Laguna", Manager = "David Martinez", Employees = "25" });
            }

            public void Add(Branch branch)
            {
                branches.Add(branch);
            }

            public List<Branch> GetBranches()
            {
                return branches;
            }

            public void Update(int index, Branch branch)
            {
                branches[index] = branch;
            }

            public void Delete(int index)
            {
                branches.RemoveAt(index);
            }
        }
    }
