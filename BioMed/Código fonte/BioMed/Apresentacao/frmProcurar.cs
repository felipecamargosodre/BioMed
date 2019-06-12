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
    public partial class frmProcurar : Form
    {
        int mov;
        int movX;
        int movY;

        public frmProcurar()
        {
            InitializeComponent();
        }

        private void picCadastroUsu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaUsu frmPU = new frmPesquisaUsu();
            frmPU.ShowDialog();
            this.Visible = true;
        }

        private void picCadastroPac_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaPaci frmPP = new frmPesquisaPaci();
            frmPP.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHistorico frmH = new frmHistorico();
            frmH.ShowDialog();
            this.Visible = true;
        }

        private void picCadastroUsu_MouseEnter(object sender, EventArgs e)
        {
            this.lblPU.Visible = true;
        }

        private void picCadastroUsu_MouseLeave(object sender, EventArgs e)
        {
            this.lblPU.Visible = false;
        }

        private void picCadastroPac_MouseEnter(object sender, EventArgs e)
        {
            this.lblPP.Visible = true;
        }

        private void picCadastroPac_MouseLeave(object sender, EventArgs e)
        {
            this.lblPP.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.lblPH.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.lblPH.Visible = false;
        }

        private void frmProcurar_Load(object sender, EventArgs e)
        {
            lblPU.Visible = false;
            lblPP.Visible = false;
            lblPH.Visible = false;
            if (Estaticos.dominio == "Administrador" || Estaticos.dominio == "Coordenador")
            {
                pnlSegundo.Visible = false;
            }
            else
            {
                lblPH2.Visible = false;
                lblPP2.Visible = false;
                pnlPrincipal.Visible = false;
            }
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            lblPP2.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            lblPP2.Visible = false;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            lblPH2.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            lblPH2.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaPaci frmPP = new frmPesquisaPaci();
            frmPP.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmHistorico frmH = new frmHistorico();
            frmH.ShowDialog();
            this.Visible = true;
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
