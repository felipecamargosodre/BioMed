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
using System.Data.SqlClient;

namespace BioMed.Apresentacao
{
    public partial class frmConsultas : Form
    {
        int mov;
        int movX;
        int movY;
        DateTime dia;
        string pegarDia;
        DateTime startDate = DateTime.Now;
        DataTable dt = new DataTable("pacientes");


        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            DateTime endDate = startDate.AddMonths(0);
            cdrDia.SelectionRange = new SelectionRange(startDate, endDate);
            ListarPacientes();
        }

        private void picSalvar_Click(object sender, EventArgs e)
        {
            long tempo = startDate.Ticks - dia.Ticks;
            TimeSpan tempodias = new TimeSpan(tempo);
            int diasContados = tempodias.Days;

            if (lblNome.Text == "")
            {
                MessageBox.Show("É necessário selecionar um paciente para agendar a consulta"); return;
            }
            if (diasContados > 0)
            {
                MessageBox.Show("Não é possível fazer agendamento para os dias anteriores"); return;
            }
            if (cmbExame.SelectedIndex < 0)
            {
                MessageBox.Show("É necessário selecionar um tipo de exame"); return;
            }

            DialogResult resultado= MessageBox.Show("Agendar consulta para o paciente " + lblNome.Text + "?", "Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("Agendamento de consultado cancelado!"); return;
            }

            Controle controle = new Controle();
            String mensagem = controle.CadastrarExame(dia.ToString("dd/MM/yyyy"), cmbExame.Text);
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

        private void picProcurar_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%'", txbNome.Text);
            dgvPacientes.DataSource = dv.ToTable();
    
            //search for two rows dv.RowFilter = string.Format("Name like '%{0}%' or LasName like '%{0}%'", textBox1.Text);
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPacientes.Rows[e.RowIndex];

                    Estaticos.idPac = Convert.ToInt32(row.Cells["idPacientes"].Value);
                    lblNome.Text = row.Cells["nome"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma linha válida");
            }
        }

        private void cdrDia_DateChanged(object sender, DateRangeEventArgs e)
        {
            dia = cdrDia.SelectionStart;
            pegarDia = cdrDia.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void LimparCampos()
        {
            DateTime endDate = startDate.AddMonths(0);

            txbNome.Text = "";
            lblNome.Text = "";
            cdrDia.SelectionRange = new SelectionRange(startDate, endDate);
            cmbExame.SelectedIndex = -1;
        }

        private void ListarPacientes()
        {
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();
                da = new SqlDataAdapter("select * from pacientes", conexao.endereco);
                da.Fill(dt);
                dgvPacientes.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Errroooouuuuu");
            }

            dgvPacientes.Columns[0].HeaderText = "Código";
            dgvPacientes.Columns[1].HeaderText = "Nome do paciente";
            dgvPacientes.Columns[2].HeaderText = "Nome do pai";
            dgvPacientes.Columns[3].HeaderText = "Nome da mãe";
            dgvPacientes.Columns[4].HeaderText = "RG";
            dgvPacientes.Columns[5].HeaderText = "CPF";
            dgvPacientes.Columns[6].HeaderText = "D. Nasc";
            dgvPacientes.Columns[7].HeaderText = "Idade";
            dgvPacientes.Columns[8].HeaderText = "Rua";
            dgvPacientes.Columns[9].HeaderText = "Número";
            dgvPacientes.Columns[10].HeaderText = "Bairro";
            dgvPacientes.Columns[11].HeaderText = "Estado";
            dgvPacientes.Columns[12].HeaderText = "CEP";
            dgvPacientes.Columns[13].HeaderText = "Cidade";
            dgvPacientes.Columns[14].HeaderText = "Celular";
            dgvPacientes.Columns[15].HeaderText = "Telefone";
            dgvPacientes.Columns[16].HeaderText = "Gênero";
            dgvPacientes.Columns[17].HeaderText = "Profissão";
            dgvPacientes.Columns[18].HeaderText = "Nacionalidade";
            dgvPacientes.Columns[19].HeaderText = "Instrução";
            dgvPacientes.Columns[20].HeaderText = "Cadastro";

            dgvPacientes.Columns[1].Width = 200;

            dgvPacientes.Columns["idPacientes"].Visible = false;
            dgvPacientes.Columns["nome_pai"].Visible = false;
            dgvPacientes.Columns["nome_mae"].Visible = false;
            dgvPacientes.Columns["nome_pai"].Visible = false;
            dgvPacientes.Columns["profissao"].Visible = false;
            dgvPacientes.Columns["nacionalidade"].Visible = false;
            dgvPacientes.Columns["instrucao"].Visible = false;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
