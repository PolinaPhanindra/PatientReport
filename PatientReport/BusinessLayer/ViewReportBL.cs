using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatientReport.DataAccesLayer;
using PatientReport.ViewModel;
using System.Data;

namespace PatientReport.BusinessLayer
{
    public class ViewReportBL
    {
        public List<PatientReportView> GetAll()
        {

            PatientViewReportDAL pvr = new DataAccesLayer.PatientViewReportDAL();
            List<PatientReportView> prv = new List<PatientReportView>();
            try
            {
                DataSet ds = pvr.GetAllDetails();
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        prv.Add(new PatientReportView
                        {
                            Id = Convert.ToInt32(row["id"]),
                            PatientName = row["LastName"].ToString(),
                            DeptName = row["DeptName"].ToString(),
                            DoctorName = row["Name"].ToString(),
                            DateTime = DateTime.Now.ToString() 
                        });
                    }
                }
            }
            catch (Exception)
            {

                //TODO
                //Logging
            }
            
            return prv;

        }
        public void Test()
        {

        }
    }
}