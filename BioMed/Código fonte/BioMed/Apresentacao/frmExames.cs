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
using BioMed.DAL;
using BioMed.Modelo;

namespace BioMed.Apresentacao
{
    public partial class frmExames : Form
    {
        int mov;
        int movX;
        int movY;
        DateTime dia;
        DataTable dt = new DataTable("consultas");

        public frmExames()
        {
            InitializeComponent();
        }

        private void frmExames_Load(object sender, EventArgs e)
        {
            picRealizar.Visible = false;
            if (Estaticos.dominio == "Aluno" || Estaticos.dominio == "Administrador")
            {
                picRealizar.Visible = true;
            }
            ListarPacientes();
        }

        private void cdrDia_DateChanged(object sender, DateRangeEventArgs e)
        {
            dia = cdrDia.SelectionStart;
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("data_cons like '%{0}%'", dia.ToString("dd/MM/yyyy"));
            dgvPacientes.DataSource = dv.ToTable();
        }

        private void picRealizar_Click(object sender, EventArgs e)
        {
            if(Estaticos.tipoExame == "Bioquímica")
            {
                frmBio frmB = new frmBio();
                frmB.ShowDialog();
            }
            if(Estaticos.tipoExame == "Hematologia")
            {
                frmHema frmH = new frmHema();
                frmH.ShowDialog();
            }
            if(Estaticos.tipoExame == "Microbiologia"){
                frmMicro frmM = new frmMicro();
                frmM.ShowDialog();
            }
            if(Estaticos.tipoExame == "Urinálise")
            {
                frmUri frmU = new frmUri();
                frmU.ShowDialog();
            }
        }

        private void ListarPacientes()
        {
            SqlDataAdapter da = default(SqlDataAdapter);
            try
            {
                Conexao conexao = new Conexao();
                conexao.Conectar();
                da = new SqlDataAdapter("select consultas.idConsulta, pacientes.nome, consultas.data_cons, consultas.espec, logins.nome, pacientes.idPacientes from " +
                    "consultas join logins on " +
                    "consultas.fk_idLogins_logins = logins.idLogins " +
                    "join pacientes on " +
                    "consultas.fk_idPacientes_pacientes = pacientes.idPacientes", conexao.endereco);
                da.Fill(dt);
                dgvPacientes.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Errroooouuuuu");
            }

            dgvPacientes.Columns[0].HeaderText = "Código";
            dgvPacientes.Columns[1].HeaderText = "Nome do paciente";
            dgvPacientes.Columns[2].HeaderText = "Agendamento";
            dgvPacientes.Columns[3].HeaderText = "Exame";
            dgvPacientes.Columns[4].HeaderText = "Responsável";

            dgvPacientes.Columns[1].Width = 200;
            dgvPacientes.Columns[2].Width = 130;
            dgvPacientes.Columns[3].Width = 110;
            dgvPacientes.Columns[4].Width = 139;

            dgvPacientes.Columns["idConsulta"].Visible = false;
            dgvPacientes.Columns["idPacientes"].Visible = false;
            
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvPacientes.Rows[e.RowIndex];

                    Estaticos.idPac = Convert.ToInt32(row.Cells["idPacientes"].Value);
                    Estaticos.tipoExame = row.Cells["espec"].Value.ToString();
                    MessageBox.Show(Estaticos.idPac.ToString());
                    MessageBox.Show(Estaticos.tipoExame.ToString());

                    //lblNome.Text = row.Cells["nome"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma linha válida");
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
