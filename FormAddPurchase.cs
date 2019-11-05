using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManager
{
    public partial class FormAddPurchase : Form
    {
        public FormAddPurchase()
        {
            InitializeComponent();
        }

        private void FormAddPurchase_Load(object sender, EventArgs e)
        {

        }

        private void FormAddPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
