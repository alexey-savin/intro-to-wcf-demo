﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryServiceLibrary
{
    public class ProductService : IProductService
    {
        public Product GetProduct(int productId)
        {
            var product = new Product();

            using (var cnn = new SqlConnection(Properties.Settings.Default.NothwindConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT ProductName, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products WHERE ProductId = @productId", cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@productId", productId));

                    try
                    {
                        cnn.Open();
                    }
                    catch (Exception ex)
                    {
                        var connectionFault = new ConnectionFault
                        {
                            Issue = "Problem connecting to the database",
                            Details = ex.Message
                        };

                        throw new FaultException<ConnectionFault>(connectionFault);
                    }   

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dataReader.Read())
                            {
                                product.ProductId = productId;
                                product.ProductName = dataReader.GetString(0);
                                product.UnitPrice = dataReader.GetDecimal(1);
                            }
                        }
                        catch (Exception ex)
                        {
                            var dataReaderFault = new DataReaderFault
                            {
                                Issue = "Problem reading the database",
                                Details = ex.Message
                            };

                            throw new FaultException<DataReaderFault>(dataReaderFault);
                        }
                    }
                }
            }

            return product;
        }
    }
}
