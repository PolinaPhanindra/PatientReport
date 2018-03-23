using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientReport.ViewModel
{
    public class PatientReportView
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string DeptName { get; set; }
        public string DateTime { get; set; }
    }
}