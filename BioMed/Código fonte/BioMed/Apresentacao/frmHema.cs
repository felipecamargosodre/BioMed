using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioMed.Modelo;

namespace BioMed.Apresentacao
{
    public partial class frmHema : Form
    {
        int mov;
        int movX;
        int movY;

        public frmHema()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.CadastrarExameHematologia("123", txbErit.Text, txbHb.Text, txbHt.Text, txbVmc.Text, txbHmc.Text, txbChcm.Text, txbPlaq.Text, txbRet.Text, txbLeuc.Text, txbMie.Text, txbMet.Text, txbBas.Text, txbSeg.Text, txbEos.Text, txbFalci.Text, txbBaf.Text, txbLinT.Text, txbLinA.Text, txbMono.Text, txbAbo.Text, txbRh.Text, txbVhs.Text, txbOutras.Text, txbObs.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
