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
using System.IO;
namespace CelularCTI73B.Desktop
{
    public partial class frmPrincipal : Form
    {
        List<Aparelho> aparelho = new List<Aparelho>();
        List<Fabricante> fabricante = new List<Fabricante>();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Métodos-------------------------------------------------
        private void carregarLista()
        {
            lstCelular.Items.Clear();
            foreach (Aparelho ap in aparelho)
                lstCelular.Items.Add(ap.ToString());
            if (lstCelular.Items.Count == 0)
            {
                MessageBox.Show("O celular que você buscou não foi encontrado", 
                                                "CTICELL", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                numPrecoMin.Focus();
                reset();
            }
        }
        private void carregarFabs()
        {
            cmbFabricante.Items.Clear();
            fabricante = Servico.BuscarFabricante();
            foreach (Fabricante fab in fabricante)
            {   
                cmbFabricante.Items.Add(fab.Nome);
                cmbFabricante.AutoCompleteCustomSource.Add(fab.Nome);
            }

        }
        private void carregarModelo()
        {
            aparelho = Servico.BuscarAparelho();
            foreach (Aparelho ap in aparelho)
                txtModelo.AutoCompleteCustomSource.Add(ap.Modelo);
        }
        private void limpar()
        {
            numPrecoMin.Value = 0;
            numPrecoMax.Value = 0;
            txtModelo.Clear();
            cmbFabricante.Text = "";
        }
        private void reset()
        {
            aparelho = Servico.BuscarAparelho();
            carregarLista();
            carregarFabs();
            carregarModelo();
            limpar();
            numPrecoMin.Focus();
        }
        private void buscas(int op)
        {
            if (op == 1)
            {
                decimal Min = Convert.ToDecimal(numPrecoMin.Value);
                decimal Max = Convert.ToDecimal(numPrecoMax.Value);
                if (Min < 0 || Max <= 0 || Min > Max)
                {
                    MessageBox.Show("Os campos Preços estão invalidos, digite novamente!", 
                                    "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpar();
                    numPrecoMin.Focus();
                }
                else
                {
                    aparelho = Servico.BuscarAparelho(Min, Max);
                    limpar();
                    carregarLista();
                }
            }
            if (op == 2)
            {
                if (String.IsNullOrEmpty(txtModelo.Text) || String.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    MessageBox.Show("O campo Modelo está invalido, digite novamente!", 
                                    "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpar();
                    txtModelo.Focus();
                }
                else
                {
                    aparelho = Servico.BuscarAparelho(txtModelo.Text);
                    limpar();
                    carregarLista();
                }
            }
            if (op == 3)
            {
                if (cmbFabricante.SelectedIndex < 0)
                {
                    MessageBox.Show("O campo Fabricante está invalido, digite novamente!", 
                                    "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpar();
                    cmbFabricante.Focus();
                }
                else
                {
                    Fabricante f = fabricante[cmbFabricante.SelectedIndex];
                    aparelho = Servico.BuscarAparelho(f);
                    limpar();
                    carregarLista();
                }
            }
        }
        private void selectInto(NumericUpDown numeric)
        {
            if (!String.IsNullOrEmpty(numeric.Text))
                numeric.Select(0, numeric.Text.Length);
        }
        private void changeBtnStyle(int r,int p, int m, int f)
        {
            btnReset.Image= Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\reset" + r + ".png");
            btnBuscaPreco.Image = Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\next" + p + ".png");
            btnBuscaModelo.Image = Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\next" + m + ".png");
            btnBuscaFabricante.Image = Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\next" + f + ".png");
        }
        private void comprar()
        {
            DialogResult r = MessageBox.Show("Deseja comprar este item?", "Comprar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Aparelho selecionado = aparelho[lstCelular.SelectedIndex];
                if (selecionado.Quantidade > 0)
                {
                    new frmComprar(selecionado).Show();
                }
                else
                    MessageBox.Show("Não há aparelhos deste modelo no estoque!", "Comprar", 
                        MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
                return;
        }
        //Form----------------------------------------------------
        private void frmPrincipal_Load(object sender, EventArgs e) => reset();
        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                reset();
        }
        //Botões--------------------------------------------------
        private void btnBuscaPreco_Click(object sender, EventArgs e) => buscas(1);
        private void btnBuscaModelo_Click(object sender, EventArgs e) => buscas(2);
        private void btnBuscaFabricante_Click(object sender, EventArgs e) => buscas(3);
        private void btnReset_Click(object sender, EventArgs e) => reset();
        //Lista---------------------------------------------------
        private void lstCelular_MouseDoubleClick(object sender, MouseEventArgs e) => comprar();
        private void lstCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
                comprar();
        }
        //Outros--------------------------------------------------
        private void numPrecos_Enter(object sender, EventArgs e)
        {
            if (numPrecoMin.CanSelect)
                selectInto(numPrecoMin);
            if (numPrecoMax.CanSelect)
                selectInto(numPrecoMax);
        }
        private void Btns_Enter(object sender, EventArgs e)
        {
            if (sender.Equals(btnReset))
                changeBtnStyle(1, 0, 0, 0);
            if (sender.Equals(btnBuscaPreco))
                changeBtnStyle(0, 1, 0, 0);
            if (sender.Equals(btnBuscaModelo))
                changeBtnStyle(0, 0, 1, 0);
            if (sender.Equals(btnBuscaFabricante))
                changeBtnStyle(0, 0, 0, 1);
        }
        private void Btns_Leave(object sender, EventArgs e) => changeBtnStyle(0, 0, 0, 0);
    }
}
