using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExperts.Data;

namespace TravelExperts.App
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var db = new TravelExpertsEntities();
                GridViewProducts.DataSource = db.Products.ToList();
                GridViewProducts.DataBind();
            }
        }
    }
}