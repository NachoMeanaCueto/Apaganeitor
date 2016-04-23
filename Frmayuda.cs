using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApaganeiForm
{
    public partial class Frmayuda : Form
    {
        public Frmayuda()
        {
            InitializeComponent();
        }

        private void btnAyudaAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
