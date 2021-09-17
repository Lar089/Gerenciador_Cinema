
namespace Gerenciador_Cinema.WindowsForms
{
    partial class TelaPrincipalCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalCadastros));
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.Opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFilmes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSessoes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusAplicacao = new System.Windows.Forms.StatusStrip();
            this.statusLabeTela = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripMenu.SuspendLayout();
            this.statusAplicacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opcoes,
            this.MenuItemSalas,
            this.MenuItemFilmes,
            this.MenuItemSessoes});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.StripMenu.Size = new System.Drawing.Size(124, 501);
            this.StripMenu.TabIndex = 1;
            this.StripMenu.Text = "menuStrip1";
            // 
            // Opcoes
            // 
            this.Opcoes.Enabled = false;
            this.Opcoes.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcoes.Image = ((System.Drawing.Image)(resources.GetObject("Opcoes.Image")));
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(115, 34);
            this.Opcoes.Text = "Admin";
            // 
            // MenuItemSalas
            // 
            this.MenuItemSalas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemSalas.Name = "MenuItemSalas";
            this.MenuItemSalas.Size = new System.Drawing.Size(115, 24);
            this.MenuItemSalas.Text = "Salas";
            this.MenuItemSalas.Click += new System.EventHandler(this.MenuItemSalas_Click);
            // 
            // MenuItemFilmes
            // 
            this.MenuItemFilmes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemFilmes.Name = "MenuItemFilmes";
            this.MenuItemFilmes.Size = new System.Drawing.Size(115, 24);
            this.MenuItemFilmes.Text = "Filmes";
            this.MenuItemFilmes.Click += new System.EventHandler(this.MenuItemFilmes_Click);
            // 
            // MenuItemSessoes
            // 
            this.MenuItemSessoes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemSessoes.Name = "MenuItemSessoes";
            this.MenuItemSessoes.Size = new System.Drawing.Size(115, 24);
            this.MenuItemSessoes.Text = "Sessões";
            this.MenuItemSessoes.Click += new System.EventHandler(this.MenuItemSessoes_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 479);
            this.panel1.TabIndex = 2;
            // 
            // statusAplicacao
            // 
            this.statusAplicacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabeTela});
            this.statusAplicacao.Location = new System.Drawing.Point(124, 479);
            this.statusAplicacao.Name = "statusAplicacao";
            this.statusAplicacao.Size = new System.Drawing.Size(698, 22);
            this.statusAplicacao.TabIndex = 3;
            this.statusAplicacao.Text = "Bem vindo!";
            // 
            // statusLabeTela
            // 
            this.statusLabeTela.Name = "statusLabeTela";
            this.statusLabeTela.Size = new System.Drawing.Size(39, 17);
            this.statusLabeTela.Text = "Status";
            // 
            // TelaPrincipalCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusAplicacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StripMenu);
            this.Name = "TelaPrincipalCadastros";
            this.Size = new System.Drawing.Size(822, 501);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.statusAplicacao.ResumeLayout(false);
            this.statusAplicacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem Opcoes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFilmes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSessoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusAplicacao;
        private System.Windows.Forms.ToolStripStatusLabel statusLabeTela;
    }
}
