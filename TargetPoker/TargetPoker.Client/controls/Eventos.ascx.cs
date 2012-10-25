using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TargetPoker.Client.controls
{
    public partial class Eventos : System.Web.UI.UserControl
    {
        public List<Entidades.Evento> DataSource;

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