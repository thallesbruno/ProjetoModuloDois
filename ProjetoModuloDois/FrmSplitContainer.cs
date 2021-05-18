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
    public partial class FrmSplitContainer : Form
    {
        public FrmSplitContainer()
        {
            InitializeComponent();
        }

        private void FrmSplitContainer_Load(object sender, EventArgs e)
        {
            lstImagens.Items.Add("Italo");
            lstImagens.Items.Add("Img1");
            lstImagens.Items.Add("Img2");
        }

        private void lstImagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagens.SelectedIndices.Count < 1) return;
            if (lstImagens.SelectedIndex == 0)
            {
                lblInformacao.Text = "Imagem do Italo";
                pnlImagem.BackgroundImage = Properties.Resources.PENDURE_ISTO_GW_74_SET20;
            }
            else if (lstImagens.SelectedIndex == 1)
            {
                lblInformacao.Text = "Imagem 1";
                pnlImagem.BackgroundImage = Properties.Resources.WhatsApp_Image_2021_03_03_at_21_02_16;
            } else if (lstImagens.SelectedIndex == 2)
            {
                lblInformacao.Text = "Imagem 2";
                pnlImagem.BackgroundImage = Properties.Resources.WhatsApp_Image_2021_03_10_at_13_22_00;
            }
        }
    }
}