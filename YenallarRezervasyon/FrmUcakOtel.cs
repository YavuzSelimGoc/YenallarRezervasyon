using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YenallarRezervasyon
{
    public partial class FrmUcakOtel : Form
    {
        KonaklamaRezManager KonaklamaRezManager = new KonaklamaRezManager(new Fact_Ucak_Otel());
        public FrmUcakOtel()
        {
            InitializeComponent();
        }

        private void FrmUcakOtel_Load(object sender, EventArgs e)
        {

        }
    }
}
