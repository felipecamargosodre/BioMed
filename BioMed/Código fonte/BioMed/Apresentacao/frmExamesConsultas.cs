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
    public partial class frmExamesConsultas : Form
    {
        int mov;
        int movX;
        int movY;

        public frmExamesConsultas()
        {
            InitializeComponent();
        }

        private void frmExamesConsultas_Load(object sender, EventArgs e)
        {
            lblAC.Visible = false;
            lblVC.Visible = false;
        }

        private void picCadastroUsu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmExames frmE = new frmExames();
            frmE.ShowDialog();
            this.Visible = true;
        }

        private void picCadastroPac_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultas frmC = new frmConsultas();
            frmC.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCadastroPac_MouseEnter(object sender, EventArgs e)
        {
            lblAC.Visible = true;
        }

        private void picCadastroPac_MouseLeave(object sender, EventArgs e)
        {
            lblAC.Visible = false;
        }

        private void picCadastroUsu_MouseEnter(object sender, EventArgs e)
        {
            lblVC.Visible = true;
        }

        private void picCadastroUsu_MouseLeave(object sender, EventArgs e)
        {
            lblVC.Visible = false;
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
    }
}
