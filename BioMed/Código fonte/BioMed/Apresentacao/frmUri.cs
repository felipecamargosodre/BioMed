using BioMed.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioMed.Apresentacao
{
    public partial class frmUri : Form
    {
        int mov;
        int movX;
        int movY;

        public frmUri()
        {
            InitializeComponent();
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlBarra_MouseUp(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.CadastrarExameUrinalise("123", txbCor.Text, txbAspc.Text, txbDens.Text, txbPH.Text, txbPt.Text, txbGli.Text, txbHb.Text, txbNit.Text, txbCels.Text, txbLeuc.Text, txbHem.Text, txbFMuco.Text, txbUro.Text, txbTrinc.Text, txbCil.Text, txbBil.Text, txbBac.Text, txbCrist.Text, txbCet.Text, txbOutros1.Text, txbOutros2.Text);
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
