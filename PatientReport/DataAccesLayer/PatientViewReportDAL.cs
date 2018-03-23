using PatientReport.dbHelper;
using System.Data;

namespace PatientReport.DataAccesLayer
{
    public class PatientViewReportDAL
    {
        public DataSet GetAllDetails()
        {
            DBHelper helper = new DBHelper(); 
            //SqlParameter sp1 = new SqlParameter()   
            return helper.SqlQuery("Select * from Patient");
            
        }
    }
}