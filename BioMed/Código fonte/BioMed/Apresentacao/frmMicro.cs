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
    public partial class frmMicro : Form
    {
        int mov;
        int movX;
        int movY;

        public frmMicro()
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
            string mensagem = controle.CadastrarExameMicrobiologia("123", txbMat.Text, txbGram.Text, txbGram1.Text, txbMicr1.Text, txbMicr2.Text, txbBaar.Text, txbCC.Text, txbCC1.Text);
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
