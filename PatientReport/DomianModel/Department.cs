using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// <para>Hospital departments related to particular speciatation </para>
/// </summary>
namespace PatientReport.Model
{
    //creating a department class
    public class Department
    {
        public int DeptId { get; private set; }
        public int DeptName { get; set; }
        public int HeadOfDept { get; set; }
    }
}