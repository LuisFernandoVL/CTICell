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

namespace CelularCTI73B.Web
{
    public partial class detalhes : System.Web.UI.Page
    {
        protected Aparelho aparelho;
        protected void Page_Load(object sender, EventArgs e)
        {
            ConexaoBanco.conectar();
            int id = Convert.ToInt32(Request.QueryString["aparelho"]);
            List<Aparelho> aparelhos = Servico.BuscarAparelho("");
            foreach (Aparelho a in aparelhos)
                if (a.Id_Aparelho.Equals(id))
                {
                    aparelho = a;
                    break;
                }
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            ConexaoBanco.desconectar();
        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Servico.SalvarPedido (aparelho);
            Response.Redirect("default.aspx");
        }
    }
}