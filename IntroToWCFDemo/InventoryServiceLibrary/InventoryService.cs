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
        public short GetInStock(int productId)
        {
            short unitsInStock = 0;

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT UnitsInStock FROM Products WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", productId));
                    cnn.Open();

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            unitsInStock = dataReader.GetInt16(0);
                        }
                    }
                }
            }

            return unitsInStock;
        }

        public Product GetProduct(int productId)
        {
            var product = new Product();

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT ProductName, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", productId));
                    cnn.Open();

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            product.ProductId = productId;
                            product.ProductName = dataReader.GetString(0);
                            product.UnitPrice = dataReader.GetDecimal(1);
                            product.UnitsInStock = dataReader.GetInt16(2);
                            product.UnitsOnOrder = dataReader.GetInt16(3);
                        }
                    }
                }
            }

            return product;
        }

        public bool UpdateProduct(Product product)
        {
            int rowsChanges = 0;

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("UPDATE Products SET UnitsInStock = @unitsInStock, UnitsOnOrder = @unitsOnOrder WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", product.ProductId));
                    cmd.Parameters.Add(new SqlParameter("@unitsInStock", product.UnitsInStock));
                    cmd.Parameters.Add(new SqlParameter("@unitsOnOrder", product.UnitsOnOrder));
                    cnn.Open();

                    rowsChanges = (int)cmd.ExecuteNonQuery();
                }
            }

            return (rowsChanges != 0);
        }
    }
}
