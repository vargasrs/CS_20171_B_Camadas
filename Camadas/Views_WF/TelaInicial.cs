using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views_WF
{
  public partial class TelaInicial : Form
  {
    public TelaInicial()
    {
      InitializeComponent();
    }

    private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CadastroCliente cadCliente = new CadastroCliente();
      // para abrir a janela denro da outra no container
      cadCliente.MdiParent = this;
      cadCliente.Show();
    }
  }
}
