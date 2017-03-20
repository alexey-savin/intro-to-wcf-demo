using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InventoryServiceLibrary
{
    public class Inventory
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public short UnitsInStock { get; set; }
        [DataMember]
        public short UnitsOnOrder { get; set; }
    }
}
