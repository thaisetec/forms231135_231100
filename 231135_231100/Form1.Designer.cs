namespace _231135_231100
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
            this.LblVenda = new System.Windows.Forms.Label();
            this.LblQtd = new System.Windows.Forms.Label();
            this.LblProduto = new System.Windows.Forms.Label();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.Txtquantidade = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt = new System.Windows.Forms.Label();
            this.TxtNovaQuantidade = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTtotal = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.Lblvalorvenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVenda
            // 
            this.LblVenda.AutoSize = true;
            this.LblVenda.Location = new System.Drawing.Point(52, 24);
            this.LblVenda.Name = "LblVenda";
            this.LblVenda.Size = new System.Drawing.Size(41, 13);
            this.LblVenda.TabIndex = 0;
            this.LblVenda.Text = "Venda:";
            this.LblVenda.Click += new System.EventHandler(this.LblVenda_Click);
            // 
            // LblQtd
            // 
            this.LblQtd.AutoSize = true;
            this.LblQtd.Location = new System.Drawing.Point(111, 24);
            this.LblQtd.Name = "LblQtd";
            this.LblQtd.Size = new System.Drawing.Size(0, 13);
            this.LblQtd.TabIndex = 1;
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(52, 83);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(47, 13);
            this.LblProduto.TabIndex = 2;
            this.LblProduto.Text = "Produto:";
            this.LblProduto.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(105, 80);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(413, 20);
            this.TxtProduto.TabIndex = 3;
            // 
            // Txtquantidade
            // 
            this.Txtquantidade.Location = new System.Drawing.Point(114, 164);
            this.Txtquantidade.Name = "Txtquantidade";
            this.Txtquantidade.Size = new System.Drawing.Size(237, 20);
            this.Txtquantidade.TabIndex = 4;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(114, 237);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(237, 20);
            this.TxtValor.TabIndex = 5;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(43, 171);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.LblQuantidade.TabIndex = 6;
            this.LblQuantidade.Text = "Quantidade:";
            this.LblQuantidade.Click += new System.EventHandler(this.LblQuantidade_Click);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(38, 240);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(73, 13);
            this.LblValor.TabIndex = 7;
            this.LblValor.Text = "Valor Unitário:";
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(426, 186);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(117, 59);
            this.BtnInserir.TabIndex = 8;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(588, 186);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(112, 59);
            this.BtnRemover.TabIndex = 9;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.VUnitário});
            this.dgvProdutos.Location = new System.Drawing.Point(114, 333);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(586, 150);
            this.dgvProdutos.TabIndex = 10;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // VUnitário
            // 
            this.VUnitário.HeaderText = "VUnitário";
            this.VUnitário.Name = "VUnitário";
            this.VUnitário.ReadOnly = true;
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Location = new System.Drawing.Point(102, 575);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(198, 13);
            this.Txt.TabIndex = 11;
            this.Txt.Text = "Alterar Quantidade do Item Selecionado:";
            this.Txt.Click += new System.EventHandler(this.Txt_Click);
            // 
            // TxtNovaQuantidade
            // 
            this.TxtNovaQuantidade.Location = new System.Drawing.Point(306, 572);
            this.TxtNovaQuantidade.Name = "TxtNovaQuantidade";
            this.TxtNovaQuantidade.Size = new System.Drawing.Size(237, 20);
            this.TxtNovaQuantidade.TabIndex = 12;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(588, 567);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(112, 29);
            this.BtnAlterar.TabIndex = 13;
            this.BtnAlterar.Text = "Alterar Quantidade";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(94, 688);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(83, 13);
            this.LblTotal.TabIndex = 14;
            this.LblTotal.Text = "Total da Venda:";
            this.LblTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // LblTtotal
            // 
            this.LblTtotal.AutoSize = true;
            this.LblTtotal.Location = new System.Drawing.Point(183, 688);
            this.LblTtotal.Name = "LblTtotal";
            this.LblTtotal.Size = new System.Drawing.Size(0, 13);
            this.LblTtotal.TabIndex = 15;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(125, 769);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(126, 56);
            this.BtnGravar.TabIndex = 16;
            this.BtnGravar.Text = "Gravar Venda";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(333, 769);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(126, 56);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar Venda";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(550, 769);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(126, 56);
            this.BtnFinalizar.TabIndex = 18;
            this.BtnFinalizar.Text = "Finalizar Sistema";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // Lblvalorvenda
            // 
            this.Lblvalorvenda.AutoSize = true;
            this.Lblvalorvenda.Location = new System.Drawing.Point(125, 24);
            this.Lblvalorvenda.Name = "Lblvalorvenda";
            this.Lblvalorvenda.Size = new System.Drawing.Size(13, 13);
            this.Lblvalorvenda.TabIndex = 19;
            this.Lblvalorvenda.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 893);
            this.Controls.Add(this.Lblvalorvenda);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.LblTtotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.TxtNovaQuantidade);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.Txtquantidade);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.LblQtd);
            this.Controls.Add(this.LblVenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVenda;
        private System.Windows.Forms.Label LblQtd;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.TextBox Txtquantidade;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VUnitário;
        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.TextBox TxtNovaQuantidade;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblTtotal;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Label Lblvalorvenda;
    }
}

