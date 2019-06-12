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
    public partial class frmCadastroUsu : Form
    {
        int mov;
        int movX;
        int movY;

        string CpfLimpo = "";

        public frmCadastroUsu()
        {
            InitializeComponent();
            if (txbSenha != null)
            {
                txbSenha.UseSystemPasswordChar = true;
                picBloquear.Hide();
            }
            if (txbConfirmarSenha != null)
            {
                txbConfirmarSenha.UseSystemPasswordChar = true;
                picBloquear1.Hide();
            }
        }


        private void frmCadastroUsu_Load(object sender, EventArgs e)
        {
        }

        private void mtxCpf_Validated(object sender, EventArgs e)
        {
            picSalvar.Enabled = false;
            if (Estaticos.VerificarCpf(mtxCpf.Text))
            {
                MessageBox.Show("CPF VÁLIDO");
                picSalvar.Enabled = true;
            }
            else
            {
                MessageBox.Show("CPF INVÁLIDO");
            }
        }

        private void mtxCpf_TextChanged(object sender, EventArgs e)
        {
            string NumeroCPF = mtxCpf.Text;
            if (Estaticos.VerificarCpf(NumeroCPF))
            {
                //MessageBox.Show("CPF VÁLIDO");


            }
            else
            {
                //MessageBox.Show("CPF INVÁLIDO");
            }
        }

        private void AtivarCadastro()
        {
            if(txbUsuario.Text != "" && txbSenha.Text != "" && txbConfirmarSenha.Text != "" && txbNome.Text != "" && CpfLimpo != "" && cmbNivel.Text != "")
            {
                picSalvar.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            string NumeroCPF = mtxCpf.Text;
            string CpfLimpo = NumeroCPF.Replace(",", "").Replace("-", "");

            if (txbUsuario.Text == "" || txbSenha.Text == ""|| txbConfirmarSenha.Text == "" || txbNome.Text == "")
            {
                MessageBox.Show("Insira os textos"); return;
            }

            Controle controle = new Controle();
            String mensagem = controle.Cadastrar(txbUsuario.Text, txbSenha.Text, txbConfirmarSenha.Text,
                txbNome.Text, CpfLimpo, cmbNivel.Text, DateTime.Now);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

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

        private void picBloquear1_Click(object sender, EventArgs e)
        {
            if (txbConfirmarSenha.UseSystemPasswordChar == false)
            {
                txbConfirmarSenha.UseSystemPasswordChar = false;
                picDesbloquear1.Show();
                picBloquear1.Hide();
                txbConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void picDesbloquear1_Click(object sender, EventArgs e)
        {
            if (txbConfirmarSenha.UseSystemPasswordChar == true)
            {
                txbConfirmarSenha.UseSystemPasswordChar = true;
                picDesbloquear1.Hide();
                picBloquear1.Show();
                txbConfirmarSenha.UseSystemPasswordChar = false;
            }
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
            mov = 0;
        }

        private void pnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        //==============================================================

        //
        private void LimparCampos()
        {
            txbUsuario.Text = "";
            txbSenha.Text = "";
            txbConfirmarSenha.Text = "";
            txbNome.Text = "";
            mtxCpf.Text = "";
            cmbNivel.SelectedIndex = -1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
