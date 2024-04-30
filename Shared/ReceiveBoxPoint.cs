using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoManagment.Shared
{
    public class ReceiveBoxPoint
    {
        public int ReceiveBoxPointId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string BoxBarcode { get; set; }
        public string CarPlateNumber { get; set; }
        public string CarPlateNumberCountry { get; set; }
        public string Staff { get; set; }
     
    }
}
