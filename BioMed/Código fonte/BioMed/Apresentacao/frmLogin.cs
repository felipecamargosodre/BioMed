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
    public partial class frmLogin : Form
    {
        int mov;
        int movX;
        int movY;

        public frmLogin()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            if (txbSenha != null)
            {
                txbSenha.UseSystemPasswordChar = true;
                picBloquear.Hide();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbUsuario.Text = "Usuário";
            txbSenha.Text = "Senha";
        }

        //=======================VISIBILIDADE DO BOTÃO BLOQUEAR/DESBLOQUEAR=======================
        private void picBloquear_Click(object sender, EventArgs e)
        {
            if (txbSenha.UseSystemPasswordChar == false)
            {
                txbSenha.UseSystemPasswordChar = false;
                picDesbloquear.Show();
                picBloquear.Hide();
                txbSenha.UseSystemPasswordChar = true;
            }
        }

        private void picDesbloquear_Click(object sender, EventArgs e)
        {
            if (txbSenha.UseSystemPasswordChar == true)
            {
                txbSenha.UseSystemPasswordChar = true;
                picDesbloquear.Hide();
                picBloquear.Show();
                txbSenha.UseSystemPasswordChar = false;
            }
        }

        //=======================LIMPAR CAIXA DE TEXTO=======================
        private void txbUsuario_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "Usuário")
            {
                txbUsuario.Clear();
            }
            pnlUsuario.Size = new Size(195, 2);
        }

        private void txbSenha_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text == "Senha")
            {
                txbSenha.Clear();
            }
            pnlSenha.Size = new Size(195, 2);
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "Usuário";
            }
            pnlUsuario.Size = new Size(195, 1);
        }

        private void txbSenha_Leave(object sender, EventArgs e)
        {
            if (txbSenha.Text == "")
            {
                txbSenha.Text = "Senha";
            }
            pnlSenha.Size = new Size(195, 1);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txbUsuario.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Estaticos.dominio == "Administrador")
                    {
                        this.Visible = false;
                        frmAdministrador frmA = new frmAdministrador();
                        frmA.ShowDialog();
                    }
                    if (Estaticos.dominio == "Aluno")
                    {
                        this.Visible = false;
                        frmPrincipal frmP = new frmPrincipal();
                        frmP.ShowDialog();
                    }
                    if (Estaticos.dominio == "Triagem")
                    {
                        this.Visible = false;
                        frmTriagem frmT = new frmTriagem();
                        frmT.ShowDialog();
                    }
                    if (Estaticos.dominio == "Coordenador")
                    {
                        this.Visible = false;
                        frmCoordenador frmC = new frmCoordenador();
                        frmC.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login ou senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        //=======================FECHAR/MINIMIZAR FORMULÁRIO=======================
        private void picFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {

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
        //=======================MOVER FORMULÁRIO=======================
    }
}
