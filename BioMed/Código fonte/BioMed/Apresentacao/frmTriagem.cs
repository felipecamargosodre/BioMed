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
    public partial class frmTriagem : Form
    {
        int mov;
        int movX;
        int movY;

        public frmTriagem()
        {
            InitializeComponent();
        }

        private void picCadastro_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            frmCadastroPaci frmCP = new frmCadastroPaci();
            frmCP.ShowDialog();
            this.Visible = true;
        }

        private void picDesbloqueio_Click(object sender, EventArgs e)
        {
            lblApresentacao.Visible = false;
            tmrPrincipal.Start();
        }

        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {
            pnlPrincipal.Left -= 7;
            picDesbloqueio.Left -= 7;
            if (pnlPrincipal.Left <= 0)
            {
                tmrPrincipal.Stop();
                tmrBotao.Start();
            }
        }

        private void tmrBotao_Tick(object sender, EventArgs e)
        {
            pnlBotao.Top -= 3;
            if (pnlBotao.Top <= 305)
            {
                tmrBotao.Stop();
                tmrCircular.Start();
            }
        }

        private void tmrCircular_Tick(object sender, EventArgs e)
        {
            pnlHora.Left -= 7;
            if (pnlHora.Left <= 0)
            {
                tmrCircular.Stop();
            }
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblSegundos.Text = DateTime.Now.ToString("ss");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            circularProgressBar1.Value = Convert.ToInt32(lblSegundos.Text);
        }

        //=======================MOVER FORMULÁRIO=======================
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

        private void picProcurar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmExamesConsultas frmC = new frmExamesConsultas();
            frmC.ShowDialog();
            this.Visible = true;
        }

        private void picAgendamento_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmProcurar frmEC = new frmProcurar();
            frmEC.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        //=======================MOVER FORMULÁRIO=======================
    }
}
