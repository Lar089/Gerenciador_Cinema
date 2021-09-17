
namespace Gerenciador_Cinema.WindowsForms.Features.ModuleFilme
{
    partial class TabelaFilme
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
            this.dataGridFilme = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFilme
            // 
            this.dataGridFilme.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilme.GridColor = System.Drawing.Color.LightGray;
            this.dataGridFilme.Location = new System.Drawing.Point(0, 42);
            this.dataGridFilme.Name = "dataGridFilme";
            this.dataGridFilme.Size = new System.Drawing.Size(712, 331);
            this.dataGridFilme.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Gerenciador_Cinema.WindowsForms.Properties.Resources.Editar;
            this.btnEditar.Location = new System.Drawing.Point(612, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 30);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = global::Gerenciador_Cinema.WindowsForms.Properties.Resources.Excluir;
            this.btnExcluir.Location = new System.Drawing.Point(654, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 30);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::Gerenciador_Cinema.WindowsForms.Properties.Resources.Adicionar;
            this.btnAdicionar.Location = new System.Drawing.Point(21, 1);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 39);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // TabelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dataGridFilme);
            this.Name = "TabelaFilme";
            this.Size = new System.Drawing.Size(712, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFilme;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}
