
namespace Gerenciador_Cinema.WindowsForms.Features.ModuleSessao
{
    partial class TabelaSessao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridSessao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Gerenciador_Cinema.WindowsForms.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(654, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::Gerenciador_Cinema.WindowsForms.Properties.Resources.Adicionar;
            this.btnAdicionar.Location = new System.Drawing.Point(21, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 39);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridSessao
            // 
            this.dataGridSessao.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridSessao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSessao.GridColor = System.Drawing.Color.LightGray;
            this.dataGridSessao.Location = new System.Drawing.Point(0, 41);
            this.dataGridSessao.Name = "dataGridSessao";
            this.dataGridSessao.Size = new System.Drawing.Size(712, 331);
            this.dataGridSessao.TabIndex = 3;
            // 
            // TabelaSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridSessao);
            this.Name = "TabelaSessao";
            this.Size = new System.Drawing.Size(712, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSessao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridSessao;
    }
}
