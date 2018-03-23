using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientReport.Model
{
    public class Doctors
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; private set; }
        public string specialation { get; set; }
    }
}