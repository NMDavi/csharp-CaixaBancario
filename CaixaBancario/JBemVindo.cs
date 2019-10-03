using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaBancario
{
    public partial class JBemVindo : Form
    {
        public JBemVindo()
        {
            InitializeComponent();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            JPrincipal jPrincipal = new JPrincipal();
            jPrincipal.Show();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            AboutBoxSobre aboutBoxSobre = new AboutBoxSobre();
            aboutBoxSobre.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}