namespace Loja
{
    partial class FrmLoja
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorcompra = new System.Windows.Forms.Label();
            this.lblValordesconto = new System.Windows.Forms.Label();
            this.lblValorpagar = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxValorcompra = new System.Windows.Forms.TextBox();
            this.textBoxValordesc = new System.Windows.Forms.TextBox();
            this.textBoxValorpagar = new System.Windows.Forms.TextBox();
            this.textBoxMensagem = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(42, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(42, 76);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValorcompra
            // 
            this.lblValorcompra.AutoSize = true;
            this.lblValorcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorcompra.Location = new System.Drawing.Point(43, 177);
            this.lblValorcompra.Name = "lblValorcompra";
            this.lblValorcompra.Size = new System.Drawing.Size(103, 20);
            this.lblValorcompra.TabIndex = 2;
            this.lblValorcompra.Text = "Valor compra";
            // 
            // lblValordesconto
            // 
            this.lblValordesconto.AutoSize = true;
            this.lblValordesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValordesconto.Location = new System.Drawing.Point(43, 224);
            this.lblValordesconto.Name = "lblValordesconto";
            this.lblValordesconto.Size = new System.Drawing.Size(119, 20);
            this.lblValordesconto.TabIndex = 3;
            this.lblValordesconto.Text = "Valor Desconto";
            // 
            // lblValorpagar
            // 
            this.lblValorpagar.AutoSize = true;
            this.lblValorpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorpagar.Location = new System.Drawing.Point(43, 270);
            this.lblValorpagar.Name = "lblValorpagar";
            this.lblValorpagar.Size = new System.Drawing.Size(104, 20);
            this.lblValorpagar.TabIndex = 4;
            this.lblValorpagar.Text = "Valor a pagar";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(42, 316);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(88, 20);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Mensagem";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(171, 31);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(163, 20);
            this.textBoxCliente.TabIndex = 7;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.TextBoxCliente_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(171, 76);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(163, 20);
            this.textBoxQuantidade.TabIndex = 8;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.TextBoxQuantidade_TextChanged);
            // 
            // textBoxValorcompra
            // 
            this.textBoxValorcompra.Location = new System.Drawing.Point(171, 179);
            this.textBoxValorcompra.Name = "textBoxValorcompra";
            this.textBoxValorcompra.Size = new System.Drawing.Size(163, 20);
            this.textBoxValorcompra.TabIndex = 9;
            this.textBoxValorcompra.TextChanged += new System.EventHandler(this.TextBoxValorcompra_TextChanged);
            // 
            // textBoxValordesc
            // 
            this.textBoxValordesc.Location = new System.Drawing.Point(171, 223);
            this.textBoxValordesc.Name = "textBoxValordesc";
            this.textBoxValordesc.Size = new System.Drawing.Size(163, 20);
            this.textBoxValordesc.TabIndex = 10;
            this.textBoxValordesc.TextChanged += new System.EventHandler(this.TextBoxValordesc_TextChanged);
            // 
            // textBoxValorpagar
            // 
            this.textBoxValorpagar.Location = new System.Drawing.Point(171, 270);
            this.textBoxValorpagar.Name = "textBoxValorpagar";
            this.textBoxValorpagar.Size = new System.Drawing.Size(163, 20);
            this.textBoxValorpagar.TabIndex = 11;
            this.textBoxValorpagar.TextChanged += new System.EventHandler(this.TextBoxValorpagar_TextChanged);
            // 
            // textBoxMensagem
            // 
            this.textBoxMensagem.Location = new System.Drawing.Point(171, 316);
            this.textBoxMensagem.Name = "textBoxMensagem";
            this.textBoxMensagem.Size = new System.Drawing.Size(430, 20);
            this.textBoxMensagem.TabIndex = 12;
            this.textBoxMensagem.TextChanged += new System.EventHandler(this.TextBoxMensagem_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(171, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(163, 32);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(419, 368);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(526, 368);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 404);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textBoxMensagem);
            this.Controls.Add(this.textBoxValorpagar);
            this.Controls.Add(this.textBoxValordesc);
            this.Controls.Add(this.textBoxValorcompra);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblValorpagar);
            this.Controls.Add(this.lblValordesconto);
            this.Controls.Add(this.lblValorcompra);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmLoja";
            this.Text = "Loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorcompra;
        private System.Windows.Forms.Label lblValordesconto;
        private System.Windows.Forms.Label lblValorpagar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxValorcompra;
        private System.Windows.Forms.TextBox textBoxValordesc;
        private System.Windows.Forms.TextBox textBoxValorpagar;
        private System.Windows.Forms.TextBox textBoxMensagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

