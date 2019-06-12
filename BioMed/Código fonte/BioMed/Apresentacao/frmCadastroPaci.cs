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
using Correios;

namespace BioMed.Apresentacao
{
    public partial class frmCadastroPaci : Form
    {
        int mov;
        int movX;
        int movY;

        public frmCadastroPaci()
        {
            InitializeComponent();
        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            //Limpar prontuário
            string dataNasc = dtnNascimento.Text;
            dataNasc = dtnNascimento.Text.Replace("/", "");
            MessageBox.Show(dataNasc);
            //Limpar CPF
            string numeroCPF = mtxCPF.Text;
            string cpfLimpo = numeroCPF.Replace(",", "").Replace("-", "");
            //Limpar RG
            string numeroRG = mtxRG.Text;
            string rgLimpo = numeroRG.Replace(",", "").Replace("-", "");

                        if (txbNome.Text == "" || txbNomePai.Text == "" || txbNomeMae.Text == "" || mtxRG.Text == "" || mtxCPF.Text == "" || lblAge.Text == "" || mtxCEP.Text == "" || lblRua.Text == "" ||
                            txbNumero.Text == "" || txbBairro.Text == "" || cmbEstado.SelectedIndex < 0 || mtxTelefone.Text == "" || mtxCel.Text == "" || cmbGenero.SelectedIndex < 0 || txbProfissao.Text == ""
                            || txbNacionalidade.Text == "" || txbInstrucao.Text == "")
            {
                MessageBox.Show(lblAge.Text.ToString());
                MessageBox.Show("Preencha todos os campos para continuar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            if (!Estaticos.VerificarCpf(cpfLimpo))
            {
                MessageBox.Show("CPF inválido. Digite um CPF válido para continuar!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxCPF.Text = "";
                mtxCPF.Focus(); return;
            }

            //lblNumProto.Text = DateTime.Now.ToString("yyyyMMdd" + dataNasc);

            Controle controle = new Controle();
            string mensagem = controle.CadastrarPaciente(txbNome.Text, txbNomePai.Text, txbNomeMae.Text,
                rgLimpo, cpfLimpo, Convert.ToDateTime(dtnNascimento.Text), Convert.ToInt32(lblAge.Text), lblRua.Text, txbNumero.Text, txbBairro.Text, cmbEstado.Text, mtxCEP.Text,
                txbCidade.Text, mtxCel.Text, cmbGenero.Text, mtxTelefone.Text, txbProfissao.Text, txbNacionalidade.Text, txbInstrucao.Text, DateTime.Now);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mtxCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                string cep = mtxCEP.Text.Replace("-", "");
                CorreiosApi correios = new CorreiosApi();
                var retorno = correios.consultaCEP(cep);
                cmbEstado.Text = retorno.uf;
                txbCidade.Text = retorno.cidade;
                txbRua.Text = retorno.end;
                txbBairro.Text = retorno.bairro;
            }
            catch (Exception)
            {
                MessageBox.Show("CEP não encontrado");
            }
        }

        private void dtnNascimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = new DateTime();
            DateTime data = DateTime.Now;

            inicio = Convert.ToDateTime(dtnNascimento.Text);
            data = Convert.ToDateTime(data);

            TimeSpan direnrenca = data.Subtract(inicio);

            lblAge.Text = ((direnrenca.Days / 365).ToString());
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
        
        private void LimparCampos()
        {
            //lblNumProto.Text = "";
            txbNome.Text = "";
            txbNomePai.Text = "";
            txbNomeMae.Text = "";
            mtxRG.Text = "";
            mtxCPF.Text = "";
            dtnNascimento.Text = DateTime.Now.ToString();
            txbRua.Text = "";
            txbBairro.Text = "";
            cmbEstado.SelectedIndex = -1;
            txbCidade.Text = "";
            mtxCEP.Text = "";
            mtxCel.Text = "";
            cmbGenero.SelectedIndex = -1;
            mtxTelefone.Text = "";
            txbProfissao.Text = "";
            txbNacionalidade.Text = "";
        }

        private void ChecarCampos()
        {
            if (txbNome.Text == "" || txbNomePai.Text == "" || txbNomeMae.Text == "" || mtxRG.Text == "" || mtxCPF.Text == "" || lblAge.Text == "" || mtxCEP.Text == "" || lblRua.Text == "" ||
            txbNumero.Text == "" || txbBairro.Text == "" || cmbEstado.SelectedIndex < 0 || mtxTelefone.Text == "" || mtxCel.Text == "" || cmbGenero.SelectedIndex < 0 || txbProfissao.Text == ""
            || txbNacionalidade.Text == "" || txbInstrucao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para continuar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
