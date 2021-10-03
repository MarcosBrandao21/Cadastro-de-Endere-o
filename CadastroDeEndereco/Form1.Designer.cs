namespace CadastroDeEndereco
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
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscarCEP = new System.Windows.Forms.Button();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ValidarCEP = new System.Windows.Forms.Label();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logadouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira o CEP";
            // 
            // btBuscarCEP
            // 
            this.btBuscarCEP.Location = new System.Drawing.Point(214, 58);
            this.btBuscarCEP.Name = "btBuscarCEP";
            this.btBuscarCEP.Size = new System.Drawing.Size(75, 23);
            this.btBuscarCEP.TabIndex = 2;
            this.btBuscarCEP.Text = "Buscar CEP";
            this.btBuscarCEP.UseVisualStyleBackColor = true;
            this.btBuscarCEP.Click += new System.EventHandler(this.btBuscarCEP_Click);
            // 
            // tbCidade
            // 
            this.tbCidade.Enabled = false;
            this.tbCidade.Location = new System.Drawing.Point(52, 141);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(237, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // tbUF
            // 
            this.tbUF.Enabled = false;
            this.tbUF.Location = new System.Drawing.Point(306, 141);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(46, 20);
            this.tbUF.TabIndex = 4;
            // 
            // tbBairro
            // 
            this.tbBairro.Enabled = false;
            this.tbBairro.Location = new System.Drawing.Point(431, 141);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(237, 20);
            this.tbBairro.TabIndex = 5;
            // 
            // tbRua
            // 
            this.tbRua.Enabled = false;
            this.tbRua.Location = new System.Drawing.Point(52, 188);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(384, 20);
            this.tbRua.TabIndex = 6;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(55, 60);
            this.mtbCEP.Mask = "00000000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(100, 20);
            this.mtbCEP.TabIndex = 7;
            this.mtbCEP.Click += new System.EventHandler(this.mtbCEP_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(481, 188);
            this.tbNumero.MaxLength = 30;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(187, 20);
            this.tbNumero.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Logadouro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero/complemento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF";
            // 
            // ValidarCEP
            // 
            this.ValidarCEP.AutoSize = true;
            this.ValidarCEP.Enabled = false;
            this.ValidarCEP.ForeColor = System.Drawing.Color.Red;
            this.ValidarCEP.Location = new System.Drawing.Point(55, 87);
            this.ValidarCEP.Name = "ValidarCEP";
            this.ValidarCEP.Size = new System.Drawing.Size(108, 13);
            this.ValidarCEP.TabIndex = 14;
            this.ValidarCEP.Text = "digite um CEP valido*";
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AllowUserToAddRows = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cidade,
            this.UF,
            this.Bairro,
            this.Logadouro,
            this.Numero});
            this.dgvEnderecos.Location = new System.Drawing.Point(52, 264);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.Size = new System.Drawing.Size(616, 174);
            this.dgvEnderecos.TabIndex = 15;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(332, 222);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 16;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Logadouro
            // 
            this.Logadouro.HeaderText = "Logadouro";
            this.Logadouro.Name = "Logadouro";
            this.Logadouro.ReadOnly = true;
            this.Logadouro.Width = 180;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvEnderecos);
            this.Controls.Add(this.ValidarCEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.btBuscarCEP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscarCEP;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ValidarCEP;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logadouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}

