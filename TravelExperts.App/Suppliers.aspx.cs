using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExperts.Data;

namespace TravelExperts.App
{
    public partial class Suppliers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new TravelExpertsEntities();
            GridViewSuppliers.DataSource = db.Suppliers.ToList();
            GridViewSuppliers.DataBind();
        }
    }
}