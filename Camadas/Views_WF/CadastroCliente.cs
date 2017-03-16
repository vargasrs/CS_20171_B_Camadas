using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uteis;

namespace Views_WF
{
  public partial class CadastroCliente : Form
  {
    public CadastroCliente()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      // se clicar em salvar adicionar na lista
      // como classe string ela tem varios metodos que posso usar
      if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtcpf.Text))
      {
        // sobrecarga de metodo: metodo de mesmo nome, mesmo retorno, mas o
        // que muda sao parametros
        MessageBox.Show("Falta preencher campos nomes ou cpf", "ERRO");
      }
      else
      {
        if (Validacoes.ValidarCpf(txtcpf.Text))
        {
          // agora sim salvo no banco de dados.
          // tenho que fazer view enchegar o controller
          // AQUI ESTA A VANTAGEM EM TRABALHAR COM CAMADAS
          ClientesController cliController = new ClientesController();
          cliController.Adicionar(txtNome.Text, txtcpf.Text);
          MessageBox.Show("OPERACAO COM SUCESSO.");
          txtNome.Clear();
          txtcpf.Clear();
        }
        else
        {
          MessageBox.Show("CPF INVALIDO.");
        }
      }
   
    }
  }
}
