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
        public frmConsultaPacientes()
        {
            InitializeComponent();
        }

        private void frmConsultaPacientes_Shown(object sender, EventArgs e)
        {
            // Adicionando dados na tabela 

            gridTabelaPacientes.Rows.Add(
                new object[]
                {
                    "Danilo",
                    "4002-8922",
                    19,
                    "23/09",
                    "Carie"
                }
                );
            gridTabelaPacientes.Rows.Add(
                new object[]
                {
                    "Norberto",
                    "4002-8922",
                    7,
                    "30/09",
                    "Implante"
                }
                );
            gridTabelaPacientes.Rows.Add(
                new object[]
                {
                    "Diogenes",
                    "4002-8922",
                    30,
                    "25/09",
                    "Canal"
                }
                );
        }

    }
}
