using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayCadastro
{
    internal class Cadastro1
    {
        public string nome;
        public string sobrenome;
        public string email;
        public string senha;
        public Endereco endr;

        public Cadastro1()
        {
            this.nome = "";
            this.sobrenome = "";
            this.email = "";
            this.senha = "";
            this.endr = new Endereco();
        }

        public Cadastro1(string nome_p, string sobrenome_p, string email_p, string senha_p)
        {
            this.nome = nome_p;
            this.sobrenome = sobrenome_p;
            this.email = email_p;
            this.senha = senha_p;
        }

        //Cadastro Tela 1
        public string getNome() { return nome; }
        public void setNome(string nome_p) { this.nome = nome_p; }

        public string getSobrenome() { return sobrenome; }
        public void setSobrenome(string sobrenome_p) { this.sobrenome = sobrenome_p; }

        public string getEmail() { return email; }
        public void setEmail(string email_p) { this.email = email_p; }

        public string getSenha() { return senha; }
        public void setSenha(string senha_p) { this.senha = senha_p; }


        //Endereco Tela 2
        public string getPais() { return this.endr.pais; }
        public void setPais(string pais_p) { this.endr.pais = pais_p; }

        public string getEnderecofull() { return this.endr.enderecofull; }
        public void setEnderecofull(string enderecofull_p) { this.endr.enderecofull = enderecofull_p; }

        public string getComplemento() { return this.endr.complemento; }
        public void setComplemento(string complemento_p) { this.endr.complemento = complemento_p; }

        public string getCidade() { return this.endr.cidade; }
        public void setCidade(string cidade_p) { this.endr.cidade = cidade_p; }

        public string getEstado() { return this.endr.estado; }
        public void setEstado(string estado_p) { this.endr.estado = estado_p; }

        public string getCep() { return this.endr.cep; }
        public void setCep(string cep_p) { this.endr.cep = cep_p; }

        public string getTelefone() { return this.endr.telefone; }
        public void setTelefone(string telefone_p) { this.endr.telefone = telefone_p; }
    }
}
