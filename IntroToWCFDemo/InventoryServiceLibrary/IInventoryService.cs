﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InventoryServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        short GetInStock(int productId);

        [OperationContract]
        bool UpdateProduct(Product product);
    }
}
