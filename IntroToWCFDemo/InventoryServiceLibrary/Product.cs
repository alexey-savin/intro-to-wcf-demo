using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryServiceLibrary
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public short UnitsInStock { get; set; }
        [DataMember]
        public short UnitsOnOrder { get; set; }
    }
}
