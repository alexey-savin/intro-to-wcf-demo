using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace InventoryServiceLibrary
{
    [ServiceContract]
    public interface IProductService
    {
        [FaultContract(typeof(ConnectionFault))]
        [FaultContract(typeof(DataReaderFault))]
        [OperationContract]
        Product GetProduct(int productId);
    }
}
