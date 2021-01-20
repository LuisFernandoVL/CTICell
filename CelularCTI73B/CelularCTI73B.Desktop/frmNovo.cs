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
    public partial class frmNovo : Form
    {
        List<Aparelho> aparelho = new List<Aparelho>();
        List<Fabricante> fabricante = new List<Fabricante>();
        private bool add = false;
        public frmNovo()
        {
            InitializeComponent();
        }
        //Métodos-------------------------------------------------
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
            cmbFabricante.Text = "";
            txtModelo.Clear();
            numLargura.Value = 0;
            numAltura.Value = 0;
            numEspessura.Value = 0;
            numPeso.Value = 0;
            numQuantidade.Value = 0;
            numPreco.Value = 0;
            numDesc.Value = 0;

            txtNovoFab.Text = "";

            cmbFabricante.Focus();
        }
        private void reset()
        {
            add = false;
            carregarFabs();
            carregarModelo();
            limpar();
            cmbFabricante.Focus();
        }
        private void addNovoFab(bool tf)
        {
            lblNovoFab.Enabled = tf;
            lblNovoFab.Visible = tf;
            txtNovoFab.Enabled = tf;
            txtNovoFab.Visible = tf;
            btnSalvar2.Enabled = tf;
            btnSalvar2.Visible = tf;
            btnCancelar2.Enabled = tf;
            btnCancelar2.Visible = tf;

            add = tf;

            if(tf==true)
            {
                btnSalvar1.Enabled = false;
                btnCancelar1.Enabled = false;
            }else
            {
                btnSalvar1.Enabled = true;
                btnCancelar1.Enabled = true;
            }

        }
        private void selectInto(NumericUpDown numeric)
        {
            if (!String.IsNullOrEmpty(numeric.Text))
                numeric.Select(0, numeric.Text.Length);
        }
        private void numDetalhes_Enter(object sender, EventArgs e)
        {
            if (numLargura.CanSelect)
                selectInto(numLargura);
            if (numAltura.CanSelect)
                selectInto(numAltura);
            if (numEspessura.CanSelect)
                selectInto(numEspessura);
            if (numPeso.CanSelect)
                selectInto(numPeso);
            if (numQuantidade.CanSelect)
                selectInto(numQuantidade);
            if (numPreco.CanSelect)
                selectInto(numPreco);
            if (numDesc.CanSelect)
                selectInto(numDesc);
        }
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text != "")
            {
                aparelho = Servico.BuscarAparelho();
                bool s = false;
                foreach (Aparelho ap in aparelho)
                {
                    s = ap.Modelo.Equals(txtModelo.Text);
                    if (s == true)
                    {
                        cmbFabricante.SelectedIndex = cmbFabricante.FindString(ap.Fabricante.Nome); ;
                        numLargura.Value = (decimal)ap.Largura;
                        numAltura.Value = (decimal)ap.Altura;
                        numEspessura.Value = (decimal)ap.Espessura;
                        numPeso.Value = (decimal)ap.Peso;
                        numQuantidade.Value =(decimal)ap.Quantidade;
                        numPreco.Value = (decimal)ap.Preco;
                        numDesc.Value = (decimal)ap.Desconto;
                        break;
                    }
                }
            }
        }
        private void changeBtnStyle(int r, int f)
        {
            btnReset.Image = Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\reset" + r + ".png");
            btnAdFab.Image = Image.FromFile(Directory.GetCurrentDirectory()
                        + "\\imgs\\add" + f + ".png");
        }
        //Form----------------------------------------------------
        private void frmNovo_Load(object sender, EventArgs e) => reset();
        private void frmNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                reset();
        }
        //Botões-Aparelho-----------------------------------------
        private void btnReset_Click(object sender, EventArgs e) => reset();
        private void btnAdFab_Click(object sender, EventArgs e)
        {
            txtNovoFab.Text = "";
            if (add == false)
                addNovoFab(true);
            else
                addNovoFab(false);
        }
        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtModelo.Text) && String.IsNullOrWhiteSpace(cmbFabricante.SelectedText))
            {
                MessageBox.Show("Preencha os campos Fabricante e Modelo corretamente!",
                           "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbFabricante.Focus();
            }
            else
            {
                Aparelho novo = new Aparelho();
                novo.Modelo = txtModelo.Text;
                novo.Largura = numLargura.Value;
                novo.Altura = numAltura.Value;
                novo.Espessura = numEspessura.Value;
                novo.Peso = numPeso.Value;
                novo.Quantidade = (int)numQuantidade.Value;
                novo.Preco = numPreco.Value;
                novo.Desconto = numDesc.Value;
                novo.Fabricante = fabricante[cmbFabricante.SelectedIndex];

                aparelho = Servico.BuscarAparelho();
                bool s = false;
                foreach (Aparelho ap in aparelho)
                {
                    s = novo.Modelo.Equals(ap.Modelo);
                    if (s == true)
                    {
                        novo.Id_Aparelho = ap.Id_Aparelho;
                        Servico.Salvar(novo);
                        MessageBox.Show("O aparelho foi atualizado com sucesso!",
                                        "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (s == false)
                {
                    Servico.Salvar(novo);
                    MessageBox.Show("O aparelho foi salvo com sucesso!",
                                    "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                reset();
            }
            return;
        }
        private void btnCancelar1_Click(object sender, EventArgs e) => limpar();
        //Botões-Fabricante---------------------------------------
        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNovoFab.Text))
            {
                MessageBox.Show("Preencha o campo Novo Fabricante corretamente!",
                                "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNovoFab.Focus();
            }
            else
            {
                Fabricante novo = new Fabricante();
                novo.Nome = txtNovoFab.Text;

                fabricante = Servico.BuscarFabricante();
                bool s = false;
                foreach (Fabricante fab in fabricante)
                {
                    s = novo.Nome.Equals(fab.Nome);
                    if (s == true)
                    {
                        novo.Id_Fabricante = fab.Id_Fabricante;
                        Servico.Salvar(novo);
                        MessageBox.Show("Este fabricante já está cadastrado no sistema!",
                                        "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
                if (s == false)
                {
                    Servico.Salvar(novo);
                    MessageBox.Show("O fabricante foi salvo com sucesso!",
                                        "CTICELL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addNovoFab(false);
                }
                reset();
            }
            return;

        }
        private void btnCancelar2_Click(object sender, EventArgs e) => addNovoFab(false);
        //Outros--------------------------------------------------
        private void Btns_Enter(object sender, EventArgs e)
        {
            if (sender.Equals(btnReset))
                changeBtnStyle(1, 0);
            if (sender.Equals(btnAdFab))
                changeBtnStyle(0, 1);
        }
        private void Btns_Leave(object sender, EventArgs e) => changeBtnStyle(0, 0);
    }
}
