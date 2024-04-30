using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoManagment.Shared
{
    public class ExtractBoxDepartment
    {
        public int ExtractBoxDepartmentId { get; set; }
        public string BoxBarcode { get; set; }
        public DateTime ExtractDate { get; set; }
        public string Staff { get; set; }
        public List<Parts> Parts { get; set; }
    }
}
