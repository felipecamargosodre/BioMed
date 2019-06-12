using BioMed.DAL;
using BioMed.Modelo;
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

namespace BioMed.Apresentacao
{
    public partial class frmPesquisaUsu : Form
    {
        int mov;
        int movX;
        int movY;
        DataTable dt = new DataTable("pacientes");
        String usuario;
        String dominio;

        public frmPesquisaUsu()
        {
            InitializeComponent();
        }

        private void frmPesquisaUsu_Load(object sender, EventArgs e)
        {
            pnlApagar.Visible = false;
            if (Estaticos.dominio == "Administrador" || Estaticos.dominio == "Coordenador")
            {
                pnlApagar.Visible = true;
            }
            ListarPacientes();
        }

        private void ListarPacientes()
        {
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();
                da = new SqlDataAdapter("select * from logins", conexao.endereco);
                da.Fill(dt);
                dgvPacientes.DataSource = dt;

                conexao.Desconectar();
            }
            catch (SqlException)
            {
                MessageBox.Show("Errroooouuuuu");
            }

            dgvPacientes.Columns[0].HeaderText = "Código";
            dgvPacientes.Columns[1].HeaderText = "Usuário";
            dgvPacientes.Columns[2].HeaderText = "Senha";
            dgvPacientes.Columns[3].HeaderText = "Nome";
            dgvPacientes.Columns[4].HeaderText = "CPF";
            dgvPacientes.Columns[5].HeaderText = "Dominío";
            dgvPacientes.Columns[6].HeaderText = "Data de cadastro";

            dgvPacientes.Columns["idLogins"].Visible = false;
            dgvPacientes.Columns["senha"].Visible = false;

            dgvPacientes.Columns[1].Width = 200;
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                try
                {

                    DataGridViewRow row = this.dgvPacientes.Rows[e.RowIndex];

                    usuario = row.Cells["usuario"].Value.ToString();
                    dominio = row.Cells["dominio"].Value.ToString();

                    //lblNome.Text = row.Cells["nome"].Value.ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma linha válida");
                }
            }
        }

        private void picProcurar_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("nome like '%{0}%'", txbNome.Text);
            dgvPacientes.DataSource = dv.ToTable();
        }

        private void picApagar_Click(object sender, EventArgs e)
        {
            if (dominio == "Administrador")
            {
                MessageBox.Show("Não é possível excluir esse tipo de usuário"); return;
            }

            Controle controle = new Controle();
            String mensagem = controle.DeletarLogin(usuario);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
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
