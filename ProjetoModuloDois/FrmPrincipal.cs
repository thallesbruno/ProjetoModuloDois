using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModuloDois
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmFlowLayoutPanel());
        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGroupBox());
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPanel());
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmSplitContainer());
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTabControl());
        }

        private void tableLayoutControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmTableLayoutPanel());
            
        }

        private void AbrirFormulario(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
        }
    }
}
