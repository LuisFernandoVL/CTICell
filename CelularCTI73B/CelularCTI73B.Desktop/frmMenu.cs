using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelularCTI73B.Desktop
{
    public partial class frmMenu : Form
    {
        private Form activeForm = null;
        public frmMenu()
        {
            InitializeComponent();
        }
        //Métodos-------------------------------------------------
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Form----------------------------------------------------
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
            e.Cancel = true;

        }
        private void frmMenu_Load(object sender, EventArgs e) => openChildForm(new frmPrincipal());
        //Botões--------------------------------------------------
        private void btnPrincipal_Click(object sender, EventArgs e) => openChildForm(new frmPrincipal());
        private void btnNovo_Click(object sender, EventArgs e) => openChildForm(new frmNovo());
        private void btnLogout_Click(object sender, EventArgs e) => this.Close();
      
    }
}
