using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class InventoryService : IInventoryService
    {
        public Inventory GetInventory(int productId)
        {
            var inventory = new Inventory();

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT UnitsInStock, UnitsOnOrder FROM Products WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", productId));
                    cnn.Open();

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            inventory.ProductId = productId;
                            inventory.UnitsInStock = dataReader.GetInt16(0);
                            inventory.UnitsOnOrder = dataReader.GetInt16(1);
                        }
                    }
                }
            }

            return inventory;
        }

        public bool UpdateInventory(Inventory inventory)
        {
            int rowsChanges = 0;

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("UPDATE Products SET UnitsInStock = @unitsInStock, UnitsOnOrder = @unitsOnOrder WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", inventory.ProductId));
                    cmd.Parameters.Add(new SqlParameter("@unitsInStock", inventory.UnitsInStock));
                    cmd.Parameters.Add(new SqlParameter("@unitsOnOrder", inventory.UnitsOnOrder));
                    cnn.Open();

                    rowsChanges = cmd.ExecuteNonQuery();
                }
            }

            return (rowsChanges != 0);
        }
    }
}
