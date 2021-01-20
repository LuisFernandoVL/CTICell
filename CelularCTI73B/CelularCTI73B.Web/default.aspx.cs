using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CelularCTI73B.Model;
using CelularCTI73B.Model.Entidades;
using CelularCTI73B.Model.Servico;
using CelularCTI73B.Model.Suporte;

public partial class _Default : System.Web.UI.Page
{
    protected List<Aparelho> ap;
    protected void Page_Load(object sender, EventArgs e)
    {
        ConexaoBanco.conectar();
        ap = Servico.BuscarAparelho("");
        
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        ConexaoBanco.desconectar();
    }
}