using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI73B.Model.Entidades;
using CelularCTI73B.Model.Servico;
using Npgsql;

namespace CelularCTI73B.Desktop
{
    public partial class frmComprar : Form
    {
        Aparelho aparelho;
        int cl = 0;
        public frmComprar(Aparelho ap)
        {
            InitializeComponent();
            this.aparelho = ap;
        }
        //Form----------------------------------------------------
        private void frmComprar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl == 0)
            {
                DialogResult resp = MessageBox.Show("Deseja cancelar a compra?", "Cancelar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    this.Dispose();
                    this.Close();
                }
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
                this.Close();
            }
        }
        private void frmComprar_Load(object sender, EventArgs e)
        {
            lblFabricante1.Text = aparelho.Fabricante.Nome;
            lblModelo1.Text = aparelho.Modelo;
            lblLargura1.Text = aparelho.Largura.ToString("#,##0.00");
            lblAltura1.Text = aparelho.Altura.ToString("#,##0.00");
            lblEspessura1.Text= aparelho.Espessura.ToString("#,##0.00");
            lblPeso1.Text = aparelho.Peso.ToString("#,##0.00");
            lblQuantidade1.Text = aparelho.Quantidade.ToString("#,##0.00");
            lblPreco1.Text = aparelho.Preco.ToString("#,##0.00");
            lblDesconto1.Text = aparelho.Desconto.ToString("#,##0.00");
        }
        //Botões--------------------------------------------------
        private void btnComprar_Click(object sender, EventArgs e)
        {
            Servico.SalvarPedido(aparelho);
            MessageBox.Show("Compra feita com sucesso!","CTICELL", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cl = 1;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
    }
}
