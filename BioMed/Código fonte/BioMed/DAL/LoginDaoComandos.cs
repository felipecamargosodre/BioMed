using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioMed.Modelo;

namespace BioMed.DAL
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool VerficarLogin(String login, String senha, String dominio)
        {
            //Comandos sql para verificar se tem no BD
            cmd.CommandText = "select * from logins where usuario = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login).ToString();
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//foi encontrado?
                {
                    dr.Read();
                    Estaticos.idUser = Convert.ToInt32(dr[0]);
                    Estaticos.usuario = dr[1].ToString();
                    Estaticos.nomeUsuario = dr[3].ToString();
                    Estaticos.dominio = dr[5].ToString();
                    tem = true;                    
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de dados!";
            }
            return tem;
        }

        public String CadastrarUsuario(String usuario, String senha, String confSenha, String nome, String cpf, String dominio, DateTime data)
        {
            tem = false;
            //Cadastra novo usuário
            if (!ChecarUsuario(usuario))
            {
                if (senha.Equals(confSenha))
                {
                    cmd.CommandText = "insert into logins values (@usuario, @senha, @nome, @cpf, @dominio, @dataCadastro)";
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@dominio", dominio);
                    cmd.Parameters.AddWithValue("@dataCadastro", data);

                    try
                    {
                        cmd.Connection = con.Conectar();
                        cmd.ExecuteNonQuery();
                        con.Desconectar();
                        this.mensagem = "Cadastrado com sucesso";
                        tem = true;
                    }
                    catch (SqlException)
                    {
                        this.mensagem = "Erro com Bando de dados!";
                    }
                }
                else
                {
                    this.mensagem = "Senhas não correspondem";
                }
            }
            else
            {
                this.mensagem = "Já existe um usuário com esse login";
            }
            return mensagem;
        }

        public String CadastrarPaciente(String nome, String nomePai,
                                        String nomeMae, String rg, String cpf, DateTime nascimento, int idade,
                                        String endereco, String numero, String bairro, String estado, String cep, String cidade, String celular, String genero,
                                        String telefone, String profissao, String nacionalidade, String instrucao, DateTime dataCad)
        {
            if (!ChecarPaciente(cpf))
            {
                cmd.CommandText = "insert into pacientes values (@nome," +
                    " @nome_pai, @nome_mae, @rg, @cpf, @nascimento, @idade, @rua, @numero, @bairro, " +
                    "@estado, @cep, @cidade, @celular, @telefone, @genero, @profissao, @nacionalidade, @instrucao, @data_cad)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@nome_pai", nomePai);
                cmd.Parameters.AddWithValue("@nome_mae", nomeMae);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@rua", endereco);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@profissao", profissao);
                cmd.Parameters.AddWithValue("@nacionalidade", nacionalidade);
                cmd.Parameters.AddWithValue("@instrucao", instrucao);
                cmd.Parameters.AddWithValue("@data_cad", dataCad);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Bando de dados!";
                }
            }
            else
            {
                this.mensagem = "Já existe um usuário cadastro com esse CPF";
            }
            Estaticos.dominio = cpf;
            return this.mensagem;
        }

        public String CadastrarExame(String dataConsulta, String exame)
        {
            tem = false;
            //Cadastra novo usuário

            cmd.CommandText = "insert into consultas values (@data_cons, @espec, @fk_idLogins_logins, @fk_idPacientes_pacientes)";
            cmd.Parameters.AddWithValue("@data_cons", dataConsulta);
            cmd.Parameters.AddWithValue("@espec", exame);
            cmd.Parameters.AddWithValue("@fk_idLogins_logins", Estaticos.idUser);
            cmd.Parameters.AddWithValue("@fk_idPacientes_pacientes", Estaticos.idPac);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Agendamento realizado com sucesso!";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String CadastrarExameBioquimica(String prontuario, String col, String tri, String hdl, String ldl, String vidl, String @dhe, String dhl, String crea, String bild, String tgo, String tgp, String ferro, String prot, String bhcg, String clor, String fal, String calc, String alb, String cpk, String acur, String phos)
        {
            tem = false;
            //Cadastra novo usuário

            cmd.CommandText = "insert into bioquimica values (@prontuario, @col, @tri, @hdl, @ldl, @vidl, @dhe, @dhl, @crea, @bild, @tgo, @tgp, @ferro, @prot, @bhcg, @clor, @fal, @calc, " +
                "@alb, @cpk, @acur, @phos, @fk_idPacientes_pacientes)";

            cmd.Parameters.AddWithValue("@prontuario", prontuario);
            cmd.Parameters.AddWithValue("@col", col);
            cmd.Parameters.AddWithValue("@tri", tri);
            cmd.Parameters.AddWithValue("@hdl", hdl);
            cmd.Parameters.AddWithValue("@ldl", ldl);
            cmd.Parameters.AddWithValue("@vidl", vidl);
            cmd.Parameters.AddWithValue("@dhe", dhe);
            cmd.Parameters.AddWithValue("@dhl", dhl);
            cmd.Parameters.AddWithValue("@crea", crea);
            cmd.Parameters.AddWithValue("@bild", bild);
            cmd.Parameters.AddWithValue("@tgo", tgo);
            cmd.Parameters.AddWithValue("@tgp", tgp);
            cmd.Parameters.AddWithValue("@ferro", ferro);
            cmd.Parameters.AddWithValue("@prot", prot);
            cmd.Parameters.AddWithValue("@bhcg", bhcg);
            cmd.Parameters.AddWithValue("@clor", clor);
            cmd.Parameters.AddWithValue("@fal", fal);
            cmd.Parameters.AddWithValue("@calc", calc);
            cmd.Parameters.AddWithValue("@alb", alb);
            cmd.Parameters.AddWithValue("@cpk", cpk);
            cmd.Parameters.AddWithValue("@acur", acur);
            cmd.Parameters.AddWithValue("@phos", phos);
            cmd.Parameters.AddWithValue("@fk_idPacientes_pacientes", Estaticos.idPac);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String CadastrarExameHematologia(String prontuario, String erit, String hb, String ht, String vmc, String hmc, String chcm, String plaq, String ret, String leuc, String mie, String met, String bas, String seg, String eos, String falci, String baf, String linT, String linA, String mono, String abo, String rh, String vhs, String outros, String observacao)
        {
            tem = false;
            //Cadastra novo usuário

            cmd.CommandText = "insert into hematologia values (@prontuario, @erit, @hb, @ht, @vmc, @hmc, @chcm, @plaq, @ret, @leuc, @mie, @met, @bas, @seg, @eos, @falci, @baf, @linT, @linA, " +
                "@mono, @abo, @rh, @vhs, @outros, @observacao, @fk_idPacientes_pacientes)";

            cmd.Parameters.AddWithValue("@prontuario", prontuario);
            cmd.Parameters.AddWithValue("@erit", erit);
            cmd.Parameters.AddWithValue("@hb", hb);
            cmd.Parameters.AddWithValue("@ht", ht);
            cmd.Parameters.AddWithValue("@vmc", vmc);
            cmd.Parameters.AddWithValue("@hmc", hmc);
            cmd.Parameters.AddWithValue("@chcm", chcm);
            cmd.Parameters.AddWithValue("@plaq", plaq);
            cmd.Parameters.AddWithValue("@ret", ret);
            cmd.Parameters.AddWithValue("@leuc", leuc);
            cmd.Parameters.AddWithValue("@mie", mie);
            cmd.Parameters.AddWithValue("@met", met);
            cmd.Parameters.AddWithValue("@bas", bas);
            cmd.Parameters.AddWithValue("@seg", seg);
            cmd.Parameters.AddWithValue("@eos", eos);
            cmd.Parameters.AddWithValue("@falci", falci);
            cmd.Parameters.AddWithValue("@baf", baf);
            cmd.Parameters.AddWithValue("@linT", linT);
            cmd.Parameters.AddWithValue("@linA", linA);
            cmd.Parameters.AddWithValue("@mono", mono);
            cmd.Parameters.AddWithValue("@abo", abo);
            cmd.Parameters.AddWithValue("@rh", rh);
            cmd.Parameters.AddWithValue("@vhs", vhs);
            cmd.Parameters.AddWithValue("@outros", outros);
            cmd.Parameters.AddWithValue("@observacao", observacao);
            cmd.Parameters.AddWithValue("@fk_idPacientes_pacientes", Estaticos.idPac);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String CadastrarExameMicrobiologia(String prontuario, String mat, String gram1, String gram2, String micr1, String micr2, String baar, String ccol1, String ccol2)
        {
            tem = false;
            //Cadastra novo usuário
            cmd.CommandText = "insert into microbiologia values (@prontuario, @mat, @gram1, @gram2, @micr1," +
                " @micr2, @baar, @ccol1, @ccol2, @fk_idPacientes_pacientes)";

            cmd.Parameters.AddWithValue("@prontuario", prontuario);
            cmd.Parameters.AddWithValue("@mat", mat);
            cmd.Parameters.AddWithValue("@gram1", gram1);
            cmd.Parameters.AddWithValue("@gram2", gram2);
            cmd.Parameters.AddWithValue("@micr1", micr1);
            cmd.Parameters.AddWithValue("@micr2", micr2);
            cmd.Parameters.AddWithValue("@baar", baar);
            cmd.Parameters.AddWithValue("@ccol1", ccol1);
            cmd.Parameters.AddWithValue("@ccol2", ccol2);
            cmd.Parameters.AddWithValue("@fk_idPacientes_pacientes", Estaticos.idPac);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String CadastrarExameUrinalise(String prontuario, String cor, String aspc, String dens, String ph, String pt, String gli, String hb, String nit, String cels, String leuc, String hem, String fmuco, String uro, String trin, String cil, String bil, String bac, String cri, String cet, String outros1, String outros2)
        {
            tem = false;
            //Cadastra novo usuário

            cmd.CommandText = "insert into urinalise values (@prontuario, @cor, @aspc, @dens, @ph, @pt, " +
                "@gli, @hb, @nit, @cels, @leuc, @hem, @fmuco, @uro, @trin, @cil, @bil, @bac, @cri, " +
                "@cet, @outros1, @outros2, @fk_idPacientes_pacientes)";

            cmd.Parameters.AddWithValue("@prontuario", prontuario);
            cmd.Parameters.AddWithValue("@cor", cor);
            cmd.Parameters.AddWithValue("@aspc", aspc);
            cmd.Parameters.AddWithValue("@dens", dens);
            cmd.Parameters.AddWithValue("@ph", ph);
            cmd.Parameters.AddWithValue("@pt", pt);
            cmd.Parameters.AddWithValue("@gli", gli);
            cmd.Parameters.AddWithValue("@hb", hb);
            cmd.Parameters.AddWithValue("@nit", nit);
            cmd.Parameters.AddWithValue("@cels", cels);
            cmd.Parameters.AddWithValue("@leuc", leuc);
            cmd.Parameters.AddWithValue("@hem", hem);
            cmd.Parameters.AddWithValue("@fmuco", fmuco);
            cmd.Parameters.AddWithValue("@uro", uro);
            cmd.Parameters.AddWithValue("@trin", trin);
            cmd.Parameters.AddWithValue("@cil", cil);
            cmd.Parameters.AddWithValue("@bil", bil);
            cmd.Parameters.AddWithValue("@bac", bac);
            cmd.Parameters.AddWithValue("@cri", cri);
            cmd.Parameters.AddWithValue("@cet", cet);
            cmd.Parameters.AddWithValue("@outros1", outros1);
            cmd.Parameters.AddWithValue("@outros2", outros2);
            cmd.Parameters.AddWithValue("@fk_idPacientes_pacientes", Estaticos.idPac);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Cadastrado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String DeletarLogins(String usuario)
        {
            tem = false;

            cmd.CommandText = "delete from logins where usuario = @usuario";

            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Deletado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public String DeletarPaciente(String cpf)
        {
            tem = false;

            cmd.CommandText = "delete from pacientes where cpf = @cpf";

            cmd.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "Deletado com sucesso";
                tem = true;
            }
            catch (Exception)
            {
                this.mensagem = "Erro com Bando de dados!";
            }
            return mensagem;
        }

        public bool ChecarUsuario(String login)
        {
            tem = false;

            cmd.CommandText = "select * from logins where usuario = @login";
            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//foi encontrado?
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de dados!";
            }
            return tem;
        }

        public bool ChecarPaciente(String cpf1)
        {
            tem = false;

            cmd.CommandText = "select * from pacientes where cpf = @cpf1";
            cmd.Parameters.AddWithValue("@cpf1", cpf1);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//foi encontrado?
                {
                    tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de dados!";
            }
            return tem;
        }
    }
}
