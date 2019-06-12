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
using BioMed.DAL;

namespace BioMed.Apresentacao
{
    public partial class frmBio : Form
    {
        int mov;
        int movX;
        int movY;

        public frmBio()
        {
            InitializeComponent();
        }

        //=======================MOVER FORMULÁRIO=======================
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
            string mensagem = controle.CadastrarExameBioquimica("123", txbCol.Text, txbTri.Text, txbHdl.Text, txbLdl.Text, txbVd.Text, txbDhe.Text, txbDhl.Text, txbCre.Text, txbBD.Text, txbTgo.Text, txbTgp.Text, txbFerro.Text, txbProt.Text, txbBhcg.Text, txbClor.Text, txbFal.Text, txbCalcio.Text, txbAlb.Text, txbCpk.Text, txbAU.Text, txbPhos.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
        //=======================MOVER FORMULÁRIO=======================
    }
}
