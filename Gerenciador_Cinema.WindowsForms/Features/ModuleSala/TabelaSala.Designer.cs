
namespace Gerenciador_Cinema.WindowsForms.Features.ModuleSala
{
    partial class TabelaSala
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
            this.dataGridSala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSala)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSala
            // 
            this.dataGridSala.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSala.GridColor = System.Drawing.Color.LightGray;
            this.dataGridSala.Location = new System.Drawing.Point(0, 0);
            this.dataGridSala.Name = "dataGridSala";
            this.dataGridSala.Size = new System.Drawing.Size(712, 373);
            this.dataGridSala.TabIndex = 0;
            // 
            // TabelaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridSala);
            this.Name = "TabelaSala";
            this.Size = new System.Drawing.Size(712, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSala;
    }
}
