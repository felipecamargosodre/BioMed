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

namespace BioMed.Apresentacao
{
    public partial class frmHistorico : Form
    {
        int mov;
        int movX;
        int movY;

        public frmHistorico()
        {
            InitializeComponent();
        }

        private void cmbIndice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIndice.Text == "Bioquímica")
            {
                SqlDataAdapter da = default(SqlDataAdapter);

                try
                {
                    DataTable dt = new DataTable("bioquimica");
                    Conexao conexao = new Conexao();
                    conexao.Conectar();
                    da = new SqlDataAdapter("select pacientes.nome, bioquimica.prontuario, bioquimica.col, bioquimica.tri, bioquimica.hdl, bioquimica.ldl, bioquimica.vidl, bioquimica.dhe, bioquimica.dhl, bioquimica.crea, bioquimica.bild, bioquimica.tgo, bioquimica.tgp, bioquimica.ferro, bioquimica.prot, bioquimica.bhcg, bioquimica.clor, bioquimica.fal, bioquimica.calc, bioquimica.alb, bioquimica.cpk, bioquimica.acur, bioquimica.phos from " +
                        "bioquimica join pacientes on " +
                        "bioquimica.fk_idPacientes_pacientes = pacientes.idPacientes", conexao.endereco);
                    da.Fill(dt);
                    dgvPacientes.DataSource = dt;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errroooouuuuu");
                }
            }
            if (cmbIndice.Text == "Hematologia")
            {
                SqlDataAdapter da = default(SqlDataAdapter);

                try
                {
                    DataTable dt = new DataTable("hematologia");
                    Conexao conexao = new Conexao();
                    conexao.Conectar();
                    da = new SqlDataAdapter("select pacientes.nome, hematologia.prontuario, hematologia.erit, hematologia.hb, hematologia.ht, hematologia.vmc, hematologia.hmc, hematologia.chcm, hematologia.plaq, hematologia.ret, hematologia.leuc, hematologia.mie, hematologia.met, hematologia.bas, hematologia.seg, hematologia.eos, hematologia.falci, hematologia.baf, hematologia.linT, hematologia.linA, hematologia.mono, hematologia.abo, hematologia.rh, hematologia.vhs, hematologia.outros, hematologia.observacao from " +
                        "hematologia join pacientes on " +
                        "hematologia.fk_idPacientes_pacientes = pacientes.idPacientes", conexao.endereco);
                    da.Fill(dt);
                    dgvPacientes.DataSource = dt;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errroooouuuuu");
                }
            }
            if (cmbIndice.Text == "Microbiologia")
            {
                SqlDataAdapter da = default(SqlDataAdapter);

                try
                {
                    DataTable dt = new DataTable("hematologia");
                    Conexao conexao = new Conexao();
                    conexao.Conectar();
                    da = new SqlDataAdapter("select pacientes.nome, microbiologia.prontuario, microbiologia.mat, microbiologia.gram1, microbiologia.gram2, microbiologia.micr1, microbiologia.micr2, microbiologia.baar, microbiologia.ccol1, microbiologia.ccol2 from " +
                        "microbiologia join pacientes on " +
                        "microbiologia.fk_idPacientes_pacientes = pacientes.idPacientes", conexao.endereco);
                    da.Fill(dt);
                    dgvPacientes.DataSource = dt;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errroooouuuuu");
                }
            }
            if (cmbIndice.Text == "Urinálise")
            {
                SqlDataAdapter da = default(SqlDataAdapter);

                try
                {
                    DataTable dt = new DataTable("hematologia");
                    Conexao conexao = new Conexao();
                    conexao.Conectar();
                    da = new SqlDataAdapter("select pacientes.nome, urinalise.prontuario, urinalise.cor, urinalise.aspc, urinalise.dens, urinalise.ph, urinalise.pt, urinalise.gli, urinalise.hb, urinalise.nit, urinalise.cels, urinalise.leuc, urinalise.hem, urinalise.fmuco, urinalise.uro, urinalise.trin, urinalise.cil, urinalise.bil, urinalise.bac, urinalise.cri, urinalise.cet, urinalise.outros1, urinalise.outros2 from " +
                        "urinalise join pacientes on " +
                        "urinalise.fk_idPacientes_pacientes = pacientes.idPacientes", conexao.endereco);
                    da.Fill(dt);
                    dgvPacientes.DataSource = dt;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Errroooouuuuu");
                }
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
