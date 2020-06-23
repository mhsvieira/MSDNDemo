namespace MSDNDemo
{
    partial class frmMSDNDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMSDNDemo = new System.Windows.Forms.DataGridView();
            this.btnAtualizaLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibições = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respostas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSDNDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMSDNDemo
            // 
            this.dgvMSDNDemo.AllowUserToAddRows = false;
            this.dgvMSDNDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMSDNDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Postagem,
            this.Exibições,
            this.Respostas,
            this.Link});
            this.dgvMSDNDemo.Location = new System.Drawing.Point(12, 59);
            this.dgvMSDNDemo.Name = "dgvMSDNDemo";
            this.dgvMSDNDemo.Size = new System.Drawing.Size(914, 369);
            this.dgvMSDNDemo.TabIndex = 0;
            this.dgvMSDNDemo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMSDNDemo_CellClick);
            // 
            // btnAtualizaLista
            // 
            this.btnAtualizaLista.Location = new System.Drawing.Point(398, 16);
            this.btnAtualizaLista.Name = "btnAtualizaLista";
            this.btnAtualizaLista.Size = new System.Drawing.Size(142, 23);
            this.btnAtualizaLista.TabIndex = 1;
            this.btnAtualizaLista.Text = "Atualizar Lista/Pesquisar";
            this.btnAtualizaLista.UseVisualStyleBackColor = true;
            this.btnAtualizaLista.Click += new System.EventHandler(this.btnAtualizaLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Página: ";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(564, 16);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(664, 16);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(75, 23);
            this.btnProxima.TabIndex = 5;
            this.btnProxima.Text = "Próxima";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(76, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(293, 20);
            this.txtPesquisa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pesquisa:";
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            this.Título.Width = 300;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.Width = 150;
            // 
            // Exibições
            // 
            this.Exibições.HeaderText = "Exibições";
            this.Exibições.Name = "Exibições";
            // 
            // Respostas
            // 
            this.Respostas.HeaderText = "Respostas";
            this.Respostas.Name = "Respostas";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 200;
            // 
            // frmMSDNDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizaLista);
            this.Controls.Add(this.dgvMSDNDemo);
            this.Name = "frmMSDNDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Scraping MSDN Demo 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMSDNDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMSDNDemo;
        private System.Windows.Forms.Button btnAtualizaLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibições;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respostas;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
    }
}

