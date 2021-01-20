using System;
using System.Collections.Generic;
using CelularCTI73B.Model.Entidades;
using CelularCTI73B.Model.Suporte;
using CelularCTI73B.Model.Servico;

public partial class Cadastrar : System.Web.UI.Page
{
    List<Fabricante> fabricantes;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*ConexaoBanco.conectar();
        fabricantes = Servico.todosFabricantes();
        foreach (Fabricante f in fabricantes)
            cmbFabricantes.Items.Add(f.Nome);*/
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        /*Aparelho novo = new Aparelho();
        novo.Modelo = txtModelo.Text;
        novo.Largura = (float)Convert.ToDouble(txtLargura.Text);
        novo.Altura = (float)Convert.ToDouble(txtAltura.Text);
        novo.Espessura = (float)Convert.ToDouble(txtEspessura.Text);
        novo.Peso = Convert.ToInt16(txtPeso.Text);
        novo.Quantidade = Convert.ToInt16(txtQuantidade.Text);
        novo.Preco = (float)Convert.ToDouble(txtPreco.Text);
        novo.Desconto = (float)Convert.ToDouble(txtDesconto.Text);
        novo.Fabricante = fabricantes[cmbFabricantes.SelectedIndex];
        Servico.salvar(novo);
        Response.Redirect("default.aspx");*/
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        ConexaoBanco.desconectar();
    }
}