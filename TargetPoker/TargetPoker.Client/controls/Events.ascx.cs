using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TargetPoker.Client.controls
{
    public partial class Events : System.Web.UI.UserControl
    {
        public Model.Events DataSource;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.DataSource != null && this.DataSource.Count > 0)
            {
                rptEventos.DataSource = this.DataSource;
                rptEventos.DataBind();
            }
            else
            {
                lblEmBreve.Visible = true;
            }
        }
    }
}