using System;
using System.Collections.Generic;
using GroceryStoreModels;
using System.Text.Json;

namespace GroceryStoreDataService
{
    public class BranchJsonData : IBranchDataService
    { 
    
        private List<Branch> branches = new List<Branch>();

        private string _jsonfileName;

        public BranchJsonData()
        {
            _jsonfileName = AppDomain.CurrentDomain.BaseDirectory + "/Branches.json";
            PopulateJsonFile();
        }

        private void PopulateJsonFile()
        {
            LoadFromFile();

            if (branches.Count <= 0)
            {
                branches.Add(new Branch { ID = "24", Name = "Pacita", Location = "San Pedro, Laguna", Manager = "Billy Butcher", Employees = "35" });
                branches.Add(new Branch { ID = "67", Name = "Santo Tomas", Location = "Binan, Laguna", Manager = "Hughie Campbell", Employees = "17" });
                branches.Add(new Branch { ID = "33", Name = "Langkiwa", Location = "Binan, Laguna", Manager = "David Martinez", Employees = "25" });

                SaveToFile();
            }
        }
        private void LoadFromFile()
        {
            if (File.Exists(_jsonfileName))
            {
                string jsonString = File.ReadAllText(_jsonfileName);

                if (!string.IsNullOrEmpty(jsonString))
                {
                    branches = JsonSerializer.Deserialize<List<Branch>>(jsonString);
                }

            }
        }
        private void SaveToFile()
        {
            string json = JsonSerializer.Serialize(branches, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_jsonfileName, json);
        }

        public void Add(Branch b)
        {
            branches.Add(b);
            SaveToFile();
        }

        public List<Branch> GetBranches()
        {
            LoadFromFile();
            return branches;
        }

        public void Update(Branch branch)
        {
            LoadFromFile();

            int ids = branches.FindIndex(b => b.ID == branch.ID);
            if (ids >= 0)
                branches[ids] = branch;

            SaveToFile();
        } 

        public void Delete(string id)
        {
            LoadFromFile();

            int ids = branches.FindIndex(b => b.ID == id);
            if (ids >= 0)
                branches.RemoveAt(ids);

            SaveToFile();
        }
    }
}