using System;
using System.Collections.Generic;

namespace PoultryFarm.Models
{
    public partial class PoultryStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string StaffAddress { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
