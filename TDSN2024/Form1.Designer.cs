namespace TDSN2024
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblForma = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Medidas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Medidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblForma
            // 
            this.lblForma.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForma.ForeColor = System.Drawing.Color.Chocolate;
            this.lblForma.Location = new System.Drawing.Point(33, 24);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(59, 26);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Formas";
            // 
            // cmbForma
            // 
            this.cmbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(98, 24);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(121, 21);
            this.cmbForma.TabIndex = 1;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTriangulo.Location = new System.Drawing.Point(336, 24);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(68, 17);
            this.lblTriangulo.TabIndex = 2;
            this.lblTriangulo.Text = "Triângulo";
            this.lblTriangulo.Click += new System.EventHandler(this.lblTriangulo_Click);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriangulo.Enabled = false;
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(410, 24);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTriangulo.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriar.AutoSize = true;
            this.btnCriar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCriar.ForeColor = System.Drawing.Color.Black;
            this.btnCriar.Location = new System.Drawing.Point(242, 24);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Padding = new System.Windows.Forms.Padding(3);
            this.btnCriar.Size = new System.Drawing.Size(75, 29);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseMnemonic = false;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(203, 344);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(164, 21);
            this.cmbObjetos.TabIndex = 5;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.ForeColor = System.Drawing.Color.Peru;
            this.lblRaio.Location = new System.Drawing.Point(34, 62);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 6;
            this.lblRaio.Text = "Raio";
            this.lblRaio.Visible = false;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(69, 59);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(123, 20);
            this.txtRaio.TabIndex = 7;
            this.txtRaio.Visible = false;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(69, 85);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(123, 20);
            this.txtLado.TabIndex = 9;
            this.txtLado.Visible = false;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.ForeColor = System.Drawing.Color.Peru;
            this.lblLado.Location = new System.Drawing.Point(32, 88);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 8;
            this.lblLado.Text = "Lado";
            this.lblLado.Visible = false;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(69, 111);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(123, 20);
            this.txtBase.TabIndex = 11;
            this.txtBase.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.ForeColor = System.Drawing.Color.Peru;
            this.lblBase.Location = new System.Drawing.Point(32, 114);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Base";
            this.lblBase.Visible = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(69, 137);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(123, 20);
            this.txtAltura.TabIndex = 13;
            this.txtAltura.Visible = false;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.Color.Peru;
            this.lblAltura.Location = new System.Drawing.Point(29, 140);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Visible = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(86, 81);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(116, 20);
            this.txtArea.TabIndex = 15;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(51, 84);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Área";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(86, 114);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(116, 20);
            this.txtPerimetro.TabIndex = 17;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(27, 117);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(53, 13);
            this.lblPerimetro.TabIndex = 16;
            this.lblPerimetro.Text = "Perímetro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtPerimetro);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.lblPerimetro);
            this.groupBox1.Location = new System.Drawing.Point(311, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 233);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // Medidas
            // 
            this.Medidas.Controls.Add(this.txtRaio);
            this.Medidas.Controls.Add(this.lblRaio);
            this.Medidas.Controls.Add(this.txtAltura);
            this.Medidas.Controls.Add(this.lblLado);
            this.Medidas.Controls.Add(this.lblAltura);
            this.Medidas.Controls.Add(this.txtLado);
            this.Medidas.Controls.Add(this.txtBase);
            this.Medidas.Controls.Add(this.lblBase);
            this.Medidas.ForeColor = System.Drawing.Color.Black;
            this.Medidas.Location = new System.Drawing.Point(13, 64);
            this.Medidas.Name = "Medidas";
            this.Medidas.Size = new System.Drawing.Size(244, 233);
            this.Medidas.TabIndex = 19;
            this.Medidas.TabStop = false;
            this.Medidas.Text = "Medidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(220, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Objetos das Formas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(573, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medidas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbObjetos);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbTriangulo);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.lblForma);
            this.ForeColor = System.Drawing.Color.Peru;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Formas Geometricas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Medidas.ResumeLayout(false);
            this.Medidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Medidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriar;
    }
}

