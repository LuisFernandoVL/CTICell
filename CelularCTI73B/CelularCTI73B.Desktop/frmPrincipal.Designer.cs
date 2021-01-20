namespace CelularCTI73B.Desktop
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.btnBuscaPreco = new System.Windows.Forms.Button();
            this.lstCelular = new System.Windows.Forms.ListBox();
            this.btnBuscaModelo = new System.Windows.Forms.Button();
            this.btnBuscaFabricante = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.numPrecoMin = new System.Windows.Forms.NumericUpDown();
            this.numPrecoMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(47, 11);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(56, 18);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço: ";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(300, 11);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(66, 18);
            this.lblModelo.TabIndex = 10;
            this.lblModelo.Text = "Modelo: ";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFabricante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFabricante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbFabricante.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(552, 32);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(168, 26);
            this.cmbFabricante.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtModelo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtModelo.Location = new System.Drawing.Point(300, 32);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(168, 24);
            this.txtModelo.TabIndex = 4;
            // 
            // lblFabricante
            // 
            this.lblFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(552, 11);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(85, 18);
            this.lblFabricante.TabIndex = 11;
            this.lblFabricante.Text = "Fabricante: ";
            // 
            // btnBuscaPreco
            // 
            this.btnBuscaPreco.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaPreco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaPreco.FlatAppearance.BorderSize = 0;
            this.btnBuscaPreco.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaPreco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaPreco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaPreco.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaPreco.Image")));
            this.btnBuscaPreco.Location = new System.Drawing.Point(219, 32);
            this.btnBuscaPreco.Name = "btnBuscaPreco";
            this.btnBuscaPreco.Size = new System.Drawing.Size(24, 24);
            this.btnBuscaPreco.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBuscaPreco, "Buscar por preço");
            this.btnBuscaPreco.UseVisualStyleBackColor = false;
            this.btnBuscaPreco.Click += new System.EventHandler(this.btnBuscaPreco_Click);
            this.btnBuscaPreco.Enter += new System.EventHandler(this.Btns_Enter);
            this.btnBuscaPreco.Leave += new System.EventHandler(this.Btns_Leave);
            // 
            // lstCelular
            // 
            this.lstCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCelular.BackColor = System.Drawing.Color.Gainsboro;
            this.lstCelular.FormattingEnabled = true;
            this.lstCelular.ItemHeight = 18;
            this.lstCelular.Location = new System.Drawing.Point(47, 84);
            this.lstCelular.Name = "lstCelular";
            this.lstCelular.Size = new System.Drawing.Size(703, 292);
            this.lstCelular.TabIndex = 8;
            this.lstCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstCelular_KeyPress);
            this.lstCelular.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCelular_MouseDoubleClick);
            // 
            // btnBuscaModelo
            // 
            this.btnBuscaModelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscaModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaModelo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaModelo.FlatAppearance.BorderSize = 0;
            this.btnBuscaModelo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaModelo.Image")));
            this.btnBuscaModelo.Location = new System.Drawing.Point(474, 32);
            this.btnBuscaModelo.Name = "btnBuscaModelo";
            this.btnBuscaModelo.Size = new System.Drawing.Size(24, 24);
            this.btnBuscaModelo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnBuscaModelo, "Buscar por modelo");
            this.btnBuscaModelo.UseVisualStyleBackColor = false;
            this.btnBuscaModelo.Click += new System.EventHandler(this.btnBuscaModelo_Click);
            this.btnBuscaModelo.Enter += new System.EventHandler(this.Btns_Enter);
            this.btnBuscaModelo.Leave += new System.EventHandler(this.Btns_Leave);
            // 
            // btnBuscaFabricante
            // 
            this.btnBuscaFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaFabricante.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaFabricante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaFabricante.FlatAppearance.BorderSize = 0;
            this.btnBuscaFabricante.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaFabricante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaFabricante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscaFabricante.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaFabricante.Image")));
            this.btnBuscaFabricante.Location = new System.Drawing.Point(726, 32);
            this.btnBuscaFabricante.Name = "btnBuscaFabricante";
            this.btnBuscaFabricante.Size = new System.Drawing.Size(24, 24);
            this.btnBuscaFabricante.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnBuscaFabricante, "Buscar por fabricante");
            this.btnBuscaFabricante.UseVisualStyleBackColor = false;
            this.btnBuscaFabricante.Click += new System.EventHandler(this.btnBuscaFabricante_Click);
            this.btnBuscaFabricante.Enter += new System.EventHandler(this.Btns_Enter);
            this.btnBuscaFabricante.Leave += new System.EventHandler(this.Btns_Leave);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(122, 35);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 18);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "à";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(5, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(24, 24);
            this.btnReset.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnReset, "Recarregar dados");
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.Enter += new System.EventHandler(this.Btns_Enter);
            this.btnReset.Leave += new System.EventHandler(this.Btns_Leave);
            // 
            // numPrecoMin
            // 
            this.numPrecoMin.BackColor = System.Drawing.Color.Gainsboro;
            this.numPrecoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrecoMin.DecimalPlaces = 2;
            this.numPrecoMin.Location = new System.Drawing.Point(47, 32);
            this.numPrecoMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPrecoMin.Name = "numPrecoMin";
            this.numPrecoMin.Size = new System.Drawing.Size(69, 24);
            this.numPrecoMin.TabIndex = 1;
            this.numPrecoMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMin.Enter += new System.EventHandler(this.numPrecos_Enter);
            // 
            // numPrecoMax
            // 
            this.numPrecoMax.BackColor = System.Drawing.Color.Gainsboro;
            this.numPrecoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrecoMax.DecimalPlaces = 2;
            this.numPrecoMax.Location = new System.Drawing.Point(144, 32);
            this.numPrecoMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPrecoMax.Name = "numPrecoMax";
            this.numPrecoMax.Size = new System.Drawing.Size(69, 24);
            this.numPrecoMax.TabIndex = 2;
            this.numPrecoMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrecoMax.Enter += new System.EventHandler(this.numPrecos_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pressione ENTER com um item selecionado ou duplo click para comprar:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrecoMax);
            this.Controls.Add(this.numPrecoMin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnBuscaFabricante);
            this.Controls.Add(this.btnBuscaModelo);
            this.Controls.Add(this.lstCelular);
            this.Controls.Add(this.btnBuscaPreco);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPreco);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Button btnBuscaPreco;
        private System.Windows.Forms.ListBox lstCelular;
        private System.Windows.Forms.Button btnBuscaModelo;
        private System.Windows.Forms.Button btnBuscaFabricante;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numPrecoMin;
        private System.Windows.Forms.NumericUpDown numPrecoMax;
        private System.Windows.Forms.Label label1;
    }
}

