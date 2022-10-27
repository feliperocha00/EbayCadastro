using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbayCadastro
{
    public partial class Form2 : Form
    {
        Cadastro1 cad1 = new Cadastro1();
        public Form2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedItem == null) || (Endereco.Text == "") || (Cidade.Text == "") || (Cep.Text == "") || (Estado.Text == "") || (Telefone.Text == ""))
            {
                MessageBox.Show("Preencha os campos obrigatórios (*) e tente novamente.", "Falha ao finalizar cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cad1.setPais(comboBox1.Text);
                cad1.setEnderecofull(Endereco.Text);
                cad1.setComplemento(Complemento.Text);
                cad1.setCidade(Cidade.Text);
                cad1.setCep(Cep.Text);
                cad1.setEstado(Estado.Text);
                cad1.setTelefone(Telefone.Text);

                var result = MessageBox.Show("Cadastro realizado com sucesso!", "Usuario cadastrado", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (result == DialogResult.OK) Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
