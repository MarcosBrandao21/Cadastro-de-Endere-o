using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroDeEndereco
{
    using WebServiceCorreios;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mtbCEP_Click(object sender, EventArgs e)
        {
            mtbCEP.Text = "";
        }

        private void btBuscarCEP_Click(object sender, EventArgs e)
        {
            //verificar se foi passado algum valor ao mtbCEP
            if (!string.IsNullOrEmpty(mtbCEP.Text))
            {
                //criar um objeto do web service
                WebServiceCorreios.AtendeClienteClient servico = new WebServiceCorreios.AtendeClienteClient();

                var CEP = mtbCEP.Text;

                //utilizar um serviço do web service e atribuir a variavel resposta
                var resposta = servico.consultaCEP(CEP);

                //atribuir aos textbox o resultado do CEP pesquisado e retornado pelo serviço
                tbCidade.Text = resposta.cidade;
                tbUF.Text = resposta.uf;
                tbBairro.Text = resposta.bairro;
                tbRua.Text = resposta.end;
            }
            else
            {
                ValidarCEP.Enabled = true;
            }
           
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Popular datagridview
            dgvEnderecos.Rows.Add(tbCidade.Text, tbUF.Text, tbBairro.Text, tbRua.Text, tbNumero.Text);

            //limpar campos apos o cadastro
            mtbCEP.Text = "";
            tbCidade.Text = "";
            tbUF.Text = "";
            tbRua.Text = "";
            tbNumero.Text = "";
        }

    }
}
