using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoManagment.Shared
{
    public class Parts
    {
        public int PartsId { get; set; }
        public string PartBarcode { get; set; }
        public DateTime? DateComeIn { get; set; }
        public DateTime? DateGoesOut { get; set; }
        public Place PlaceInDepoToGo { get; set; }
        // Foreign key property
        public int ExtractBoxDepartmentId { get; set; }

        // Navigation property for ExtractBoxDepartment
        public ExtractBoxDepartment ExtractBoxDepartment { get; set; } = new ExtractBoxDepartment();
    }
}
