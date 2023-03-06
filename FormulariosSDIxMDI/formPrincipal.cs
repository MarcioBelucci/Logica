using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosSDIxMDI
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            formCliente fcliente = new formCliente();
            fcliente.Show();
        }

        private void menuCadProdutos_Click(object sender, EventArgs e)
        {
            formProduto fproduto = new formProduto();
            fproduto.MdiParent = this;
            fproduto.Show();
        }
    }
}
