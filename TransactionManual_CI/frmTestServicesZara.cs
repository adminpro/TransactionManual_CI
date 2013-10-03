using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransactionManual_CI.com.seur.citpre;
namespace TransactionManual_CI
{
    public partial class frmTestServicesZara : Form
    {
        public frmTestServicesZara()
        {
            InitializeComponent();
        }

        private void frmTestServicesZara_Load(object sender, EventArgs e)
        {
            ImprimirECBWebService obj = new ImprimirECBWebService();
            //obj.impresionIntegracionConECBWS();
            //impresionIntegracionConECBWS
        }
    }
}
