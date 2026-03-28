using System;
using System.Collections.Generic;
using System.Text;
using GroceryStoreModels;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace GroceryStoreDataService
{
        public class BranchDBData : IBranchDataService
        {
            private string connectionString
                = "Data Source= localhost\\SQLEXPRESS;Initial Catalog=GroceryStoreDB;Integrated Security=True;TrustServerCertificate=True;";

            private SqlConnection sqlConnection;

            public BranchDBData()
            {
                sqlConnection = new SqlConnection(connectionString);
                AddSeeds();
            }

            private void AddSeeds()
            {
                var existing = GetBranches();
                if (existing.Count == 0)
                {
                    Add(new Branch { ID = "24", Name = "Pacita", Location = "San Pedro, Laguna", Manager = "Billy Butcher", Employees = "35" });
                    Add(new Branch { ID = "67", Name = "Santo Tomas", Location = "Binan, Laguna", Manager = "Hughie Campbell", Employees = "17" });
                    Add(new Branch { ID = "33", Name = "Langkiwa", Location = "Binan, Laguna", Manager = "David Martinez", Employees = "25" });
                }
            }

            public void Add(Branch branch)
            {
                var insertStatement = "INSERT INTO GroceryTable (ID, Name, Location, Manager, Employees) " +
                                      "VALUES (@ID, @Name, @Location, @Manager, @Employees)";

                SqlCommand command = new SqlCommand(insertStatement, sqlConnection);
                command.Parameters.AddWithValue("@ID", branch.ID);
                command.Parameters.AddWithValue("@Name", branch.Name);
                command.Parameters.AddWithValue("@Location", branch.Location);
                command.Parameters.AddWithValue("@Manager", branch.Manager);
                command.Parameters.AddWithValue("@Employees", branch.Employees);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }

            public List<Branch> GetBranches()
            {
                var list = new List<Branch>();
                string selectStatement = "SELECT ID, Name, Location, Manager, Employees FROM GroceryTable";
                SqlCommand command = new SqlCommand(selectStatement, sqlConnection);

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Branch {ID = reader["ID"].ToString(),Name = reader["Name"].ToString(),Location = reader["Location"].ToString(),Manager = reader["Manager"].ToString(), Employees = reader["Employees"].ToString() });
                }
                sqlConnection.Close();
                return list;
            }

            public void Update(Branch branch)
            {
                string updateStatement = "UPDATE GroceryTable SET Name=@Name, Location=@Location, Manager=@Manager, Employees=@Employees WHERE ID=@ID";
                SqlCommand command = new SqlCommand(updateStatement, sqlConnection);
                command.Parameters.AddWithValue("@ID", branch.ID);
                command.Parameters.AddWithValue("@Name", branch.Name);
                command.Parameters.AddWithValue("@Location", branch.Location);
                command.Parameters.AddWithValue("@Manager", branch.Manager);
                command.Parameters.AddWithValue("@Employees", branch.Employees);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }

            public void Delete(string id)
            {
                string deleteStatement = "DELETE FROM GroceryTable WHERE ID=@ID";
                SqlCommand command = new SqlCommand(deleteStatement, sqlConnection);
                command.Parameters.AddWithValue("@ID", id);

                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }