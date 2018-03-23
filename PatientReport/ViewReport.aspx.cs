using PatientReport.BusinessLayer;
using PatientReport.DataAccesLayer;
using System;
namespace PatientReport
{
    public partial class ViewReport : System.Web.UI.Page
    {
        ViewReportBL vb = new ViewReportBL();
        PatientViewReportDAL pvr = new PatientViewReportDAL(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    /* GridView1.DataSource = vb.GetAll();
                     GridView1.DataBind();
                     */
                    GridView1.DataSource = pvr.GetAllDetails();
                    GridView1.DataBind();
                }

            }
            catch (Exception)
            {

                //TODO
                //Logging
            } 
            
        }

        
    }
}