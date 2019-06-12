using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioMed.DAL;

namespace BioMed.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public string dominio = "";

        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerficarLogin(login, senha, dominio);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
                //this.dominio = loginDao.dominio;
            }
            return tem;
        }

        public String Cadastrar(String login, String senha, String confSenha, String nome, String cpf, String dominio, DateTime data)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem= loginDao.CadastrarUsuario(login, senha, confSenha, nome, cpf, dominio, data);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarPaciente(String nome, String nomePai,
                                        String nomeMae, String rg, String cpf, DateTime nascimento, int idade,
                                        String rua, String numero, String bairro, String estado, String cep, String cidade, String celular, String telefone,
                                        String genero, String profissao, String nacionalidade, String instrucao, DateTime dataCa)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarPaciente(nome, nomePai, nomeMae, rg, cpf, nascimento, idade, rua, numero,
                bairro, estado, cep, cidade, celular, telefone, genero, profissao, nacionalidade, instrucao, dataCa);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarExame(String dataConsulta, String exame)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarExame(dataConsulta, exame);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarExameBioquimica(String prontuario, String col, String tri, String hdl, String ldl, String vidl, String @dhe, String dhl, String crea, String bild, String tgo, String tgp, String ferro, String prot, String bhcg, String clor, String fal, String calc, String alb, String cpk, String acur, String phos)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarExameBioquimica(prontuario, col, tri, hdl, ldl, vidl, dhe, dhl, crea, bild, tgo, tgp, ferro, prot, bhcg, clor, fal, calc, alb, cpk, acur, phos);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarExameHematologia(String prontuario, String erit, String hb, String ht, String vmc, String hmc, String chcm, String plaq, String ret, String leuc, String mie, String met, String bas, String seg, String eos, String falci, String baf, String linT, String linA, String mono, String abo, String rh, String vhs, String outros, String observacao)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarExameHematologia(prontuario, erit, hb, ht, vmc, hmc, chcm, plaq, ret, leuc, mie, met, bas, seg, eos, falci, baf, linT, linA, mono, abo, rh, vhs, outros, observacao);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarExameMicrobiologia(String prontuario, String mat, String gram1, String gram2, String micr1, String micr2, String baar, String ccol1, String ccol2)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarExameMicrobiologia(prontuario, mat, gram1, gram2, micr1, micr2, baar, ccol1, ccol2);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String CadastrarExameUrinalise(String prontuario, String cor, String aspc, String dens, String ph, String pt, String gli, String hb, String nit, String cels, String leuc, String hem, String fmuco, String uro, String trin, String cil, String bil, String bac, String cri, String cet, String outros1, String outros2)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.CadastrarExameUrinalise(prontuario, cor, aspc, dens, ph, pt, gli, hb, nit, cels, leuc, hem, fmuco, uro, trin, cil, bil, bac, cri, cels, outros1, outros2);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public string DeletarLogin(String usuario)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.DeletarLogins(usuario);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public string DeletarPaciente(String cpf)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.DeletarPaciente(cpf);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
