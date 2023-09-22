using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odonto_csharp
{
    public partial class frmConsultaPacientes : Form
    {
        DataTable tabela = new DataTable();
        public frmConsultaPacientes()
        {
            InitializeComponent();
        }

        private void frmConsultaPacientes_Shown(object sender, EventArgs e)
        {
           
        }

        private void frmConsultaPacientes_Load(object sender, EventArgs e)
        {
           
        }

        private void gridTabelaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }
    }
}
