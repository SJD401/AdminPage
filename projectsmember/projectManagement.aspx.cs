using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectsmember
{

    public partial class project_management : System.Web.UI.Page
    {
        SqlConnection LOGConn = new SqlConnection(ConfigurationManager.ConnectionStrings["sojaIrishConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            //if (Session["adminstatus"] != null &&
            //   Session["adminstatus"].ToString() == "login_admin")
            //{
            //    //successful login
            //    DataSet1TableAdapters.AdminTableAdapter dtaAdminName = new DataSet1TableAdapters.AdminTableAdapter();
            //    string adminName = dtaAdminName.ReturnAdminName(Session["Name"].ToString()).ToString();
            //    //dtaAdminName.ReturnAdminName(Session["Username"].ToString());

            //    lblName.Text = adminName;
            //}
            //else
            //{
            //    Response.Redirect("login_admin.aspx");
            //}
=======
=======
>>>>>>> ebe86aba130ce9ac0235456fb1a68a984c63ffbd
            if (Session["adminstatus"] != null &&
               Session["adminstatus"].ToString() == "login_admin")
            {
                //successful login
                DataSet1TableAdapters.AdminTableAdapter dtaAdminName = new DataSet1TableAdapters.AdminTableAdapter();
                string adminName = dtaAdminName.ReturnAdminName(Session["Name"].ToString()).ToString();
                //dtaAdminName.ReturnAdminName(Session["Username"].ToString());

                lblName.Text = adminName;
            }
            else
            {
                Response.Redirect("login_admin.aspx");
            }
<<<<<<< HEAD
>>>>>>> 30f37a0e06c350e7b194382072b99ccffcc7cb99
=======
>>>>>>> ebe86aba130ce9ac0235456fb1a68a984c63ffbd


            DataSet1TableAdapters.ProjectsTableAdapter dstaProjNotif2 = new DataSet1TableAdapters.ProjectsTableAdapter();
            int numProjNotif2 = Convert.ToInt32(dstaProjNotif2.QueryProjectNotif());
            lblNotif2.Text = Convert.ToString(numProjNotif2);

            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Projects", LOGConn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            rptMsgNotif2.DataSource = dt2;
            rptMsgNotif2.DataBind();

        }
    }
}