using BioMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioMed.Modelo;

namespace BioMed.Apresentacao
{
    public partial class frmPesquisaPaci : Form
    {
        int mov;
        int movX;
        int movY;

        string cpf;
        DataTable dt = new DataTable("pacientes");

        public frmPesquisaPaci()
        {
            InitializeComponent();
            ListarPacientes();
        }

        private void frmPesquisaPaci_Load(object sender, EventArgs e)
        {
            this.pnlApagar.Visible = false;
            if (Estaticos.dominio == "Administrador" || Estaticos.dominio == "Coordenador")
            {
                pnlApagar.Visible = true;
            }
        }

        private void picProcurar_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%' or cpf like '%{0}%'", txbNome.Text);
            dgvPacientes.DataSource = dv.ToTable();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPacientes.Rows[e.RowIndex];

                    cpf = row.Cells["cpf"].Value.ToString();
                    MessageBox.Show(cpf);
                    Estaticos.idPac = Convert.ToInt32(row.Cells["idPacientes"].Value);
                    //lblNome.Text = row.Cells["nome"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma linha válida");
            }
        }

        public void ListarPacientes()
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
        }

        private void picApagar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.DeletarPaciente(cpf);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
