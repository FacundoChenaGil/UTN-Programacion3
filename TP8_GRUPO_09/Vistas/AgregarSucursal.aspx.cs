﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioProvincia negProv = new NegocioProvincia();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                CargarProvincias();
            }
        }
        private void CargarProvincias()
        {
            DataTable dt = negProv.getTabla();
            ddlProvincias.DataSource = dt;
            ddlProvincias.DataTextField = "DescripcionProvincia";
            ddlProvincias.DataValueField = "Id_Provincia";
            ddlProvincias.DataBind();

            ddlProvincias.Items.Insert(0, new ListItem("-- Seleccionar --", "-1"));
            ddlProvincias.Items[0].Attributes["disabled"] = "disabled";
            ddlProvincias.Items[0].Selected = true;
        }
    }
}