
namespace ProjetoModuloDois
{
    partial class FrmSplitContainer
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
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.lstImagens = new System.Windows.Forms.ListBox();
            this.spcConteudo = new System.Windows.Forms.SplitContainer();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.pnlImagem = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcConteudo)).BeginInit();
            this.spcConteudo.Panel1.SuspendLayout();
            this.spcConteudo.Panel2.SuspendLayout();
            this.spcConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcContainer
            // 
            this.spcContainer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.spcContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContainer.Location = new System.Drawing.Point(0, 0);
            this.spcContainer.Name = "spcContainer";
            // 
            // spcContainer.Panel1
            // 
            this.spcContainer.Panel1.Controls.Add(this.lstImagens);
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spcContainer.Panel2.Controls.Add(this.spcConteudo);
            this.spcContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.spcContainer.Size = new System.Drawing.Size(800, 450);
            this.spcContainer.SplitterDistance = 250;
            this.spcContainer.TabIndex = 0;
            // 
            // lstImagens
            // 
            this.lstImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImagens.FormattingEnabled = true;
            this.lstImagens.Location = new System.Drawing.Point(0, 0);
            this.lstImagens.Name = "lstImagens";
            this.lstImagens.Size = new System.Drawing.Size(248, 448);
            this.lstImagens.TabIndex = 0;
            this.lstImagens.SelectedIndexChanged += new System.EventHandler(this.lstImagens_SelectedIndexChanged);
            // 
            // spcConteudo
            // 
            this.spcConteudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcConteudo.Location = new System.Drawing.Point(0, 0);
            this.spcConteudo.Name = "spcConteudo";
            this.spcConteudo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcConteudo.Panel1
            // 
            this.spcConteudo.Panel1.Controls.Add(this.lblInformacao);
            // 
            // spcConteudo.Panel2
            // 
            this.spcConteudo.Panel2.Controls.Add(this.pnlImagem);
            this.spcConteudo.Size = new System.Drawing.Size(544, 448);
            this.spcConteudo.SplitterDistance = 82;
            this.spcConteudo.TabIndex = 0;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformacao.Location = new System.Drawing.Point(0, 0);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(35, 13);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "label1";
            // 
            // pnlImagem
            // 
            this.pnlImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImagem.Location = new System.Drawing.Point(0, 0);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(540, 358);
            this.pnlImagem.TabIndex = 0;
            // 
            // FrmSplitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spcContainer);
            this.Name = "FrmSplitContainer";
            this.Text = "FrmSplitContainer";
            this.Load += new System.EventHandler(this.FrmSplitContainer_Load);
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.spcConteudo.Panel1.ResumeLayout(false);
            this.spcConteudo.Panel1.PerformLayout();
            this.spcConteudo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcConteudo)).EndInit();
            this.spcConteudo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.SplitContainer spcConteudo;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.ListBox lstImagens;
    }
}